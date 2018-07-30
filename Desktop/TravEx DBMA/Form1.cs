using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        AccessMode accessMode = AccessMode.Read;
        TravelPackage selectedPackage;

        public Form1()
        {
            InitializeComponent();
        }
//======= Start of Product Region ====================== Author: Carol He =========================================================================================
        #region PRODUCT_TAB

        public List<Product> products = ProductDB.GetProducts(); // get product List form Products table
        public List<Supplier> suppliers = SupplierDB.GetSuppliers(); // get supplier List from Suppliers table
        public List<ProductSupplier> products_suppliers = ProductSupplierDB.GetProductsSuppliers();
        public Product product;

        //----Author: Carol He ----- Load ProductIdComboBox, ProductList and SupplierList when Product Tab is entered
        public void tabProducts_Enter(object sender, EventArgs e)
        {
            //productIdComboBox.SelectedIndex = 1;

            loadProductIdComboBox();

            LoadProductList();

            LoadSupplierList();

        }

        public void loadProductIdComboBox()
        {
            products = ProductDB.GetProducts();
            foreach (var p in products)   //add all the ProductId values to ProductIdComboBox
            {
                productIdComboBox.Items.Add(p.ProductId);
            }
        }

        public void LoadProductList()
        {
            //get data from Products table and display in list view
            products = ProductDB.GetProducts();

            var product = from pro in products
                          select new
                          {
                              pro.ProductId,
                              pro.ProdName
                          };

            lvProProducts.Items.Clear();

            int j = 0;
            foreach (var p in products)
            {
                lvProProducts.Items.Add(p.ProductId.ToString());

                lvProProducts.Items[j].SubItems.Add(p.ProdName.ToString());

                j++;
            }
        }

        public void LoadSupplierList()
        {
            //get data from Suppliers table and display in list view
            var supplier = from sup in suppliers
                           select new
                           {
                               sup.SupplierId,
                               sup.SupName
                           };

            lvSuppliers.Items.Clear();

            int k = 0;
            foreach (var s in suppliers)
            {
                lvSuppliers.Items.Add(s.SupplierId.ToString());

                lvSuppliers.Items[k].SubItems.Add(s.SupName.ToString());

                k++;
            }
        }

        //----- Author: Carol He ------Display ProdName in txtProdName Textbox when user selected a ProductId from productIdComboBox -------------------------------------------------------------------------------
        //---get the values of product.ProductId and product.ProdName for the current Product instance
        private void productIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductSupplierList();

            //Display ProdName in txtProdName Textbox according to productId given in ProductIdComboBox
            int productId = Convert.ToInt32(productIdComboBox.SelectedItem);
            product = ProductDB.GetProduct(productId);
            txtProdName.Text = product.ProdName;

            //product = new Product();
            //product.ProductId = Convert.ToInt32(productIdComboBox.SelectedItem);
            //product.ProdName = txtProdName.Text;
            
        }

        public void LoadProductSupplierList()
        {
            suppliers = SupplierDB.GetSuppliers();
            products_suppliers = ProductSupplierDB.GetProductsSuppliers();

            var sup = from prod_supp in products_suppliers
                           join supp in suppliers             
                           on prod_supp.SupplierId equals supp.SupplierId
                           where prod_supp.ProductId == (int)productIdComboBox.SelectedItem
                           select new
                           {
                               prod_supp.SupplierId,
                               supp.SupName,
                               prod_supp.ProductId,
                               prod_supp.ProductSupplierId
                           };
            lvProductSupplier.Items.Clear();
            int i = 0;
            foreach (var s in sup)
            {
                lvProductSupplier.Items.Add(s.SupplierId.ToString());

                lvProductSupplier.Items[i].SubItems.Add(s.SupName);
                lvProductSupplier.Items[i].SubItems.Add(s.ProductId.ToString());
                lvProductSupplier.Items[i].SubItems.Add(s.ProductSupplierId.ToString());

                i++;
            }
        }



 //------ Author: Carol He ----------------------------------------------------------------------------------------


        private void DisplayProduct()
        {
           
            txtProdName.Text = product.ProdName;
            //btnModify.Enabled = true;
            //btnDelete.Enabled = true;
        }
        private void GetProduct(int productID)
        {
            try
            {
                product = ProductDB.GetProduct(productID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ClearControls()
        {

            txtProdName.Text = "";
            productIdComboBox.Text = "";
            //btnModify.Enabled = false;
            //btnDelete.Enabled = false;
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddUpdateProduct modifyProductForm = new frmAddUpdateProduct();
            modifyProductForm.addProduct = false;
            modifyProductForm.product = product;
            DialogResult result = modifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                product = modifyProductForm.product;
                this.DisplayProduct();
                //modifyProductForm.txtProductId = 

            }
            else if (result == DialogResult.Retry)
            {
                this.GetProduct(product.ProductId);
                if (product != null)
                    this.DisplayProduct();
                else
                    this.ClearControls();
            }

            LoadProductList();
            ClearControls();
        }

        //--------Author: Carol He ----------Add New Product---------------------------------------------------------------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateProduct addProductForm = new frmAddUpdateProduct();
            addProductForm.addProduct = true;
            //addProductForm.product = product;
            DialogResult result = addProductForm.ShowDialog();

            productIdComboBox.Items.Clear();
            loadProductIdComboBox();
            LoadProductList();
            ClearControls();


            //if (result == DialogResult.OK)
            //{
            //    product = addProductForm.product;
            //    txtCustomerID.Text = customer.CustomerID.ToString();
            //    this.DisplayCustomer();
            //}


            //frmAddModifyCustomer addCustomerForm = new frmAddModifyCustomer();
            //addCustomerForm.addCustomer = true;
            //DialogResult result = addCustomerForm.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    customer = addCustomerForm.customer;
            //    txtCustomerID.Text = customer.CustomerID.ToString();
            //    this.DisplayCustomer();
            //}
        }

 //--------Author: Carol He ----------Delete Product---------------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete " + product.ProdName + "?",
               "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!ProductDB.DeleteProduct(product))
                    {
                        MessageBox.Show("Another user has updated or deleted " +
                            "that product.", "Database Error");
                        this.GetProduct(product.ProductId);
                        if (product != null)
                            this.DisplayProduct();
                        else
                            this.ClearControls();
                    }
                    else
                        this.ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                MessageBox.Show("Product has been deleted successfully");

                ClearControls();
                LoadProductList();
                productIdComboBox.Items.Clear();
                loadProductIdComboBox();
            }
        }
        //--------Author: Carol He ----------Clear Button-------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        //--------Author: Carol He ----------Exit Button------------------------------------------------

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //====== End of Product Region ======================================================================================
        #endregion

        //========== Author: Lindsay ================================================================================
        #region SUPPLIER_TAB

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
    }
}


        #endregion

