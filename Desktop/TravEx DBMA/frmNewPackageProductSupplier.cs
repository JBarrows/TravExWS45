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
using Team4_Workshop4;

namespace TravEx_DBMA
{
    public partial class frmNewPackageProductSupplier : Form
    {
        Product[] products;
        List<Supplier> suppliers;

        public TravelPackage Package { get; set; }
        public frmNewPackageProductSupplier()
        {
            InitializeComponent();
        }

        private void frmNewPackageProductSupplier_Load(object sender, EventArgs e)
        {
            //Populate product list
            products = ProductDB.GetProducts().ToArray();
            cboProduct.DataSource = products;
            cboProduct.SelectedIndex = 0;
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppliers = new List<Supplier>();
            cboSuppliers.Items.Clear();

            int productID = (int)cboProduct.SelectedValue;
            //Populate supplier list for all suppliers offering the selected product
            //Get supplierIDs
            var possibleSuppliers = ProductSupplierDB.GetProdudtSuppliers();
            var availableSupplierIDs = from supplier in possibleSuppliers
                                     where supplier.ProductId == productID
                                     select supplier.SupplierId;

            //Add suppliers to our list
            foreach (int id in availableSupplierIDs)
            {
                suppliers.Add(SupplierDB.GetSupplier(id));
            }

            //Add list to the dropdown
            cboSuppliers.DataSource = suppliers;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Package == null) throw new MissingMemberException("Package is not assigned");

            // Add ProductPackageSupplier to database
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
