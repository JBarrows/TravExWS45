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
    public partial class frmNewPackageProductSupplier : Form
    {
        public TravelPackage Package { get; set; }
        public frmNewPackageProductSupplier()
        {
            InitializeComponent();
        }

        private void frmNewPackageProductSupplier_Load(object sender, EventArgs e)
        {
            //Populate product list
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Populate supplier list for all suppliers offering the selected product 
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
