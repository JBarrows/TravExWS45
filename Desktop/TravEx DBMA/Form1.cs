using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsPackages;


namespace TravEx_DBMA
{
    public partial class Form1 : Form
    {
        enum AccessMode
        {
            Read,
            Edit,
            Add
        }

        TravelPackage selectedPackage;

        AccessMode accessMode;

        public Form1()
        {
            InitializeComponent();
        }

        #region PRODUCT_TAB

        #endregion

        #region SUPPLIER_TAB     

        AccessMode tabSupplierAccessMode;

        Supplier sup, oldSup;

        //handles the Leave event of the tabSuppliers control
        private void tabSuppliersLeave(object sender, EventArgs e)
        {
            tabSupplierAccessMode = AccessMode.Read;
            txtSupplierId.Text = "";
            cmbSupId.Text = "";
            cmbSupId.Items.Clear();
            lvSuppliedProds.Items.Clear();
            lvProducts.Items.Clear();
            lblProdMessage.Text = "";
            lblSupMessage.Text = "";
        }

        // fills the suppliers information when enter the tabSuppliers
        private void tabSuppliersEnter(object sender, EventArgs e)
        {
            tabSuppliersDefaultStatus();
        }
        
        // the default setting of tha tabSuppliers control
        private void tabSuppliersDefaultStatus()
        {
            try
            {
                tabSupplierAccessMode = AccessMode.Edit;
                refreshCmbSupIdItems(); // get the latest suppliers list
                cmbSupId.SelectedIndex = 0;
                btnSaveSup.Enabled = false;
                lblSupMessage.Text = "";
                lblProdMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading supplier data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        // get the lastest suppliers list
        private void refreshCmbSupIdItems()
        {
            List<Supplier> suppliers;
            cmbSupId.Items.Clear();
            suppliers = SupplierDB.GetAllSuppliers(); // get the latest suppliers' data
            //add items to the SupId combobox which the displaymember is SupName and valuemember is SupplierID
            cmbSupId.Items.AddRange(suppliers.ToArray());
            //initialize the selected index and the method of cmbSupId_SelectedValueChanged would excute
        }

        //when selecting the existed supplier name
        private void cmbSupId_SelectedValueChanged(object sender, EventArgs e)
        {
            tabSupplierAccessMode = AccessMode.Edit;
            btnSaveSup.Enabled = false;
            lblSupMessage.Text = "";
            lblProdMessage.Text = "";
            btnDeleteSup.Enabled = true;// let the Delete button enabled 
            btnAddSuppliedProd.Enabled = true;// let the supplied products can be edited
            btnRemoveSuppliedProd.Enabled = true;// let the supplied products can be edited

            sup = cmbSupId.SelectedItem as Supplier; //get the selected supplier's data
            oldSup = sup.CopySupplier(); // make a  separate copy before update
            txtSupplierId.Text = sup.SupplierId.ToString(); //display the supplierid
            
            refreshTabSuppliersListViews();
        }

        //get the latest relative products' data and dispaly in the lvSuppliedProds and lvProducts
        private void refreshTabSuppliersListViews()
        {
            if (tabSupplierAccessMode == AccessMode.Add) //if the New button is clicked
            {
                int i = 0;
                lvSuppliedProds.Items.Clear();//clear the ListView for a new supplier

                //get all products available from the Products table
                List<Product> products;
                products = ProductDB.GetProducts();
                //display the data in the lvProducts
                lvProducts.Items.Clear();
                foreach (var prod in products)
                {
                    lvProducts.Items.Add(prod.ProductId.ToString());
                    lvProducts.Items[i].SubItems.Add(prod.ProdName);
                    i++;
                }
            }
            else if (tabSupplierAccessMode == AccessMode.Edit)
            {
                List<Product> suppliedProds, unsuppliedProds;
                int i = 0, j = 0;
                //get all products supplied by the supplier
                suppliedProds = SupplierDB.GetProductsBySupplier(sup.SupplierId);
                lvSuppliedProds.Items.Clear();
                foreach (var supProd in suppliedProds)
                {
                    lvSuppliedProds.Items.Add(supProd.ProductId.ToString());
                    lvSuppliedProds.Items[i].SubItems.Add(supProd.ProdName);
                    i++;
                }

                //get all products not supplied by the supplier
                unsuppliedProds = SupplierDB.GetProdsUnsuppliedBySup(sup.SupplierId);
                lvProducts.Items.Clear();
                foreach (var supProd in unsuppliedProds)
                {
                    lvProducts.Items.Add(supProd.ProductId.ToString());
                    lvProducts.Items[j].SubItems.Add(supProd.ProdName);
                    j++;
                }
            }
        }

        //modify the supplier name which can happend when the accessMode is either Add or Edit;
        private void cmbSupId_TextChanged(object sender, EventArgs e)
        {
            btnSaveSup.Enabled = true;
            lblProdMessage.Text = "";
            lblSupMessage.Text = "";
        }

        //clicks the New button to let user add a new supplier
        private void btnNewSup_Click(object sender, EventArgs e)
        {            
            refreshCmbSupIdItems();
            cmbSupId.SelectedIndex = 0;
            txtSupplierId.Text = "";
            cmbSupId.Text = "";            
            lblSupMessage.Text = "";
            lblProdMessage.Text = "";
            btnDeleteSup.Enabled = false;//Can not be used before a new supplier is created.
            btnAddSuppliedProd.Enabled = false; //Can not be used before a new supplier is created.
            btnRemoveSuppliedProd.Enabled = false; //Can not be used before a new supplier is created.
            tabSupplierAccessMode = AccessMode.Add;
            refreshTabSuppliersListViews();
        }

        //clicks the button to delete the supplier from the batabase
        private void btnDeleteSup_Click(object sender, EventArgs e)
        {
            sup.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            sup.SupName = cmbSupId.Text;
            if (SupplierDB.DeleteSupplier(sup))
            {
                tabSuppliersDefaultStatus();
            }
            else
            {
                lblSupMessage.Text = "Failed to delete the supplier.";
            }           
        }

        //click the Save button to save the new data or updated data
        private void btnSaveSup_Click(object sender, EventArgs e)
        {
            List<Supplier> suppliers;
            suppliers = SupplierDB.GetAllSuppliers(); // get the lastest suppliers' data
            Product removeSupProd = new Product();
            List<Product> newSuppliedProds = new List<Product>();
            ProductSupplier supProd = new ProductSupplier();
            //validate the cmbSupName
            if (cmbSupId.Text =="")
            {
                lblSupMessage.Text = "Please enter a supplier name.";
            }
            else
            {
                if (tabSupplierAccessMode == AccessMode.Edit)
                {
                    sup.SupName = cmbSupId.Text;
                    sup.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                    if (SupplierDB.UpdateSupplier(oldSup, sup))
                    {
                        lblSupMessage.Text = "Successfully updated the supplier name.";
                        refreshCmbSupIdItems();
                        oldSup = sup.CopySupplier();
                        btnSaveSup.Enabled = false;
                    }
                    else
                    {
                        lblSupMessage.Text = "Failed to update the supplier name.";
                    }
                }
                else if (tabSupplierAccessMode == AccessMode.Add)
                {
                    sup.SupplierId = SupplierDB.GetNewSupplierId();//create a new supplierId
                    sup.SupName = cmbSupId.Text; //get the entered name

                    if (SupplierDB.AddSupplier(sup))
                    {
                        // once a new supplier's data is inserted into the Suppliers table
                        txtSupplierId.Text = sup.SupplierId.ToString();//display the new supplierId                   
                        btnDeleteSup.Enabled = true;// let the Delete button enabled 
                        btnAddSuppliedProd.Enabled = true;// let the supplied products can be edited
                        btnRemoveSuppliedProd.Enabled = true;// let the supplied products can be edited
                        lblSupMessage.Text = "Successfully added the new supplier.";
                        refreshCmbSupIdItems();
                        btnSaveSup.Enabled = false;
                        tabSupplierAccessMode = AccessMode.Edit;
                    }
                    else
                    {
                        lblSupMessage.Text = "Failed to add the new supplier.";
                    }
                }

            }
            
        }

        //clicks the button to add one supplied product into the database and refresh the ListViews
        private void btnAddSuppliedProd_Click(object sender, EventArgs e)
        {
            tabSupplierAccessMode = AccessMode.Edit;
            ProductSupplier removeSupProd = new ProductSupplier();
            //get the single selected Item
            ListView.SelectedListViewItemCollection selectedProds = lvProducts.SelectedItems;

            if (lvProducts.SelectedItems.Count > 0)//if there is selected item
            {
                //get the value of the selected item
                ListViewItem item = lvProducts.SelectedItems[0];
                removeSupProd.ProductId = Convert.ToInt32(item.SubItems[0].Text);
                removeSupProd.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                // add the data to the Products_Suppliers table and return a ProductsSupplierId
                if (ProductSupplierDB.AddSupProd(removeSupProd) > 0) //if a ProductSupplierId is created
                {                    
                    lblProdMessage.Text = "Successfully added a new supplied product.";
                    refreshTabSuppliersListViews(); //refresh the ListViews
                }
                else
                {
                    lblProdMessage.Text = "Failed to add a new supplied product.";
                }
            }
            else
            {
                lblProdMessage.Text = "Please select a productId";
            }
        }

        //clicks the button to remove one product from the suppliedProd listView
        private void btnRemoveSuppliedProd_Click(object sender, EventArgs e)
        {
            tabSupplierAccessMode = AccessMode.Edit;
            ProductSupplier removeSupProd = new ProductSupplier();
            //get the single selected Item
            ListView.SelectedListViewItemCollection selectedProds = lvSuppliedProds.SelectedItems;
       
            if (lvSuppliedProds.SelectedItems.Count > 0)//if there is selected item
            {
                //get the value of the selected item
                ListViewItem item = lvSuppliedProds.SelectedItems[0];
                removeSupProd.ProductId = Convert.ToInt32(item.SubItems[0].Text);
                removeSupProd.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                // delete the data from the Products_Suppliers table
                if (ProductSupplierDB.DeleteSupProd(removeSupProd)) //if it is true
                {
                    lblProdMessage.Text = "Successfully removed the product.";
                    refreshTabSuppliersListViews(); //refresh the ListViews
                }
                else
                {
                    lblProdMessage.Text = "Failed to remove the supplied product.";
                }
            }
            else
            {
                lblProdMessage.Text = "Please select a productId";
            }
        }
     

        #endregion

        #region PACKAGE_TAB

        /// <summary>
        /// Fills the package ComboBox.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void FillPackageComboBox(object sender, EventArgs e)
        {
            //Fills the selection box with package items
            cmbPackageID.Items.Clear();
            cmbPackageID.Items.AddRange(PackageDB.GetTravelPackages().ToArray());
            cmbPackageID.SelectedIndex = 0;
            accessMode = AccessMode.Read;
        }

        /// <summary>
        /// Handles the Leave event of the tabPackages control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tabPackages_Leave(object sender, EventArgs e)
        {
            selectedPackage = null;
            accessMode = AccessMode.Read;
            lblStatus.Text = "";
        }

        /// <summary>
        /// Handles the SelectedValueChanged event of the cmbPackageID control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbPackageID_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem == null)
            {
                selectedPackage = null;
                return;
            }

            selectedPackage = cmbPackageID.SelectedItem as TravelPackage;
            FillPackageControls(selectedPackage);
            FillPackageProductList(selectedPackage);
            accessMode = AccessMode.Read;
            btnPkgSave.Enabled = false;
            lblStatus.Text = "Package loaded";
        }

        /// <summary>
        /// Fills the package product list box with named Product_Supplier objects.
        /// </summary>
        /// <param name="selectedPackage">The selected package.</param>
        /// <exception cref="NotImplementedException"></exception>
        private void FillPackageProductList(TravelPackage selectedPackage)
        {
            foreach (NamedPackageProductSupplier prodSup in selectedPackage.ProductsAndSuppliers)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(prodSup.ProductName);
                item.SubItems.Add(prodSup.SupplierName);
                lstPkgProductSuppliers.Items.Add(item);
            }
        }

