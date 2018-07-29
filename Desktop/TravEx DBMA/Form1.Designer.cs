namespace TravEx_DBMA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label returnDateLabel;
            System.Windows.Forms.Label departureDateLabel;
            System.Windows.Forms.Label commissionLabel;
            System.Windows.Forms.Label basePriceLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label supplierIdLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.cmbSupName = new System.Windows.Forms.ComboBox();
            this.btnSaveSup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lvSuppliedProds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteSup = new System.Windows.Forms.Button();
            this.btnNewSup = new System.Windows.Forms.Button();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.btnPkgDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstPkgProductSuppliers = new System.Windows.Forms.ListView();
            this.colSuppliers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProducts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteProd_Supplier = new System.Windows.Forms.Button();
            this.btnAddProduct_Supplier = new System.Windows.Forms.Button();
            this.btnPkgSave = new System.Windows.Forms.Button();
            this.lblPkgStatus = new System.Windows.Forms.Label();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgCommission = new System.Windows.Forms.TextBox();
            this.datPkgStart = new System.Windows.Forms.DateTimePicker();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.cmbPackageID = new System.Windows.Forms.ComboBox();
            this.datPkgEnd = new System.Windows.Forms.DateTimePicker();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            commissionLabel = new System.Windows.Forms.Label();
            basePriceLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 88);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(3, 10);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(53, 13);
            iDLabel.TabIndex = 8;
            iDLabel.Text = "Package:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(320, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 13);
            label1.TabIndex = 8;
            label1.Text = "Included products:";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new System.Drawing.Point(123, 140);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new System.Drawing.Size(68, 13);
            returnDateLabel.TabIndex = 12;
            returnDateLabel.Text = "Return Date:";
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Location = new System.Drawing.Point(3, 140);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(83, 13);
            departureDateLabel.TabIndex = 4;
            departureDateLabel.Text = "Departure Date:";
            // 
            // commissionLabel
            // 
            commissionLabel.AutoSize = true;
            commissionLabel.Location = new System.Drawing.Point(123, 179);
            commissionLabel.Name = "commissionLabel";
            commissionLabel.Size = new System.Drawing.Size(65, 13);
            commissionLabel.TabIndex = 2;
            commissionLabel.Text = "Commission:";
            // 
            // basePriceLabel
            // 
            basePriceLabel.AutoSize = true;
            basePriceLabel.Location = new System.Drawing.Point(3, 179);
            basePriceLabel.Name = "basePriceLabel";
            basePriceLabel.Size = new System.Drawing.Size(61, 13);
            basePriceLabel.TabIndex = 0;
            basePriceLabel.Text = "Base Price:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(27, 63);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(38, 13);
            supNameLabel.TabIndex = 14;
            supNameLabel.Text = "Name:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(27, 33);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(21, 13);
            supplierIdLabel.TabIndex = 16;
            supplierIdLabel.Text = "ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Controls.Add(this.tabPackages);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(622, 485);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.txtSupplierId);
            this.tabSuppliers.Controls.Add(this.cmbSupName);
            this.tabSuppliers.Controls.Add(supNameLabel);
            this.tabSuppliers.Controls.Add(supplierIdLabel);
            this.tabSuppliers.Controls.Add(this.btnSaveSup);
            this.tabSuppliers.Controls.Add(this.label6);
            this.tabSuppliers.Controls.Add(this.lvProducts);
            this.tabSuppliers.Controls.Add(this.btnRemove);
            this.tabSuppliers.Controls.Add(this.btnAdd);
            this.tabSuppliers.Controls.Add(this.label5);
            this.tabSuppliers.Controls.Add(this.lvSuppliedProds);
            this.tabSuppliers.Controls.Add(this.label4);
            this.tabSuppliers.Controls.Add(this.btnDeleteSup);
            this.tabSuppliers.Controls.Add(this.btnNewSup);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(622, 485);
            this.tabSuppliers.TabIndex = 1;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            this.tabSuppliers.Enter += new System.EventHandler(this.tabSuppliersEnter);
            this.tabSuppliers.Leave += new System.EventHandler(this.tabSuppliersLeave);
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(71, 30);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.ReadOnly = true;
            this.txtSupplierId.Size = new System.Drawing.Size(103, 20);
            this.txtSupplierId.TabIndex = 18;
            // 
            // cmbSupName
            // 
            this.cmbSupName.DisplayMember = "SupName";
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(71, 60);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(222, 21);
            this.cmbSupName.TabIndex = 17;
            this.cmbSupName.ValueMember = "SupplierID";
            this.cmbSupName.SelectedIndexChanged += new System.EventHandler(this.cmbSupName_SelectedIndexChanged);
            // 
            // btnSaveSup
            // 
            this.btnSaveSup.Location = new System.Drawing.Point(33, 287);
            this.btnSaveSup.Name = "btnSaveSup";
            this.btnSaveSup.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSup.TabIndex = 13;
            this.btnSaveSup.Text = "Save";
            this.btnSaveSup.UseVisualStyleBackColor = true;
            this.btnSaveSup.Click += new System.EventHandler(this.btnSaveSup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Products list:";
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvProducts.Location = new System.Drawing.Point(366, 43);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(206, 267);
            this.lvProducts.TabIndex = 11;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ProductId";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product Name";
            this.columnHeader4.Width = 130;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(265, 213);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "=>";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "<=";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Supplied Products:";
            // 
            // lvSuppliedProds
            // 
            this.lvSuppliedProds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSuppliedProds.Location = new System.Drawing.Point(30, 124);
            this.lvSuppliedProds.Name = "lvSuppliedProds";
            this.lvSuppliedProds.Size = new System.Drawing.Size(204, 146);
            this.lvSuppliedProds.TabIndex = 7;
            this.lvSuppliedProds.UseCompatibleStateImageBehavior = false;
            this.lvSuppliedProds.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductId";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // btnDeleteSup
            // 
            this.btnDeleteSup.Location = new System.Drawing.Point(240, 28);
            this.btnDeleteSup.Name = "btnDeleteSup";
            this.btnDeleteSup.Size = new System.Drawing.Size(53, 23);
            this.btnDeleteSup.TabIndex = 3;
            this.btnDeleteSup.Text = "Delete";
            this.btnDeleteSup.UseVisualStyleBackColor = true;
            this.btnDeleteSup.Click += new System.EventHandler(this.btnDeleteSup_Click);
            // 
            // btnNewSup
            // 
            this.btnNewSup.Location = new System.Drawing.Point(184, 28);
            this.btnNewSup.Name = "btnNewSup";
            this.btnNewSup.Size = new System.Drawing.Size(50, 23);
            this.btnNewSup.TabIndex = 2;
            this.btnNewSup.Text = "New";
            this.btnNewSup.UseVisualStyleBackColor = true;
            this.btnNewSup.Click += new System.EventHandler(this.btnNewSup_Click);
            // 
            // tabPackages
            // 
            this.tabPackages.Controls.Add(this.btnPkgDelete);
            this.tabPackages.Controls.Add(this.dataGridView1);
            this.tabPackages.Controls.Add(this.lstPkgProductSuppliers);
            this.tabPackages.Controls.Add(this.btnDeleteProd_Supplier);
            this.tabPackages.Controls.Add(this.btnAddProduct_Supplier);
            this.tabPackages.Controls.Add(this.btnPkgSave);
            this.tabPackages.Controls.Add(this.lblPkgStatus);
            this.tabPackages.Controls.Add(this.btnAddPackage);
            this.tabPackages.Controls.Add(basePriceLabel);
            this.tabPackages.Controls.Add(this.txtPkgBasePrice);
            this.tabPackages.Controls.Add(commissionLabel);
            this.tabPackages.Controls.Add(this.txtPkgCommission);
            this.tabPackages.Controls.Add(departureDateLabel);
            this.tabPackages.Controls.Add(this.datPkgStart);
            this.tabPackages.Controls.Add(descriptionLabel);
            this.tabPackages.Controls.Add(this.txtPkgDesc);
            this.tabPackages.Controls.Add(label1);
            this.tabPackages.Controls.Add(iDLabel);
            this.tabPackages.Controls.Add(this.cmbPackageID);
            this.tabPackages.Controls.Add(returnDateLabel);
            this.tabPackages.Controls.Add(this.datPkgEnd);
            this.tabPackages.Location = new System.Drawing.Point(4, 22);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Size = new System.Drawing.Size(622, 485);
            this.tabPackages.TabIndex = 2;
            this.tabPackages.Text = "Packages";
            this.tabPackages.UseVisualStyleBackColor = true;
            this.tabPackages.Enter += new System.EventHandler(this.FillPackageComboBox);
            this.tabPackages.Leave += new System.EventHandler(this.tabPackages_Leave);
            // 
            // btnPkgDelete
            // 
            this.btnPkgDelete.Image = global::TravEx_DBMA.Properties.Resources.small_minus;
            this.btnPkgDelete.Location = new System.Drawing.Point(215, 26);
            this.btnPkgDelete.Name = "btnPkgDelete";
            this.btnPkgDelete.Size = new System.Drawing.Size(25, 21);
            this.btnPkgDelete.TabIndex = 21;
            this.btnPkgDelete.TabStop = false;
            this.btnPkgDelete.UseVisualStyleBackColor = true;
            this.btnPkgDelete.Click += new System.EventHandler(this.btnPkgDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // lstPkgProductSuppliers
            // 
            this.lstPkgProductSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSuppliers,
            this.colProducts});
            this.lstPkgProductSuppliers.FullRowSelect = true;
            this.lstPkgProductSuppliers.Location = new System.Drawing.Point(323, 26);
            this.lstPkgProductSuppliers.Name = "lstPkgProductSuppliers";
            this.lstPkgProductSuppliers.Size = new System.Drawing.Size(296, 189);
            this.lstPkgProductSuppliers.TabIndex = 18;
            this.lstPkgProductSuppliers.UseCompatibleStateImageBehavior = false;
            this.lstPkgProductSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // colSuppliers
            // 
            this.colSuppliers.Text = "Supplier";
            this.colSuppliers.Width = 142;
            // 
            // colProducts
            // 
            this.colProducts.Text = "Product";
            this.colProducts.Width = 150;
            // 
            // btnDeleteProd_Supplier
            // 
            this.btnDeleteProd_Supplier.Image = global::TravEx_DBMA.Properties.Resources.small_minus;
            this.btnDeleteProd_Supplier.Location = new System.Drawing.Point(544, 221);
            this.btnDeleteProd_Supplier.Name = "btnDeleteProd_Supplier";
            this.btnDeleteProd_Supplier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProd_Supplier.TabIndex = 17;
            this.btnDeleteProd_Supplier.TabStop = false;
            this.btnDeleteProd_Supplier.Text = "Delete";
            this.btnDeleteProd_Supplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProd_Supplier.UseVisualStyleBackColor = true;
            this.btnDeleteProd_Supplier.Click += new System.EventHandler(this.btnDeleteProd_Supplier_Click);
            // 
            // btnAddProduct_Supplier
            // 
            this.btnAddProduct_Supplier.Image = global::TravEx_DBMA.Properties.Resources.Small_Plus;
            this.btnAddProduct_Supplier.Location = new System.Drawing.Point(323, 221);
            this.btnAddProduct_Supplier.Name = "btnAddProduct_Supplier";
            this.btnAddProduct_Supplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct_Supplier.TabIndex = 70;
            this.btnAddProduct_Supplier.Text = "Add";
            this.btnAddProduct_Supplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct_Supplier.UseVisualStyleBackColor = true;
            this.btnAddProduct_Supplier.Click += new System.EventHandler(this.btnAddProduct_Supplier_Click);
            // 
            // btnPkgSave
            // 
            this.btnPkgSave.Enabled = false;
            this.btnPkgSave.Image = global::TravEx_DBMA.Properties.Resources.small_pencil;
            this.btnPkgSave.Location = new System.Drawing.Point(6, 221);
            this.btnPkgSave.Name = "btnPkgSave";
            this.btnPkgSave.Size = new System.Drawing.Size(75, 23);
            this.btnPkgSave.TabIndex = 68;
            this.btnPkgSave.Text = "Save";
            this.btnPkgSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPkgSave.UseVisualStyleBackColor = true;
            this.btnPkgSave.Click += new System.EventHandler(this.btnPkgSave_Click);
            // 
            // lblPkgStatus
            // 
            this.lblPkgStatus.AutoSize = true;
            this.lblPkgStatus.Location = new System.Drawing.Point(87, 226);
            this.lblPkgStatus.Name = "lblPkgStatus";
            this.lblPkgStatus.Size = new System.Drawing.Size(43, 13);
            this.lblPkgStatus.TabIndex = 16;
            this.lblPkgStatus.Text = "[----------]";
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Image = global::TravEx_DBMA.Properties.Resources.Small_Plus;
            this.btnAddPackage.Location = new System.Drawing.Point(184, 26);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(25, 21);
            this.btnAddPackage.TabIndex = 69;
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(6, 195);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(114, 20);
            this.txtPkgBasePrice.TabIndex = 66;
            this.txtPkgBasePrice.TextChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // txtPkgCommission
            // 
            this.txtPkgCommission.Location = new System.Drawing.Point(126, 195);
            this.txtPkgCommission.Name = "txtPkgCommission";
            this.txtPkgCommission.Size = new System.Drawing.Size(114, 20);
            this.txtPkgCommission.TabIndex = 67;
            this.txtPkgCommission.TextChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // datPkgStart
            // 
            this.datPkgStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPkgStart.Location = new System.Drawing.Point(6, 156);
            this.datPkgStart.Name = "datPkgStart";
            this.datPkgStart.Size = new System.Drawing.Size(114, 20);
            this.datPkgStart.TabIndex = 64;
            this.datPkgStart.ValueChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(6, 104);
            this.txtPkgDesc.MaxLength = 50;
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(234, 33);
            this.txtPkgDesc.TabIndex = 63;
            this.txtPkgDesc.TextChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // cmbPackageID
            // 
            this.cmbPackageID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPackageID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPackageID.DisplayMember = "Name";
            this.cmbPackageID.FormattingEnabled = true;
            this.cmbPackageID.Location = new System.Drawing.Point(6, 26);
            this.cmbPackageID.MaxLength = 50;
            this.cmbPackageID.Name = "cmbPackageID";
            this.cmbPackageID.Size = new System.Drawing.Size(170, 21);
            this.cmbPackageID.TabIndex = 60;
            this.cmbPackageID.ValueMember = "ID";
            this.cmbPackageID.SelectedValueChanged += new System.EventHandler(this.cmbPackageID_SelectedValueChanged);
            this.cmbPackageID.TextChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // datPkgEnd
            // 
            this.datPkgEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPkgEnd.Location = new System.Drawing.Point(126, 156);
            this.datPkgEnd.Name = "datPkgEnd";
            this.datPkgEnd.Size = new System.Drawing.Size(114, 20);
            this.datPkgEnd.TabIndex = 65;
            this.datPkgEnd.ValueChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Team4_Workshop4.Supplier);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Travel Experts";
            this.tabControl1.ResumeLayout(false);
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.ComboBox cmbPackageID;
        private System.Windows.Forms.ListView lstPkgProductSuppliers;
        private System.Windows.Forms.ColumnHeader colSuppliers;
        private System.Windows.Forms.ColumnHeader colProducts;
        private System.Windows.Forms.Button btnDeleteProd_Supplier;
        private System.Windows.Forms.Button btnAddProduct_Supplier;
        private System.Windows.Forms.Button btnPkgDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPkgSave;
        private System.Windows.Forms.Label lblPkgStatus;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgCommission;
        private System.Windows.Forms.DateTimePicker datPkgStart;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.DateTimePicker datPkgEnd;
        private System.Windows.Forms.Button btnNewSup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteSup;
        private System.Windows.Forms.Button btnSaveSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvSuppliedProds;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.ComboBox cmbSupName;
    }
}

