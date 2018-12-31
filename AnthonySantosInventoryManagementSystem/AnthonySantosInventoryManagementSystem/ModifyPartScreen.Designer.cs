namespace AnthonySantosInventoryManagementSystem
{
    partial class ModifyPartScreen
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
            this.RadioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.ButtonModifyCancel = new System.Windows.Forms.Button();
            this.ButtonModifySave = new System.Windows.Forms.Button();
            this.LabelMin = new System.Windows.Forms.Label();
            this.TextBoxPartMin = new System.Windows.Forms.TextBox();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelMax = new System.Windows.Forms.Label();
            this.LabelPriceCost = new System.Windows.Forms.Label();
            this.LabelInv = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextBoxPartMax = new System.Windows.Forms.TextBox();
            this.TextBoxPartPriceCost = new System.Windows.Forms.TextBox();
            this.TextBoxPartInv = new System.Windows.Forms.TextBox();
            this.TextBoxPartName = new System.Windows.Forms.TextBox();
            this.TextBoxPartID = new System.Windows.Forms.TextBox();
            this.RadioButtonInHouse = new System.Windows.Forms.RadioButton();
            this.LabelModifyPart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RadioButtonOutsourced
            // 
            this.RadioButtonOutsourced.AutoSize = true;
            this.RadioButtonOutsourced.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonOutsourced.Location = new System.Drawing.Point(301, 21);
            this.RadioButtonOutsourced.Name = "RadioButtonOutsourced";
            this.RadioButtonOutsourced.Size = new System.Drawing.Size(114, 25);
            this.RadioButtonOutsourced.TabIndex = 21;
            this.RadioButtonOutsourced.Text = "Outsourced";
            this.RadioButtonOutsourced.UseVisualStyleBackColor = true;
            this.RadioButtonOutsourced.CheckedChanged += new System.EventHandler(this.RadioButtonOutsourced_CheckedChanged);
            // 
            // ButtonModifyCancel
            // 
            this.ButtonModifyCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonModifyCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonModifyCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModifyCancel.Location = new System.Drawing.Point(340, 364);
            this.ButtonModifyCancel.Name = "ButtonModifyCancel";
            this.ButtonModifyCancel.Size = new System.Drawing.Size(75, 33);
            this.ButtonModifyCancel.TabIndex = 37;
            this.ButtonModifyCancel.Text = "Cancel";
            this.ButtonModifyCancel.UseVisualStyleBackColor = false;
            this.ButtonModifyCancel.Click += new System.EventHandler(this.ButtonModifyCancel_Click);
            // 
            // ButtonModifySave
            // 
            this.ButtonModifySave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonModifySave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonModifySave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModifySave.Location = new System.Drawing.Point(224, 364);
            this.ButtonModifySave.Name = "ButtonModifySave";
            this.ButtonModifySave.Size = new System.Drawing.Size(75, 33);
            this.ButtonModifySave.TabIndex = 36;
            this.ButtonModifySave.Text = "Save";
            this.ButtonModifySave.UseVisualStyleBackColor = false;
            this.ButtonModifySave.Click += new System.EventHandler(this.ButtonModifySave_Click);
            // 
            // LabelMin
            // 
            this.LabelMin.AutoSize = true;
            this.LabelMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMin.Location = new System.Drawing.Point(291, 257);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.Size = new System.Drawing.Size(45, 21);
            this.LabelMin.TabIndex = 35;
            this.LabelMin.Text = "Min*";
            // 
            // TextBoxPartMin
            // 
            this.TextBoxPartMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartMin.Location = new System.Drawing.Point(340, 257);
            this.TextBoxPartMin.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartMin.MinimumSize = new System.Drawing.Size(75, 30);
            this.TextBoxPartMin.Name = "TextBoxPartMin";
            this.TextBoxPartMin.Size = new System.Drawing.Size(75, 29);
            this.TextBoxPartMin.TabIndex = 34;
            this.TextBoxPartMin.UseWaitCursor = true;
            this.TextBoxPartMin.TextChanged += new System.EventHandler(this.TextBoxPartMin_TextChanged);
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX.Location = new System.Drawing.Point(43, 294);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(99, 21);
            this.LabelX.TabIndex = 33;
            this.LabelX.Text = "Machine ID*";
            // 
            // LabelMax
            // 
            this.LabelMax.AutoSize = true;
            this.LabelMax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMax.Location = new System.Drawing.Point(128, 257);
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.Size = new System.Drawing.Size(48, 21);
            this.LabelMax.TabIndex = 32;
            this.LabelMax.Text = "Max*";
            // 
            // LabelPriceCost
            // 
            this.LabelPriceCost.AutoSize = true;
            this.LabelPriceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPriceCost.Location = new System.Drawing.Point(83, 217);
            this.LabelPriceCost.Name = "LabelPriceCost";
            this.LabelPriceCost.Size = new System.Drawing.Size(93, 21);
            this.LabelPriceCost.TabIndex = 31;
            this.LabelPriceCost.Text = "Price/Cost*";
            // 
            // LabelInv
            // 
            this.LabelInv.AutoSize = true;
            this.LabelInv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInv.Location = new System.Drawing.Point(137, 177);
            this.LabelInv.Name = "LabelInv";
            this.LabelInv.Size = new System.Drawing.Size(39, 21);
            this.LabelInv.TabIndex = 30;
            this.LabelInv.Text = "Inv*";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(116, 137);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(53, 21);
            this.LabelName.TabIndex = 29;
            this.LabelName.Text = "Name";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.Location = new System.Drawing.Point(143, 94);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(33, 21);
            this.LabelID.TabIndex = 28;
            this.LabelID.Text = "ID*";
            // 
            // TextBoxX
            // 
            this.TextBoxX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxX.Location = new System.Drawing.Point(177, 297);
            this.TextBoxX.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxX.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(150, 29);
            this.TextBoxX.TabIndex = 27;
            this.TextBoxX.UseWaitCursor = true;
            this.TextBoxX.TextChanged += new System.EventHandler(this.TextBoxX_TextChanged);
            // 
            // TextBoxPartMax
            // 
            this.TextBoxPartMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartMax.Location = new System.Drawing.Point(177, 257);
            this.TextBoxPartMax.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartMax.MinimumSize = new System.Drawing.Size(75, 30);
            this.TextBoxPartMax.Name = "TextBoxPartMax";
            this.TextBoxPartMax.Size = new System.Drawing.Size(75, 29);
            this.TextBoxPartMax.TabIndex = 26;
            this.TextBoxPartMax.UseWaitCursor = true;
            this.TextBoxPartMax.TextChanged += new System.EventHandler(this.TextBoxPartMax_TextChanged);
            // 
            // TextBoxPartPriceCost
            // 
            this.TextBoxPartPriceCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartPriceCost.Location = new System.Drawing.Point(177, 217);
            this.TextBoxPartPriceCost.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartPriceCost.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxPartPriceCost.Name = "TextBoxPartPriceCost";
            this.TextBoxPartPriceCost.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartPriceCost.TabIndex = 25;
            this.TextBoxPartPriceCost.UseWaitCursor = true;
            this.TextBoxPartPriceCost.TextChanged += new System.EventHandler(this.TextBoxPartPriceCost_TextChanged);
            // 
            // TextBoxPartInv
            // 
            this.TextBoxPartInv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartInv.Location = new System.Drawing.Point(177, 177);
            this.TextBoxPartInv.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartInv.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxPartInv.Name = "TextBoxPartInv";
            this.TextBoxPartInv.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartInv.TabIndex = 24;
            this.TextBoxPartInv.UseWaitCursor = true;
            this.TextBoxPartInv.TextChanged += new System.EventHandler(this.TextBoxPartInv_TextChanged);
            // 
            // TextBoxPartName
            // 
            this.TextBoxPartName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartName.Location = new System.Drawing.Point(177, 137);
            this.TextBoxPartName.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartName.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxPartName.Name = "TextBoxPartName";
            this.TextBoxPartName.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartName.TabIndex = 23;
            this.TextBoxPartName.UseWaitCursor = true;
            this.TextBoxPartName.TextChanged += new System.EventHandler(this.TextBoxPartName_TextChanged);
            // 
            // TextBoxPartID
            // 
            this.TextBoxPartID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxPartID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TextBoxPartID.Enabled = false;
            this.TextBoxPartID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPartID.Location = new System.Drawing.Point(177, 97);
            this.TextBoxPartID.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPartID.MinimumSize = new System.Drawing.Size(150, 30);
            this.TextBoxPartID.Name = "TextBoxPartID";
            this.TextBoxPartID.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartID.TabIndex = 22;
            this.TextBoxPartID.UseWaitCursor = true;
            this.TextBoxPartID.TextChanged += new System.EventHandler(this.TextBoxPartID_TextChanged);
            // 
            // RadioButtonInHouse
            // 
            this.RadioButtonInHouse.AutoSize = true;
            this.RadioButtonInHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonInHouse.Location = new System.Drawing.Point(177, 21);
            this.RadioButtonInHouse.Name = "RadioButtonInHouse";
            this.RadioButtonInHouse.Size = new System.Drawing.Size(95, 25);
            this.RadioButtonInHouse.TabIndex = 20;
            this.RadioButtonInHouse.Text = "In-House";
            this.RadioButtonInHouse.UseVisualStyleBackColor = true;
            this.RadioButtonInHouse.CheckedChanged += new System.EventHandler(this.RadioButtonInHouse_CheckedChanged);
            // 
            // LabelModifyPart
            // 
            this.LabelModifyPart.AutoSize = true;
            this.LabelModifyPart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModifyPart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelModifyPart.Location = new System.Drawing.Point(12, 9);
            this.LabelModifyPart.Name = "LabelModifyPart";
            this.LabelModifyPart.Size = new System.Drawing.Size(130, 30);
            this.LabelModifyPart.TabIndex = 19;
            this.LabelModifyPart.Text = "Modify Part";
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 453);
            this.Controls.Add(this.ButtonModifyCancel);
            this.Controls.Add(this.ButtonModifySave);
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
            this.Controls.Add(this.RadioButtonOutsourced);
            this.Controls.Add(this.RadioButtonInHouse);
            this.Controls.Add(this.LabelModifyPart);
            this.Name = "ModifyPartScreen";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonModifyCancel;
        private System.Windows.Forms.Button ButtonModifySave;
        private System.Windows.Forms.Label LabelMin;
        private System.Windows.Forms.TextBox TextBoxPartMin;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelMax;
        private System.Windows.Forms.Label LabelPriceCost;
        private System.Windows.Forms.Label LabelInv;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.TextBox TextBoxPartMax;
        private System.Windows.Forms.TextBox TextBoxPartPriceCost;
        private System.Windows.Forms.TextBox TextBoxPartInv;
        private System.Windows.Forms.TextBox TextBoxPartName;
        private System.Windows.Forms.TextBox TextBoxPartID;
        private System.Windows.Forms.RadioButton RadioButtonInHouse;
        private System.Windows.Forms.Label LabelModifyPart;
        private System.Windows.Forms.RadioButton RadioButtonOutsourced;
    }
}