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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvSuppliers = new System.Windows.Forms.ListView();
            this.prod_colSuppliersID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prod_colSuppliersname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProductSupplier = new System.Windows.Forms.ListView();
            this.prod_colProdSupplierSupID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prod_colProdSupplierSupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prod_colProdSupplierProdID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prod_colProdSupplierPSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvProProducts = new System.Windows.Forms.ListView();
            this.prod_colProductsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prod_colProductsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModify = new System.Windows.Forms.Button();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstPkgProductSuppliers = new System.Windows.Forms.ListView();
            this.colSuppliers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProducts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteProd_Supplier = new System.Windows.Forms.Button();
            this.btnAddProduct_Supplier = new System.Windows.Forms.Button();
            this.btnPkgSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgCommission = new System.Windows.Forms.TextBox();
            this.datPkgStart = new System.Windows.Forms.DateTimePicker();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.cmbPackageID = new System.Windows.Forms.ComboBox();
            this.datPkgEnd = new System.Windows.Forms.DateTimePicker();
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            commissionLabel = new System.Windows.Forms.Label();
            basePriceLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 50);
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
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Gainsboro;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(38, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 21);
            label2.TabIndex = 10;
            label2.Text = "Prod ID:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodNameLabel
            // 
            prodNameLabel.BackColor = System.Drawing.Color.Gainsboro;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(38, 160);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(99, 20);
            prodNameLabel.TabIndex = 11;
            prodNameLabel.Text = "Prod Name:";
            prodNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Gainsboro;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(484, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 23);
            label3.TabIndex = 11;
            label3.Text = "Supplier List";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Gainsboro;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(484, 284);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(138, 22);
            label4.TabIndex = 11;
            label4.Text = "Product Suppliers:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Gainsboro;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(732, 16);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(126, 23);
            label5.TabIndex = 11;
            label5.Text = "Product List";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Controls.Add(this.tabPackages);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.BackColor = System.Drawing.Color.RosyBrown;
            this.tabProducts.Controls.Add(this.btnClear);
            this.tabProducts.Controls.Add(this.btnDelete);
            this.tabProducts.Controls.Add(this.btnAdd);
            this.tabProducts.Controls.Add(this.lvSuppliers);
            this.tabProducts.Controls.Add(this.lvProductSupplier);
            this.tabProducts.Controls.Add(this.txtProdName);
            this.tabProducts.Controls.Add(this.btnExit);
            this.tabProducts.Controls.Add(this.lvProProducts);
            this.tabProducts.Controls.Add(this.btnModify);
            this.tabProducts.Controls.Add(label2);
            this.tabProducts.Controls.Add(label4);
            this.tabProducts.Controls.Add(label5);
            this.tabProducts.Controls.Add(label3);
            this.tabProducts.Controls.Add(prodNameLabel);
            this.tabProducts.Controls.Add(this.productIdComboBox);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(973, 485);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Products";
            this.tabProducts.Enter += new System.EventHandler(this.tabProducts_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(343, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(242, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(41, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvSuppliers
            // 
            this.lvSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prod_colSuppliersID,
            this.prod_colSuppliersname});
            this.lvSuppliers.Location = new System.Drawing.Point(487, 42);
            this.lvSuppliers.Name = "lvSuppliers";
            this.lvSuppliers.Size = new System.Drawing.Size(190, 216);
            this.lvSuppliers.TabIndex = 19;
            this.lvSuppliers.UseCompatibleStateImageBehavior = false;
            this.lvSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // prod_colSuppliersID
            // 
            this.prod_colSuppliersID.Text = "Supplier ID";
            this.prod_colSuppliersID.Width = 70;
            // 
            // prod_colSuppliersname
            // 
            this.prod_colSuppliersname.Text = "Supplier Name";
            this.prod_colSuppliersname.Width = 110;
            // 
            // lvProductSupplier
            // 
            this.lvProductSupplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prod_colProdSupplierSupID,
            this.prod_colProdSupplierSupName,
            this.prod_colProdSupplierProdID,
            this.prod_colProdSupplierPSID});
            this.lvProductSupplier.Location = new System.Drawing.Point(487, 309);
            this.lvProductSupplier.Name = "lvProductSupplier";
            this.lvProductSupplier.Size = new System.Drawing.Size(454, 135);
            this.lvProductSupplier.TabIndex = 18;
            this.lvProductSupplier.UseCompatibleStateImageBehavior = false;
            this.lvProductSupplier.View = System.Windows.Forms.View.Details;
            // 
            // prod_colProdSupplierSupID
            // 
            this.prod_colProdSupplierSupID.Text = "Supplier ID";
            this.prod_colProdSupplierSupID.Width = 70;
            // 
            // prod_colProdSupplierSupName
            // 
            this.prod_colProdSupplierSupName.Text = "Supplier Name";
            this.prod_colProdSupplierSupName.Width = 180;
            // 
            // prod_colProdSupplierProdID
            // 
            this.prod_colProdSupplierProdID.Text = "Product ID";
            this.prod_colProdSupplierProdID.Width = 70;
            // 
            // prod_colProdSupplierPSID
            // 
            this.prod_colProdSupplierPSID.Text = "ProductSupplierId";
            this.prod_colProdSupplierPSID.Width = 80;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(157, 160);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(121, 20);
            this.txtProdName.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(41, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvProProducts
            // 
            this.lvProProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prod_colProductsID,
            this.prod_colProductsName});
            this.lvProProducts.Location = new System.Drawing.Point(735, 42);
            this.lvProProducts.Name = "lvProProducts";
            this.lvProProducts.Size = new System.Drawing.Size(169, 217);
            this.lvProProducts.TabIndex = 15;
            this.lvProProducts.UseCompatibleStateImageBehavior = false;
            this.lvProProducts.View = System.Windows.Forms.View.Details;
            // 
            // prod_colProductsID
            // 
            this.prod_colProductsID.Text = "Product ID";
            this.prod_colProductsID.Width = 81;
            // 
            // prod_colProductsName
            // 
            this.prod_colProductsName.Text = "Product Name";
            this.prod_colProductsName.Width = 112;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(136, 295);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 24);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductId", true));
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(157, 113);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.productIdComboBox.TabIndex = 13;
            this.productIdComboBox.SelectedIndexChanged += new System.EventHandler(this.productIdComboBox_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertsPackages.Product);
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(973, 485);
            this.tabSuppliers.TabIndex = 1;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // tabPackages
            // 
            this.tabPackages.Controls.Add(this.button1);
            this.tabPackages.Controls.Add(this.textBox1);
            this.tabPackages.Controls.Add(this.dataGridView1);
            this.tabPackages.Controls.Add(this.lstPkgProductSuppliers);
            this.tabPackages.Controls.Add(this.btnDeleteProd_Supplier);
            this.tabPackages.Controls.Add(this.btnAddProduct_Supplier);
            this.tabPackages.Controls.Add(this.btnPkgSave);
            this.tabPackages.Controls.Add(this.lblStatus);
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
            this.tabPackages.Size = new System.Drawing.Size(973, 485);
            this.tabPackages.TabIndex = 2;
            this.tabPackages.Text = "Packages";
            this.tabPackages.UseVisualStyleBackColor = true;
            this.tabPackages.Enter += new System.EventHandler(this.FillPackageComboBox);
            this.tabPackages.Leave += new System.EventHandler(this.tabPackages_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // lstPkgProductSuppliers
            // 
            this.lstPkgProductSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSuppliers,
            this.colProducts});
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
            this.colSuppliers.Width = 164;
            // 
            // colProducts
            // 
            this.colProducts.Text = "Product";
            this.colProducts.Width = 150;
            // 
            // btnDeleteProd_Supplier
            // 
            this.btnDeleteProd_Supplier.Location = new System.Drawing.Point(544, 221);
            this.btnDeleteProd_Supplier.Name = "btnDeleteProd_Supplier";
            this.btnDeleteProd_Supplier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProd_Supplier.TabIndex = 17;
            this.btnDeleteProd_Supplier.Text = "X Delete";
            this.btnDeleteProd_Supplier.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct_Supplier
            // 
            this.btnAddProduct_Supplier.Location = new System.Drawing.Point(323, 221);
            this.btnAddProduct_Supplier.Name = "btnAddProduct_Supplier";
            this.btnAddProduct_Supplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct_Supplier.TabIndex = 17;
            this.btnAddProduct_Supplier.Text = "+ Add";
            this.btnAddProduct_Supplier.UseVisualStyleBackColor = true;
            // 
            // btnPkgSave
            // 
            this.btnPkgSave.Enabled = false;
            this.btnPkgSave.Location = new System.Drawing.Point(6, 221);
            this.btnPkgSave.Name = "btnPkgSave";
            this.btnPkgSave.Size = new System.Drawing.Size(75, 23);
            this.btnPkgSave.TabIndex = 17;
            this.btnPkgSave.Text = "Save";
            this.btnPkgSave.UseVisualStyleBackColor = true;
            this.btnPkgSave.Click += new System.EventHandler(this.btnPkgSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(87, 226);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "[----------]";
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(246, 26);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(71, 21);
            this.btnAddPackage.TabIndex = 14;
            this.btnAddPackage.Text = "New";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(6, 195);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(114, 20);
            this.txtPkgBasePrice.TabIndex = 1;
            this.txtPkgBasePrice.TextChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // txtPkgCommission
            // 
            this.txtPkgCommission.Location = new System.Drawing.Point(126, 195);
            this.txtPkgCommission.Name = "txtPkgCommission";
            this.txtPkgCommission.Size = new System.Drawing.Size(114, 20);
            this.txtPkgCommission.TabIndex = 3;
            this.txtPkgCommission.TextChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // datPkgStart
            // 
            this.datPkgStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPkgStart.Location = new System.Drawing.Point(6, 156);
            this.datPkgStart.Name = "datPkgStart";
            this.datPkgStart.Size = new System.Drawing.Size(114, 20);
            this.datPkgStart.TabIndex = 5;
            this.datPkgStart.ValueChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(6, 66);
            this.txtPkgDesc.MaxLength = 50;
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(234, 33);
            this.txtPkgDesc.TabIndex = 7;
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
            this.cmbPackageID.TabIndex = 9;
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
            this.datPkgEnd.TabIndex = 13;
            this.datPkgEnd.ValueChanged += new System.EventHandler(this.OnPackageDataModified);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1026, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Travel Experts";
            this.tabControl1.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPkgSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgCommission;
        private System.Windows.Forms.DateTimePicker datPkgStart;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.DateTimePicker datPkgEnd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lvProProducts;
        private System.Windows.Forms.ColumnHeader prod_colProductsID;
        private System.Windows.Forms.ColumnHeader prod_colProductsName;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.ListView lvProductSupplier;
        private System.Windows.Forms.ColumnHeader prod_colProdSupplierSupID;
        private System.Windows.Forms.ColumnHeader prod_colProdSupplierSupName;
        private System.Windows.Forms.ColumnHeader prod_colProdSupplierProdID;
        private System.Windows.Forms.ListView lvSuppliers;
        private System.Windows.Forms.ColumnHeader prod_colSuppliersID;
        private System.Windows.Forms.ColumnHeader prod_colSuppliersname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader prod_colProdSupplierPSID;
    }
}

