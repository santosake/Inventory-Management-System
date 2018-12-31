namespace AnthonySantosInventoryManagementSystem
{
    partial class AddPartScreen
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
            System.Windows.Forms.RadioButton RadioButtonOutsourced;
            this.LabelAddPart = new System.Windows.Forms.Label();
            this.RadioButtonInHouse = new System.Windows.Forms.RadioButton();
            this.TextBoxPartID = new System.Windows.Forms.TextBox();
            this.TextBoxPartName = new System.Windows.Forms.TextBox();
            this.TextBoxPartInv = new System.Windows.Forms.TextBox();
            this.TextBoxPartPriceCost = new System.Windows.Forms.TextBox();
            this.TextBoxPartMax = new System.Windows.Forms.TextBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelInv = new System.Windows.Forms.Label();
            this.LabelPriceCost = new System.Windows.Forms.Label();
            this.LabelMax = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.TextBoxPartMin = new System.Windows.Forms.TextBox();
            this.LabelMin = new System.Windows.Forms.Label();
            this.ButtonPartSave = new System.Windows.Forms.Button();
            this.ButtonPartCancel = new System.Windows.Forms.Button();
            RadioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RadioButtonOutsourced
            // 
            RadioButtonOutsourced.AutoSize = true;
            RadioButtonOutsourced.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RadioButtonOutsourced.Location = new System.Drawing.Point(302, 25);
            RadioButtonOutsourced.Name = "RadioButtonOutsourced";
            RadioButtonOutsourced.Size = new System.Drawing.Size(114, 25);
            RadioButtonOutsourced.TabIndex = 2;
            RadioButtonOutsourced.Text = "Outsourced";
            RadioButtonOutsourced.UseVisualStyleBackColor = true;
            RadioButtonOutsourced.CheckedChanged += new System.EventHandler(this.RadioButtonOutsourced_CheckedChanged);
            // 
            // LabelAddPart
            // 
            this.LabelAddPart.AutoSize = true;
            this.LabelAddPart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddPart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelAddPart.Location = new System.Drawing.Point(13, 13);
            this.LabelAddPart.Name = "LabelAddPart";
            this.LabelAddPart.Size = new System.Drawing.Size(100, 30);
            this.LabelAddPart.TabIndex = 0;
            this.LabelAddPart.Text = "Add Part";
            // 
            // RadioButtonInHouse
            // 
            this.RadioButtonInHouse.AutoSize = true;
            this.RadioButtonInHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonInHouse.Location = new System.Drawing.Point(178, 25);
            this.RadioButtonInHouse.Name = "RadioButtonInHouse";
            this.RadioButtonInHouse.Size = new System.Drawing.Size(95, 25);
            this.RadioButtonInHouse.TabIndex = 1;
            this.RadioButtonInHouse.Text = "In-House";
            this.RadioButtonInHouse.UseVisualStyleBackColor = true;
            this.RadioButtonInHouse.CheckedChanged += new System.EventHandler(this.RadioButtonInHouse_CheckedChanged);
            // 
            // TextBoxPartID
            // 
            this.TextBoxPartID.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPartID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartID.Location = new System.Drawing.Point(178, 101);
            this.TextBoxPartID.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartID.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxPartID.Name = "TextBoxPartID";
            this.TextBoxPartID.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartID.TabIndex = 3;
            this.TextBoxPartID.UseWaitCursor = true;
            this.TextBoxPartID.TextChanged += new System.EventHandler(this.TextBoxPartID_TextChanged);
            // 
            // TextBoxPartName
            // 
            this.TextBoxPartName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartName.Location = new System.Drawing.Point(178, 141);
            this.TextBoxPartName.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartName.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxPartName.Name = "TextBoxPartName";
            this.TextBoxPartName.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartName.TabIndex = 4;
            this.TextBoxPartName.UseWaitCursor = true;
            this.TextBoxPartName.TextChanged += new System.EventHandler(this.TextBoxPartName_TextChanged);
            // 
            // TextBoxPartInv
            // 
            this.TextBoxPartInv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartInv.Location = new System.Drawing.Point(178, 181);
            this.TextBoxPartInv.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartInv.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxPartInv.Name = "TextBoxPartInv";
            this.TextBoxPartInv.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartInv.TabIndex = 5;
            this.TextBoxPartInv.UseWaitCursor = true;
            this.TextBoxPartInv.TextChanged += new System.EventHandler(this.TextBoxPartInv_TextChanged);
            // 
            // TextBoxPartPriceCost
            // 
            this.TextBoxPartPriceCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartPriceCost.Location = new System.Drawing.Point(178, 221);
            this.TextBoxPartPriceCost.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartPriceCost.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxPartPriceCost.Name = "TextBoxPartPriceCost";
            this.TextBoxPartPriceCost.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartPriceCost.TabIndex = 6;
            this.TextBoxPartPriceCost.UseWaitCursor = true;
            this.TextBoxPartPriceCost.TextChanged += new System.EventHandler(this.TextBoxPartPriceCost_TextChanged);
            // 
            // TextBoxPartMax
            // 
            this.TextBoxPartMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartMax.Location = new System.Drawing.Point(178, 261);
            this.TextBoxPartMax.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartMax.MinimumSize = new System.Drawing.Size(75, 30);
            this.TextBoxPartMax.Name = "TextBoxPartMax";
            this.TextBoxPartMax.Size = new System.Drawing.Size(75, 29);
            this.TextBoxPartMax.TabIndex = 7;
            this.TextBoxPartMax.UseWaitCursor = true;
            this.TextBoxPartMax.TextChanged += new System.EventHandler(this.TextBoxPartMax_TextChanged);
            // 
            // TextBoxX
            // 
            this.TextBoxX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxX.Location = new System.Drawing.Point(178, 301);
            this.TextBoxX.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxX.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(150, 29);
            this.TextBoxX.TabIndex = 8;
            this.TextBoxX.UseWaitCursor = true;
            this.TextBoxX.TextChanged += new System.EventHandler(this.TextBoxX_TextChanged);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.Location = new System.Drawing.Point(144, 98);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(33, 21);
            this.LabelID.TabIndex = 9;
            this.LabelID.Text = "ID*";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(117, 141);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(53, 21);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name";
            // 
            // LabelInv
            // 
            this.LabelInv.AutoSize = true;
            this.LabelInv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInv.Location = new System.Drawing.Point(138, 181);
            this.LabelInv.Name = "LabelInv";
            this.LabelInv.Size = new System.Drawing.Size(39, 21);
            this.LabelInv.TabIndex = 11;
            this.LabelInv.Text = "Inv*";
            // 
            // LabelPriceCost
            // 
            this.LabelPriceCost.AutoSize = true;
            this.LabelPriceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPriceCost.Location = new System.Drawing.Point(84, 221);
            this.LabelPriceCost.Name = "LabelPriceCost";
            this.LabelPriceCost.Size = new System.Drawing.Size(93, 21);
            this.LabelPriceCost.TabIndex = 12;
            this.LabelPriceCost.Text = "Price/Cost*";
            // 
            // LabelMax
            // 
            this.LabelMax.AutoSize = true;
            this.LabelMax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMax.Location = new System.Drawing.Point(129, 261);
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.Size = new System.Drawing.Size(48, 21);
            this.LabelMax.TabIndex = 13;
            this.LabelMax.Text = "Max*";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX.Location = new System.Drawing.Point(44, 298);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(99, 21);
            this.LabelX.TabIndex = 14;
            this.LabelX.Text = "Machine ID*";
            // 
            // TextBoxPartMin
            // 
            this.TextBoxPartMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartMin.Location = new System.Drawing.Point(341, 261);
            this.TextBoxPartMin.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartMin.MinimumSize = new System.Drawing.Size(75, 30);
            this.TextBoxPartMin.Name = "TextBoxPartMin";
            this.TextBoxPartMin.Size = new System.Drawing.Size(75, 29);
            this.TextBoxPartMin.TabIndex = 15;
            this.TextBoxPartMin.UseWaitCursor = true;
            this.TextBoxPartMin.TextChanged += new System.EventHandler(this.TextBoxPartMin_TextChanged);
            // 
            // LabelMin
            // 
            this.LabelMin.AutoSize = true;
            this.LabelMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMin.Location = new System.Drawing.Point(292, 261);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.Size = new System.Drawing.Size(45, 21);
            this.LabelMin.TabIndex = 16;
            this.LabelMin.Text = "Min*";
            // 
            // ButtonPartSave
            // 
            this.ButtonPartSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonPartSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPartSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPartSave.Location = new System.Drawing.Point(225, 368);
            this.ButtonPartSave.Name = "ButtonPartSave";
            this.ButtonPartSave.Size = new System.Drawing.Size(75, 33);
            this.ButtonPartSave.TabIndex = 17;
            this.ButtonPartSave.Text = "Save";
            this.ButtonPartSave.UseVisualStyleBackColor = false;
            this.ButtonPartSave.Click += new System.EventHandler(this.ButtonPartSave_Click);
            // 
            // ButtonPartCancel
            // 
            this.ButtonPartCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonPartCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPartCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPartCancel.Location = new System.Drawing.Point(341, 368);
            this.ButtonPartCancel.Name = "ButtonPartCancel";
            this.ButtonPartCancel.Size = new System.Drawing.Size(75, 33);
            this.ButtonPartCancel.TabIndex = 18;
            this.ButtonPartCancel.Text = "Cancel";
            this.ButtonPartCancel.UseVisualStyleBackColor = false;
            this.ButtonPartCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.ButtonPartCancel);
            this.Controls.Add(this.ButtonPartSave);
            this.Controls.Add(this.LabelMin);
            this.Controls.Add(this.TextBoxPartMin);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.LabelMax);
            this.Controls.Add(this.LabelPriceCost);
            this.Controls.Add(this.LabelInv);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.TextBoxPartMax);
            this.Controls.Add(this.TextBoxPartPriceCost);
            this.Controls.Add(this.TextBoxPartInv);
            this.Controls.Add(this.TextBoxPartName);
            this.Controls.Add(this.TextBoxPartID);
            this.Controls.Add(RadioButtonOutsourced);
            this.Controls.Add(this.RadioButtonInHouse);
            this.Controls.Add(this.LabelAddPart);
            this.Name = "AddPartScreen";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddPart;
        private System.Windows.Forms.RadioButton RadioButtonInHouse;
        private System.Windows.Forms.TextBox TextBoxPartID;
        private System.Windows.Forms.TextBox TextBoxPartName;
        private System.Windows.Forms.TextBox TextBoxPartInv;
        private System.Windows.Forms.TextBox TextBoxPartPriceCost;
        private System.Windows.Forms.TextBox TextBoxPartMax;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelInv;
        private System.Windows.Forms.Label LabelPriceCost;
        private System.Windows.Forms.Label LabelMax;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.TextBox TextBoxPartMin;
        private System.Windows.Forms.Label LabelMin;
        private System.Windows.Forms.Button ButtonPartSave;
        private System.Windows.Forms.Button ButtonPartCancel;
    }
}