﻿using System;
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

        AccessMode accessMode = AccessMode.Read;
        TravelPackage selectedPackage;

        public Form1()
        {
            InitializeComponent();
        }

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
            accessMode = AccessMode.Read;
            btnPkgSave.Enabled = false;
            lblStatus.Text = "Package loaded";
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

            double val;
            //Check that Name is not empty
            if (cmbPackageID.Text.Length < 0)
                message = "Name cannot be left empty";
            //Check that start date is before end date
            else if (datPkgStart != null && datPkgEnd != null && datPkgStart.Value > datPkgEnd.Value)
                message = "End date cannot be before start date";
            //Check that Price is not empty, not negative
            else if (string.IsNullOrWhiteSpace(txtPkgBasePrice.Text)
                    || !double.TryParse(txtPkgBasePrice.Text, out val)
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