        /// <summary>
        /// Fills the package controls.
        /// </summary>
        /// <param name="package">The package.</param>
        private void FillPackageControls(TravelPackage package)
        {
            txtPkgDesc.Text = package.Description;
            datPkgStart.Value = package.StartDate;
            datPkgEnd.Value = package.EndDate;
            txtPkgBasePrice.Text = package.BasePrice.ToString();
            txtPkgCommission.Text = package.Commission.ToString();
        }

        //Put the form into edit mode when necessary
        private void OnPackageDataModified(object sender, EventArgs e)
        {
            //Skip this if in add mode, or already in edit mode 
            if (accessMode == AccessMode.Add)
                return;

            accessMode = AccessMode.Edit;
            btnPkgSave.Enabled = true;
            lblStatus.Text = "Modifying package";
        }

        /// <summary>
        /// Handles the Click event of the btnPkgSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPkgSave_Click(object sender, EventArgs e)
        {
            if (accessMode == AccessMode.Read)
            {
                MessageBox.Show("Cannot save changes in edit mode");
                return;
            }

            if (!ValidatePkgTab())
                return;

            if (accessMode == AccessMode.Add)
            {
                TravelPackage newPackage = new TravelPackage()
                {
                    Name = cmbPackageID.Text,
                    Description = txtPkgDesc.Text,
                    StartDate = datPkgStart.Value,
                    EndDate = datPkgEnd.Value,
                    BasePrice = double.Parse(txtPkgBasePrice.Text),
                    Commission = double.Parse(txtPkgCommission.Text)
                };
                //Add package
                newPackage = PackageDB.Insert(newPackage);

                //Refresh
                FillPackageComboBox(sender, e);
                int newIndex = cmbPackageID.Items.IndexOf(newPackage);
                cmbPackageID.SelectedIndex = newIndex;
                lblStatus.Text = "Package created";
            }
            else if (accessMode == AccessMode.Edit)
            {
                TravelPackage newPackage = new TravelPackage(selectedPackage.ID)
                {
                    Name = cmbPackageID.Text,
                    Description = txtPkgDesc.Text,
                    StartDate = datPkgStart.Value,
                    EndDate = datPkgEnd.Value,
                    BasePrice = double.Parse(txtPkgBasePrice.Text),
                    Commission = double.Parse(txtPkgCommission.Text)
                };
                //Update Package
                PackageDB.Update(selectedPackage, newPackage);

                //Refresh
                FillPackageComboBox(sender, e);
                cmbPackageID.SelectedValue = newPackage.ID;
                lblStatus.Text = "Package updated";
            }
        }

