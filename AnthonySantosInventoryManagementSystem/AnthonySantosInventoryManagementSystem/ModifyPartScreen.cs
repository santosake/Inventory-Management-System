using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnthonySantosInventoryManagementSystem
{
    public partial class ModifyPartScreen : Form
    {

        //saves DataGridView Part user selection
        //public int Index { get; set; }
        bool isInhouse;

        public ModifyPartScreen()
        {
            InitializeComponent();
            TextBoxPartID.Text = Inventory.CurrentPart.PartID.ToString();
            TextBoxPartName.Text = Inventory.CurrentPart.Name;
            TextBoxPartInv.Text = Inventory.CurrentPart.InStock.ToString();
            TextBoxPartPriceCost.Text = Inventory.CurrentPart.Price.ToString();
            TextBoxPartMax.Text = Inventory.CurrentPart.Max.ToString();
            TextBoxPartMin.Text = Inventory.CurrentPart.Min.ToString();
            if (Inventory.CurrentPart is Inhouse)
            {
                Inhouse e = (Inhouse)Inventory.CurrentPart;
                TextBoxX.Text = e.MachineID.ToString();
                isInhouse = true;
                RadioButtonInHouse.Checked = true;
            }
            else
            {
                Outsourced e = (Outsourced)Inventory.CurrentPart;
                TextBoxX.Text = e.CompanyName;
                isInhouse = false;
                RadioButtonOutsourced.Checked = true;
            }
        }

        private void ModifyPartScreen_Load(object sender, EventArgs e)
        {

        }

        private void RadioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            LabelX.Text = "Machine ID*";
            isInhouse = true;
        }

        private void RadioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            LabelX.Text = "Company Name";
            isInhouse = false;
        }

        private void TextBoxPartID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPartInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPartPriceCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPartMax_TextChanged(object sender, EventArgs e)
        {
            // Makes sure Part Max has numerical value
            int number;
            if (!Int32.TryParse(TextBoxPartMax.Text, out number))
            {
                TextBoxPartMax.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Please enter an integer for Max's Value.");
            }
            else
            {
                TextBoxPartMax.BackColor = System.Drawing.Color.White;
            }
        }

        private void TextBoxPartMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonModifySave_Click(object sender, EventArgs e)
        {
            if (isInhouse)
            {
                Part p = new Inhouse(Convert.ToInt32(TextBoxPartID.Text), TextBoxPartName.Text, Double.Parse(TextBoxPartPriceCost.Text),
                    Convert.ToInt32(TextBoxPartInv.Text), Convert.ToInt32(TextBoxPartMin.Text), Convert.ToInt32(TextBoxPartMax.Text),
                    Convert.ToInt32(TextBoxX.Text));
                Inventory.UpdatePart(p);
            }
            else
            {
                Part p = new Outsourced(Convert.ToInt32(TextBoxPartID.Text), TextBoxPartName.Text, Double.Parse(TextBoxPartPriceCost.Text),
                    Convert.ToInt32(TextBoxPartInv.Text), Convert.ToInt32(TextBoxPartMin.Text), Convert.ToInt32(TextBoxPartMax.Text),
                    TextBoxX.Text);
                Inventory.UpdatePart(p);
            }

            this.Hide();
            //InventoryManagementSystemMainScreen s1 = new InventoryManagementSystemMainScreen();
            //s1.Show();
        }

        private void ButtonModifyCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
            //this.Hide();
        }
    }
}
