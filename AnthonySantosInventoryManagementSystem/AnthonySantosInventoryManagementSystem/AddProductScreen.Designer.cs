namespace AnthonySantosInventoryManagementSystem
{
    partial class AddProductScreen
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
            this.LabelAddProduct = new System.Windows.Forms.Label();
            this.LabelProductMin = new System.Windows.Forms.Label();
            this.TextBoxProductMin = new System.Windows.Forms.TextBox();
            this.LabelProductMax = new System.Windows.Forms.Label();
            this.LabelProductPriceCost = new System.Windows.Forms.Label();
            this.LabelProductInv = new System.Windows.Forms.Label();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelProductID = new System.Windows.Forms.Label();
            this.TextBoxProductMax = new System.Windows.Forms.TextBox();
            this.TextBoxProductPriceCost = new System.Windows.Forms.TextBox();
            this.TextBoxProductInv = new System.Windows.Forms.TextBox();
            this.TextBoxProductName = new System.Windows.Forms.TextBox();
            this.TextBoxProductID = new System.Windows.Forms.TextBox();
            this.TextBoxSearchPart = new System.Windows.Forms.TextBox();
            this.ButtonSearchPart = new System.Windows.Forms.Button();
            this.DataGridViewPartsAvailable = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddPart = new System.Windows.Forms.Button();
            this.DataGridViewPartsInProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonDeletePart = new System.Windows.Forms.Button();
            this.ButtonProductCancel = new System.Windows.Forms.Button();
            this.ButtonProductSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPartsAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPartsInProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAddProduct
            // 
            this.LabelAddProduct.AutoSize = true;
            this.LabelAddProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddProduct.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelAddProduct.Location = new System.Drawing.Point(12, 9);
            this.LabelAddProduct.Name = "LabelAddProduct";
            this.LabelAddProduct.Size = new System.Drawing.Size(138, 30);
            this.LabelAddProduct.TabIndex = 1;
            this.LabelAddProduct.Text = "Add Product";
            // 
            // LabelProductMin
            // 
            this.LabelProductMin.AutoSize = true;
            this.LabelProductMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductMin.Location = new System.Drawing.Point(211, 273);
            this.LabelProductMin.Name = "LabelProductMin";
            this.LabelProductMin.Size = new System.Drawing.Size(38, 21);
            this.LabelProductMin.TabIndex = 28;
            this.LabelProductMin.Text = "Min";
            // 
            // TextBoxProductMin
            // 
            this.TextBoxProductMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProductMin.Location = new System.Drawing.Point(260, 273);
            this.TextBoxProductMin.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxProductMin.MinimumSize = new System.Drawing.Size(75, 30);
            this.TextBoxProductMin.Name = "TextBoxProductMin";
            this.TextBoxProductMin.Size = new System.Drawing.Size(75, 29);
            this.TextBoxProductMin.TabIndex = 27;
            this.TextBoxProductMin.Text = "Min";
            this.TextBoxProductMin.UseWaitCursor = true;
            this.TextBoxProductMin.TextChanged += new System.EventHandler(this.TextBoxProductMin_TextChanged);
            // 
            // LabelProductMax
            // 
            this.LabelProductMax.AutoSize = true;
            this.LabelProductMax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductMax.Location = new System.Drawing.Point(48, 273);
            this.LabelProductMax.Name = "LabelProductMax";
            this.LabelProductMax.Size = new System.Drawing.Size(41, 21);
            this.LabelProductMax.TabIndex = 26;
            this.LabelProductMax.Text = "Max";
            // 
            // LabelProductPriceCost
            // 
            this.LabelProductPriceCost.AutoSize = true;
            this.LabelProductPriceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductPriceCost.Location = new System.Drawing.Point(3, 233);
            this.LabelProductPriceCost.Name = "LabelProductPriceCost";
            this.LabelProductPriceCost.Size = new System.Drawing.Size(86, 21);
            this.LabelProductPriceCost.TabIndex = 25;
            this.LabelProductPriceCost.Text = "Price/Cost";
            // 
            // LabelProductInv
            // 
            this.LabelProductInv.AutoSize = true;
            this.LabelProductInv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductInv.Location = new System.Drawing.Point(57, 193);
            this.LabelProductInv.Name = "LabelProductInv";
            this.LabelProductInv.Size = new System.Drawing.Size(32, 21);
            this.LabelProductInv.TabIndex = 24;
            this.LabelProductInv.Text = "Inv";
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductName.Location = new System.Drawing.Point(36, 153);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(53, 21);
            this.LabelProductName.TabIndex = 23;
            this.LabelProductName.Text = "Name";
            // 
            // LabelProductID
            // 
            this.LabelProductID.AutoSize = true;
            this.LabelProductID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductID.Location = new System.Drawing.Point(63, 110);
            this.LabelProductID.Name = "LabelProductID";
            this.LabelProductID.Size = new System.Drawing.Size(26, 21);
            this.LabelProductID.TabIndex = 22;
            this.LabelProductID.Text = "ID";
            // 
            // TextBoxProductMax
            // 
            this.TextBoxProductMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProductMax.Location = new System.Drawing.Point(97, 273);
            this.TextBoxProductMax.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxProductMax.MinimumSize = new System.Drawing.Size(75, 30);
            this.TextBoxProductMax.Name = "TextBoxProductMax";
            this.TextBoxProductMax.Size = new System.Drawing.Size(75, 29);
            this.TextBoxProductMax.TabIndex = 21;
            this.TextBoxProductMax.Text = "Max";
            this.TextBoxProductMax.UseWaitCursor = true;
            this.TextBoxProductMax.TextChanged += new System.EventHandler(this.TextBoxProductMax_TextChanged);
            // 
            // TextBoxProductPriceCost
            // 
            this.TextBoxProductPriceCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProductPriceCost.Location = new System.Drawing.Point(97, 233);
            this.TextBoxProductPriceCost.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxProductPriceCost.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxProductPriceCost.Name = "TextBoxProductPriceCost";
            this.TextBoxProductPriceCost.Size = new System.Drawing.Size(150, 29);
            this.TextBoxProductPriceCost.TabIndex = 20;
            this.TextBoxProductPriceCost.Text = "Price/Cost";
            this.TextBoxProductPriceCost.UseWaitCursor = true;
            this.TextBoxProductPriceCost.TextChanged += new System.EventHandler(this.TextBoxProductPriceCost_TextChanged);
            // 
            // TextBoxProductInv
            // 
            this.TextBoxProductInv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProductInv.Location = new System.Drawing.Point(97, 193);
            this.TextBoxProductInv.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxProductInv.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxProductInv.Name = "TextBoxProductInv";
            this.TextBoxProductInv.Size = new System.Drawing.Size(150, 29);
            this.TextBoxProductInv.TabIndex = 19;
            this.TextBoxProductInv.Text = "Inv";
            this.TextBoxProductInv.UseWaitCursor = true;
            this.TextBoxProductInv.TextChanged += new System.EventHandler(this.TextBoxProductInv_TextChanged);
            // 
            // TextBoxProductName
            // 
            this.TextBoxProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProductName.Location = new System.Drawing.Point(97, 153);
            this.TextBoxProductName.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxProductName.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxProductName.Name = "TextBoxProductName";
            this.TextBoxProductName.Size = new System.Drawing.Size(150, 29);
            this.TextBoxProductName.TabIndex = 18;
            this.TextBoxProductName.Text = "Product Name";
            this.TextBoxProductName.UseWaitCursor = true;
            this.TextBoxProductName.TextChanged += new System.EventHandler(this.TextBoxProductName_TextChanged);
            // 
            // TextBoxProductID
            // 
            this.TextBoxProductID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextBoxProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProductID.Location = new System.Drawing.Point(97, 113);
            this.TextBoxProductID.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxProductID.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxProductID.Name = "TextBoxProductID";
            this.TextBoxProductID.Size = new System.Drawing.Size(150, 29);
            this.TextBoxProductID.TabIndex = 17;
            this.TextBoxProductID.Text = "Product ID";
            this.TextBoxProductID.UseWaitCursor = true;
            this.TextBoxProductID.TextChanged += new System.EventHandler(this.TextBoxProductID_TextChanged);
            // 
            // TextBoxSearchPart
            // 
            this.TextBoxSearchPart.Location = new System.Drawing.Point(541, 19);
            this.TextBoxSearchPart.Name = "TextBoxSearchPart";
            this.TextBoxSearchPart.Size = new System.Drawing.Size(162, 20);
            this.TextBoxSearchPart.TabIndex = 30;
            this.TextBoxSearchPart.TextChanged += new System.EventHandler(this.TextBoxSearchPart_TextChanged);
            // 
            // ButtonSearchPart
            // 
            this.ButtonSearchPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearchPart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchPart.Location = new System.Drawing.Point(393, 17);
            this.ButtonSearchPart.Name = "ButtonSearchPart";
            this.ButtonSearchPart.Size = new System.Drawing.Size(142, 23);
            this.ButtonSearchPart.TabIndex = 29;
            this.ButtonSearchPart.Text = "Search Part Name";
            this.ButtonSearchPart.UseVisualStyleBackColor = true;
            this.ButtonSearchPart.Click += new System.EventHandler(this.ButtonSearchPart_Click);
            // 
            // DataGridViewPartsAvailable
            // 
            this.DataGridViewPartsAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPartsAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.name,
            this.inStock,
            this.pricePerUnitPart});
            this.DataGridViewPartsAvailable.Location = new System.Drawing.Point(357, 73);
            this.DataGridViewPartsAvailable.Name = "DataGridViewPartsAvailable";
            this.DataGridViewPartsAvailable.Size = new System.Drawing.Size(443, 137);
            this.DataGridViewPartsAvailable.TabIndex = 31;
            this.DataGridViewPartsAvailable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPartsAvailable_CellContentClick);
            this.DataGridViewPartsAvailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPartsAvailable_CellContentClick);
            // 
            // partID
            // 
            this.partID.DataPropertyName = "partID";
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Part Name";
            this.name.Name = "name";
            // 
            // inStock
            // 
            this.inStock.DataPropertyName = "inStock";
            this.inStock.HeaderText = "Inventory Level";
            this.inStock.MinimumWidth = 50;
            this.inStock.Name = "inStock";
            // 
            // pricePerUnitPart
            // 
            this.pricePerUnitPart.DataPropertyName = "price";
            this.pricePerUnitPart.HeaderText = "Price/Cost per Unit";
            this.pricePerUnitPart.Name = "pricePerUnitPart";
            // 
            // ButtonAddPart
            // 
            this.ButtonAddPart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonAddPart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddPart.Location = new System.Drawing.Point(700, 216);
            this.ButtonAddPart.Name = "ButtonAddPart";
            this.ButtonAddPart.Size = new System.Drawing.Size(100, 38);
            this.ButtonAddPart.TabIndex = 32;
            this.ButtonAddPart.Text = "Add";
            this.ButtonAddPart.UseVisualStyleBackColor = true;
            this.ButtonAddPart.Click += new System.EventHandler(this.ButtonAddPart_Click);
            // 
            // DataGridViewPartsInProduct
            // 
            this.DataGridViewPartsInProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPartsInProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataGridViewPartsInProduct.Location = new System.Drawing.Point(357, 290);
            this.DataGridViewPartsInProduct.Name = "DataGridViewPartsInProduct";
            this.DataGridViewPartsInProduct.Size = new System.Drawing.Size(443, 139);
            this.DataGridViewPartsInProduct.TabIndex = 33;
            this.DataGridViewPartsInProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPartsInProduct_CellContentClick);
            this.DataGridViewPartsInProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPartsInProduct_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "partID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "inStock";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price/Cost per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ButtonDeletePart
            // 
            this.ButtonDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDeletePart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeletePart.Location = new System.Drawing.Point(700, 435);
            this.ButtonDeletePart.Name = "ButtonDeletePart";
            this.ButtonDeletePart.Size = new System.Drawing.Size(100, 38);
            this.ButtonDeletePart.TabIndex = 34;
            this.ButtonDeletePart.Text = "Delete";
            this.ButtonDeletePart.UseVisualStyleBackColor = true;
            this.ButtonDeletePart.Click += new System.EventHandler(this.ButtonDeletePart_Click);
            // 
            // ButtonProductCancel
            // 
            this.ButtonProductCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonProductCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonProductCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProductCancel.Location = new System.Drawing.Point(576, 485);
            this.ButtonProductCancel.Name = "ButtonProductCancel";
            this.ButtonProductCancel.Size = new System.Drawing.Size(75, 33);
            this.ButtonProductCancel.TabIndex = 36;
            this.ButtonProductCancel.Text = "Cancel";
            this.ButtonProductCancel.UseVisualStyleBackColor = false;
            this.ButtonProductCancel.Click += new System.EventHandler(this.ButtonProductCancel_Click);
            // 
            // ButtonProductSave
            // 
            this.ButtonProductSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonProductSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonProductSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProductSave.Location = new System.Drawing.Point(460, 485);
            this.ButtonProductSave.Name = "ButtonProductSave";
            this.ButtonProductSave.Size = new System.Drawing.Size(75, 33);
            this.ButtonProductSave.TabIndex = 35;
            this.ButtonProductSave.Text = "Save";
            this.ButtonProductSave.UseVisualStyleBackColor = false;
            this.ButtonProductSave.Click += new System.EventHandler(this.ButtonProductSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Available Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Associated Parts";
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonProductCancel);
            this.Controls.Add(this.ButtonProductSave);
            this.Controls.Add(this.ButtonDeletePart);
            this.Controls.Add(this.DataGridViewPartsInProduct);
            this.Controls.Add(this.ButtonAddPart);
            this.Controls.Add(this.DataGridViewPartsAvailable);
            this.Controls.Add(this.TextBoxSearchPart);
            this.Controls.Add(this.ButtonSearchPart);
            this.Controls.Add(this.LabelProductMin);
            this.Controls.Add(this.TextBoxProductMin);
            this.Controls.Add(this.LabelProductMax);
            this.Controls.Add(this.LabelProductPriceCost);
            this.Controls.Add(this.LabelProductInv);
            this.Controls.Add(this.LabelProductName);
            this.Controls.Add(this.LabelProductID);
            this.Controls.Add(this.TextBoxProductMax);
            this.Controls.Add(this.TextBoxProductPriceCost);
            this.Controls.Add(this.TextBoxProductInv);
            this.Controls.Add(this.TextBoxProductName);
            this.Controls.Add(this.TextBoxProductID);
            this.Controls.Add(this.LabelAddProduct);
            this.Name = "AddProductScreen";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPartsAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPartsInProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddProduct;
        private System.Windows.Forms.Label LabelProductMin;
        private System.Windows.Forms.TextBox TextBoxProductMin;
        private System.Windows.Forms.Label LabelProductMax;
        private System.Windows.Forms.Label LabelProductPriceCost;
        private System.Windows.Forms.Label LabelProductInv;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label LabelProductID;
        private System.Windows.Forms.TextBox TextBoxProductMax;
        private System.Windows.Forms.TextBox TextBoxProductPriceCost;
        private System.Windows.Forms.TextBox TextBoxProductInv;
        private System.Windows.Forms.TextBox TextBoxProductName;
        private System.Windows.Forms.TextBox TextBoxProductID;
        private System.Windows.Forms.TextBox TextBoxSearchPart;
        private System.Windows.Forms.Button ButtonSearchPart;
        private System.Windows.Forms.DataGridView DataGridViewPartsAvailable;
        private System.Windows.Forms.Button ButtonAddPart;
        private System.Windows.Forms.DataGridView DataGridViewPartsInProduct;
        private System.Windows.Forms.Button ButtonDeletePart;
        private System.Windows.Forms.Button ButtonProductCancel;
        private System.Windows.Forms.Button ButtonProductSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}