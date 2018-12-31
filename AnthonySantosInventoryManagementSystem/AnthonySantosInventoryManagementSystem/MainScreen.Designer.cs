namespace AnthonySantosInventoryManagementSystem
{
    partial class InventoryManagementSystemMainScreen
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
            this.MainScreenLabel = new System.Windows.Forms.Label();
            this.DataGridViewPart = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxParts = new System.Windows.Forms.GroupBox();
            this.ButtonDeletePart = new System.Windows.Forms.Button();
            this.ButtonModifyPart = new System.Windows.Forms.Button();
            this.ButtonAddPart = new System.Windows.Forms.Button();
            this.TextBoxSearchPart = new System.Windows.Forms.TextBox();
            this.ButtonSearchPart = new System.Windows.Forms.Button();
            this.LabelPart = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDeleteProduct = new System.Windows.Forms.Button();
            this.ButtonModifyProduct = new System.Windows.Forms.Button();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.TextBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.ButtonSearchProduct = new System.Windows.Forms.Button();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.DataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryLevelProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPart)).BeginInit();
            this.groupBoxParts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // MainScreenLabel
            // 
            this.MainScreenLabel.AutoSize = true;
            this.MainScreenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MainScreenLabel.Location = new System.Drawing.Point(26, 24);
            this.MainScreenLabel.Name = "MainScreenLabel";
            this.MainScreenLabel.Size = new System.Drawing.Size(358, 21);
            this.MainScreenLabel.TabIndex = 0;
            this.MainScreenLabel.Text = "Inventory Management System - Main Screen";
            // 
            // DataGridViewPart
            // 
            this.DataGridViewPart.AllowUserToAddRows = false;
            this.DataGridViewPart.AllowUserToDeleteRows = false;
            this.DataGridViewPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.name,
            this.inStock,
            this.pricePerUnitPart});
            this.DataGridViewPart.Location = new System.Drawing.Point(24, 92);
            this.DataGridViewPart.Name = "DataGridViewPart";
            this.DataGridViewPart.ReadOnly = true;
            this.DataGridViewPart.Size = new System.Drawing.Size(443, 222);
            this.DataGridViewPart.TabIndex = 1;
            this.DataGridViewPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPart_CellClick);
            this.DataGridViewPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPart_CellContentClick);
            // 
            // partID
            // 
            this.partID.DataPropertyName = "partID";
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Part Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // inStock
            // 
            this.inStock.DataPropertyName = "inStock";
            this.inStock.HeaderText = "Inventory Level";
            this.inStock.MinimumWidth = 50;
            this.inStock.Name = "inStock";
            this.inStock.ReadOnly = true;
            // 
            // pricePerUnitPart
            // 
            this.pricePerUnitPart.DataPropertyName = "price";
            this.pricePerUnitPart.HeaderText = "Price/Cost per Unit";
            this.pricePerUnitPart.Name = "pricePerUnitPart";
            this.pricePerUnitPart.ReadOnly = true;
            // 
            // groupBoxParts
            // 
            this.groupBoxParts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxParts.Controls.Add(this.ButtonDeletePart);
            this.groupBoxParts.Controls.Add(this.ButtonModifyPart);
            this.groupBoxParts.Controls.Add(this.ButtonAddPart);
            this.groupBoxParts.Controls.Add(this.TextBoxSearchPart);
            this.groupBoxParts.Controls.Add(this.ButtonSearchPart);
            this.groupBoxParts.Controls.Add(this.LabelPart);
            this.groupBoxParts.Controls.Add(this.DataGridViewPart);
            this.groupBoxParts.Location = new System.Drawing.Point(30, 91);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Size = new System.Drawing.Size(497, 408);
            this.groupBoxParts.TabIndex = 2;
            this.groupBoxParts.TabStop = false;
            // 
            // ButtonDeletePart
            // 
            this.ButtonDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDeletePart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeletePart.Location = new System.Drawing.Point(367, 340);
            this.ButtonDeletePart.Name = "ButtonDeletePart";
            this.ButtonDeletePart.Size = new System.Drawing.Size(100, 38);
            this.ButtonDeletePart.TabIndex = 7;
            this.ButtonDeletePart.Text = "Delete";
            this.ButtonDeletePart.UseVisualStyleBackColor = true;
            this.ButtonDeletePart.Click += new System.EventHandler(this.ButtonDeletePart_Click);
            // 
            // ButtonModifyPart
            // 
            this.ButtonModifyPart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonModifyPart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModifyPart.Location = new System.Drawing.Point(199, 340);
            this.ButtonModifyPart.Name = "ButtonModifyPart";
            this.ButtonModifyPart.Size = new System.Drawing.Size(100, 38);
            this.ButtonModifyPart.TabIndex = 6;
            this.ButtonModifyPart.Text = "Modify";
            this.ButtonModifyPart.UseVisualStyleBackColor = true;
            this.ButtonModifyPart.Click += new System.EventHandler(this.ButtonModifyPart_Click);
            // 
            // ButtonAddPart
            // 
            this.ButtonAddPart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonAddPart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddPart.Location = new System.Drawing.Point(24, 340);
            this.ButtonAddPart.Name = "ButtonAddPart";
            this.ButtonAddPart.Size = new System.Drawing.Size(100, 38);
            this.ButtonAddPart.TabIndex = 5;
            this.ButtonAddPart.Text = "Add";
            this.ButtonAddPart.UseVisualStyleBackColor = true;
            this.ButtonAddPart.Click += new System.EventHandler(this.ButtonAddPart_Click);
            // 
            // TextBoxSearchPart
            // 
            this.TextBoxSearchPart.Location = new System.Drawing.Point(280, 35);
            this.TextBoxSearchPart.Name = "TextBoxSearchPart";
            this.TextBoxSearchPart.Size = new System.Drawing.Size(162, 20);
            this.TextBoxSearchPart.TabIndex = 4;
            // 
            // ButtonSearchPart
            // 
            this.ButtonSearchPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearchPart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchPart.Location = new System.Drawing.Point(165, 33);
            this.ButtonSearchPart.Name = "ButtonSearchPart";
            this.ButtonSearchPart.Size = new System.Drawing.Size(109, 23);
            this.ButtonSearchPart.TabIndex = 3;
            this.ButtonSearchPart.Text = "Search Part Name";
            this.ButtonSearchPart.UseVisualStyleBackColor = true;
            this.ButtonSearchPart.Click += new System.EventHandler(this.ButtonSearchPart_Click);
            // 
            // LabelPart
            // 
            this.LabelPart.AutoSize = true;
            this.LabelPart.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPart.Location = new System.Drawing.Point(24, 32);
            this.LabelPart.Name = "LabelPart";
            this.LabelPart.Size = new System.Drawing.Size(73, 32);
            this.LabelPart.TabIndex = 2;
            this.LabelPart.Text = "Parts";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.ButtonDeleteProduct);
            this.groupBox1.Controls.Add(this.ButtonModifyProduct);
            this.groupBox1.Controls.Add(this.ButtonAddProduct);
            this.groupBox1.Controls.Add(this.TextBoxSearchProduct);
            this.groupBox1.Controls.Add(this.ButtonSearchProduct);
            this.groupBox1.Controls.Add(this.LabelProduct);
            this.groupBox1.Controls.Add(this.DataGridViewProduct);
            this.groupBox1.Location = new System.Drawing.Point(571, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 408);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ButtonDeleteProduct
            // 
            this.ButtonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteProduct.Location = new System.Drawing.Point(367, 340);
            this.ButtonDeleteProduct.Name = "ButtonDeleteProduct";
            this.ButtonDeleteProduct.Size = new System.Drawing.Size(100, 38);
            this.ButtonDeleteProduct.TabIndex = 7;
            this.ButtonDeleteProduct.Text = "Delete";
            this.ButtonDeleteProduct.UseVisualStyleBackColor = true;
            this.ButtonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProduct_Click);
            // 
            // ButtonModifyProduct
            // 
            this.ButtonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonModifyProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModifyProduct.Location = new System.Drawing.Point(199, 340);
            this.ButtonModifyProduct.Name = "ButtonModifyProduct";
            this.ButtonModifyProduct.Size = new System.Drawing.Size(100, 38);
            this.ButtonModifyProduct.TabIndex = 6;
            this.ButtonModifyProduct.Text = "Modify";
            this.ButtonModifyProduct.UseVisualStyleBackColor = true;
            this.ButtonModifyProduct.Click += new System.EventHandler(this.ButtonModifyProduct_Click);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(24, 340);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(100, 38);
            this.ButtonAddProduct.TabIndex = 5;
            this.ButtonAddProduct.Text = "Add";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // TextBoxSearchProduct
            // 
            this.TextBoxSearchProduct.Location = new System.Drawing.Point(280, 35);
            this.TextBoxSearchProduct.Name = "TextBoxSearchProduct";
            this.TextBoxSearchProduct.Size = new System.Drawing.Size(162, 20);
            this.TextBoxSearchProduct.TabIndex = 4;
            // 
            // ButtonSearchProduct
            // 
            this.ButtonSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearchProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchProduct.Location = new System.Drawing.Point(147, 33);
            this.ButtonSearchProduct.Name = "ButtonSearchProduct";
            this.ButtonSearchProduct.Size = new System.Drawing.Size(127, 23);
            this.ButtonSearchProduct.TabIndex = 3;
            this.ButtonSearchProduct.Text = "Search Product Name";
            this.ButtonSearchProduct.UseVisualStyleBackColor = true;
            this.ButtonSearchProduct.Click += new System.EventHandler(this.ButtonSearchProduct_Click);
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProduct.Location = new System.Drawing.Point(24, 32);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(117, 32);
            this.LabelProduct.TabIndex = 2;
            this.LabelProduct.Text = "Products";
            // 
            // DataGridViewProduct
            // 
            this.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.inventoryLevelProduct,
            this.pricePerUnitProduct});
            this.DataGridViewProduct.Location = new System.Drawing.Point(24, 92);
            this.DataGridViewProduct.Name = "DataGridViewProduct";
            this.DataGridViewProduct.Size = new System.Drawing.Size(443, 222);
            this.DataGridViewProduct.TabIndex = 1;
            this.DataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProduct_CellContentClick);
            this.DataGridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProduct_CellContentClick);
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.DataPropertyName = "name";
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            // 
            // inventoryLevelProduct
            // 
            this.inventoryLevelProduct.DataPropertyName = "inStock";
            this.inventoryLevelProduct.HeaderText = "Inventory Level";
            this.inventoryLevelProduct.MinimumWidth = 50;
            this.inventoryLevelProduct.Name = "inventoryLevelProduct";
            // 
            // pricePerUnitProduct
            // 
            this.pricePerUnitProduct.DataPropertyName = "price";
            this.pricePerUnitProduct.HeaderText = "Price per Unit";
            this.pricePerUnitProduct.Name = "pricePerUnitProduct";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(929, 521);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(109, 44);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click_1);
            // 
            // InventoryManagementSystemMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 598);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxParts);
            this.Controls.Add(this.MainScreenLabel);
            this.Name = "InventoryManagementSystemMainScreen";
            this.Text = "Inventory Management System Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPart)).EndInit();
            this.groupBoxParts.ResumeLayout(false);
            this.groupBoxParts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainScreenLabel;
        private System.Windows.Forms.DataGridView DataGridViewPart;
        private System.Windows.Forms.GroupBox groupBoxParts;
        private System.Windows.Forms.Button ButtonDeletePart;
        private System.Windows.Forms.Button ButtonModifyPart;
        private System.Windows.Forms.Button ButtonAddPart;
        private System.Windows.Forms.TextBox TextBoxSearchPart;
        private System.Windows.Forms.Button ButtonSearchPart;
        private System.Windows.Forms.Label LabelPart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonDeleteProduct;
        private System.Windows.Forms.Button ButtonModifyProduct;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.TextBox TextBoxSearchProduct;
        private System.Windows.Forms.Button ButtonSearchProduct;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.DataGridView DataGridViewProduct;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryLevelProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitProduct;
    }
}