        private bool ValidatePkgTab()
        {
            string message = string.Empty;

            //Check that Name is not empty
            if (cmbPackageID.Text.Length < 0)
                message = "Name cannot be left empty";
            //Check that start date is before end date
            else if (datPkgStart != null && datPkgEnd != null && datPkgStart.Value > datPkgEnd.Value)
                message = "End date cannot be before start date";
            //Check that Price is not empty, not negative
            else if (string.IsNullOrWhiteSpace(txtPkgBasePrice.Text)
                    || !double.TryParse(txtPkgBasePrice.Text, out double val)
                    || val < 0)
                message = "Base Price must have a non-negative numeric value";
            //TODO: Check that Commission is not negative


            //IF this is reached with no message, return true
            if (message == string.Empty)
                return true;

            //If an error was found, show message and return false
            MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        /// <summary>
        /// Handles the Click event of the btnAddPackage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            //Clear form
            ResetPkgTab();

            //Set status to adding
            accessMode = AccessMode.Add;
            lblStatus.Text = "Adding new package";
        }

        /// <summary>
        /// Resets the PKG tab.
        /// </summary>
        private void ResetPkgTab()
        {
            //Clear form
            cmbPackageID.SelectedItem = null;
            cmbPackageID.Select();
            txtPkgDesc.ResetText();
            datPkgStart.Value = DateTime.Today;
            datPkgEnd.Value = DateTime.Today;
            txtPkgBasePrice.ResetText();
            txtPkgCommission.ResetText();
        }







        #endregion

        
    }
}
