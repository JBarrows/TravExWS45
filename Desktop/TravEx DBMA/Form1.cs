using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team4_Workshop4;
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

        public Form1()
        {
            InitializeComponent();
        }

        #region PRODUCT_TAB

        #endregion

        #region SUPPLIER_TAB

        List<Supplier> suppliers;// list of all suppliers
        Supplier sup;
        List<NamedProductSupplier> suppliedProds;

        // Fills the suppliers information when enter the tabSuppliers.
        private void tabSuppliersEnter(object sender, EventArgs e)
        {           
            try
            {
                cmbSupName.Items.Clear();
                suppliers = SupplierDB.GetAllSuppliers(); // get the supplier list
                //add items to the SupName combobox
                cmbSupName.Items.AddRange(suppliers.ToArray());
                cmbSupName.SelectedIndex = 0;             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading supplier data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        //Handles the Leave event of the tabSuppliers control.
        private void tabSuppliersLeave(object sender, EventArgs e)
        {
            //selectedSupplier = null;
            accessMode = AccessMode.Read;
            //lblStatus.Text = "";
        }

        private void DisplaySupplier(int index)
        {

            int i=0;
            sup = suppliers[index];
            lvSuppliedProds.Items.Clear();
            txtSupplierId.Text = sup.SupplierId.ToString();
            suppliedProds = SuppliedProdDB.GetProductsBySupplier(sup.SupplierId);
            foreach (var supProd in suppliedProds)
            {
                lvSuppliedProds.Items.Add(supProd.ProductId.ToString());
                lvSuppliedProds.Items[i].SubItems.Add(supProd.ProductName.ToString());
                i++;
            }

        }
        
        private void cmbSupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySupplier(cmbSupName.SelectedIndex);
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSup_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSup_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region PACKAGE_TAB

        /// <summary>
        /// The selected package on the Package tab
        /// </summary>
        TravelPackage selectedPackage;

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
            lblPkgStatus.Text = "";
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
            lblPkgStatus.Text = "Package loaded";
        }
        
        /// <summary>
        /// Fills the package product list box with named Product_Supplier objects.
        /// </summary>
        /// <param name="selectedPackage">The selected package.</param>
        /// <exception cref="NotImplementedException"></exception>
        private void FillPackageProductList(TravelPackage selectedPackage)
        {
            lstPkgProductSuppliers.Items.Clear();
            foreach (NamedPackageProductSupplier prodSup in selectedPackage.ProductsAndSuppliers)
            {
                ListViewItem item = new ListViewItem(prodSup.ProductName);
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
            lblPkgStatus.Text = "Modifying package";
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
                    Commission = null
                };
                if (double.TryParse(txtPkgCommission.Text, out double c))
                    newPackage.Commission = c;
                //Add package
                newPackage = PackageDB.Insert(newPackage);

                //Refresh
                FillPackageComboBox(sender, e);
                // Maybe loop through packages to find the new ID?
                cmbPackageID.SelectedIndex = cmbPackageID.Items.Count - 1;
                lblPkgStatus.Text = "Package created";
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
                    Commission = null
                };
            if (double.TryParse(txtPkgCommission.Text, out double c))
                newPackage.Commission = c;

            //Update Package
            PackageDB.Update(selectedPackage, newPackage);

                //Refresh
                int selectedIndex = cmbPackageID.SelectedIndex;
                FillPackageComboBox(sender, e);
                cmbPackageID.SelectedIndex = selectedIndex;
                lblPkgStatus.Text = "Package updated";
            }
        }

        private bool ValidatePkgTab()
        {
            string message = string.Empty;
            //Check that Name is not empty
            if (cmbPackageID.Text.Length < 0)
                message = "Name cannot be left empty";
            //Check that start date is before end date
            else if (datPkgStart.Value != null && datPkgEnd.Value != null && datPkgStart.Value > datPkgEnd.Value)
                message = "End date cannot be before start date";
            //Check that Price is not empty, not negative
            else if (string.IsNullOrWhiteSpace(txtPkgBasePrice.Text)
                    || !double.TryParse(txtPkgBasePrice.Text, out double price)
                    || price < 0)
                message = "Base Price must have a non-negative numeric value";
            // Check that Commission is not negative
            else if (double.TryParse(txtPkgCommission.Text, out double commission)
                        && (commission < 0 || commission > price))
            {
                message = "Commission must be greater than 0 and less than base price";
            }

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
            lblPkgStatus.Text = "Adding new package";
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
            datPkgEnd.Value = DateTime.Today + TimeSpan.FromDays(1); //Tomorrow
            txtPkgBasePrice.ResetText();
            txtPkgCommission.ResetText();
        }
        
        // Remove a product from the current package
        private void btnDeleteProd_Supplier_Click(object sender, EventArgs e)
        {
            //Confirm
            DialogResult confirmation = DialogResult.No;
            confirmation = MessageBox.Show("Are you sure you want to remove the selected product(s) from '" + 
                                            selectedPackage.Name + "'?", "Confirm Delete", MessageBoxButtons.YesNo, 
                                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirmation != DialogResult.Yes)
                return; //Escape if user does not confirm

            int rowsDeleted = 0;
            foreach (int i in lstPkgProductSuppliers.SelectedIndices)
            {
                //Remove each selected product
                rowsDeleted += PackageProdSuppDB.Delete(selectedPackage.ProductsAndSuppliers[i]);
            }

            //Display result
            FillPackageProductList(selectedPackage);
            lblPkgStatus.Text = "Products removed";
            MessageBox.Show(rowsDeleted + " record(s) deleted from database.", "Deletion Successful");
        }

        // Deletes the currently selected package
        private void btnPkgDelete_Click(object sender, EventArgs e)
        {
            //Delete Package
            DialogResult confirmation = DialogResult.No;
            confirmation = MessageBox.Show("Are you sure you want to delete the package '" +
                                            selectedPackage.Name + "'?", "Confirm Delete", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirmation != DialogResult.Yes)
                return;

            int rowsDeleted = 0;
            try
            {
                rowsDeleted = PackageDB.Delete(selectedPackage);
                if (rowsDeleted > 0)
                {
                    //package deleted. Refill combo box and display result
                    FillPackageComboBox(btnPkgDelete, EventArgs.Empty);
                    lblPkgStatus.Text = "Package deleted";
                    MessageBox.Show("Package deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Package");
            }
        }

        // Show "Add Product to Package" dialog
        private void btnAddProduct_Supplier_Click(object sender, EventArgs e)
        {
            frmNewPackageProductSupplier addDialog = new frmNewPackageProductSupplier
            {
                Package = selectedPackage
            };
            DialogResult result = addDialog.ShowDialog();
            if (result != DialogResult.OK) return; //Escape if OK is not returned

            FillPackageProductList(selectedPackage);
            lblPkgStatus.Text = "Product added to package";
        }



        #endregion

        
    }
}
