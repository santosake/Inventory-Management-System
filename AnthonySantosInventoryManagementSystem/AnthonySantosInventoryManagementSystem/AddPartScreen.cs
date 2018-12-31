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
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
        }

        bool isInHouse;
        int min;
        int max;

        //store users choice of radio button, 1 for inhouse 2 for outsourced
        int rbselected = 0;

        // allows save when values are validated
        //private bool EnableSave()
        //{
        //    int number;
        //    int number2;
        //    int number3;
        //    int number4;
        //    int number5;
        //    int number6;

        //    return (Int32.TryParse(TextBoxPartID.Text, out number)) &&
        //        (!string.IsNullOrWhiteSpace(TextBoxPartName.Text)) &&
        //        (Int32.TryParse(TextBoxPartInv.Text, out number2)) &&
        //        (Int32.TryParse(TextBoxPartPriceCost.Text, out number3)) &&
        //        (Int32.TryParse(TextBoxPartMax.Text, out number4)) &&
        //        (Int32.TryParse(TextBoxPartMin.Text, out number5)) &&
        //        (!(string.IsNullOrWhiteSpace(TextBoxX.Text) || (isInHouse && !Int32.TryParse(TextBoxX.Text, out number6))));
        //}

        private void RBSwitchChange()
        {
            // Validates the textbox that switches between InHouse and Outsourced
            int number;
            if (string.IsNullOrWhiteSpace(TextBoxX.Text) || (isInHouse && !Int32.TryParse(TextBoxX.Text, out number)))
            {
                TextBoxX.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TextBoxX.BackColor = System.Drawing.Color.White;
            }
            //ButtonPartSave.Enabled = EnableSave();
        }

        private void RadioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            //the label and textbox will change to Company Name
            LabelX.Text = "Company Name";
            isInHouse = false;
            rbselected = 2;
            RBSwitchChange();
        }

        private void RadioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            //the label and textbox will change to Machine ID
            LabelX.Text = "Machine ID*";
            isInHouse = true;
            rbselected = 1;
            RBSwitchChange();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
            //this.Hide();
        }

        private void ButtonPartSave_Click(object sender, EventArgs e)
        {
            if (rbselected == 1)
            {
                Inhouse x = new Inhouse(Int32.Parse(TextBoxPartID.Text), TextBoxPartName.Text, Double.Parse(TextBoxPartPriceCost.Text), Int32.Parse(TextBoxPartInv.Text), Int32.Parse(TextBoxPartMin.Text), Int32.Parse(TextBoxPartMax.Text), Int32.Parse(TextBoxX.Text));
                Inventory.MyPartList.Add(x);
                this.Hide();
            }
            else if (rbselected == 2)
            {
                //int tempPartID;
                //if (Int32.TryParse(TextBoxPartID.Text, out tempPartID))
                //{
                //    return;
                //}
                //else
                //    MessageBox.Show("Part ID requires numerical input");

                //int number = 0;
                //if (int.Parse(textBox1.Text.Trim(), out number))
                //{
                //    //textBox value is a number
                //}
                //else
                //{
                //    //not a number
                //    MessageBox.Show("Please insert a numerical value");
                //}


                Outsourced x = new Outsourced(Int32.Parse(TextBoxPartID.Text), TextBoxPartName.Text, Double.Parse(TextBoxPartPriceCost.Text), Int32.Parse(TextBoxPartInv.Text), Int32.Parse(TextBoxPartMin.Text), Int32.Parse(TextBoxPartMax.Text), TextBoxX.Text);
                Inventory.MyPartList.Add(x);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select a Part's Source");
            }
        }

        private void TextBoxPartID_TextChanged(object sender, EventArgs e)
        {
            // Makes sure PartID has numerical value
            int number;
            if (!Int32.TryParse(TextBoxPartID.Text, out number))
            {
                TextBoxPartID.BackColor = System.Drawing.Color.Salmon;
                //MessageBox.Show("Part ID needs to be a number.");
            }
            else
            {
                TextBoxPartID.BackColor = System.Drawing.Color.White;
            }
            //ButtonPartSave.Enabled = EnableSave();
        }

        private void TextBoxPartName_TextChanged(object sender, EventArgs e)
        {
            // Makes sure Part Name is not white space or empty
            
            if (string.IsNullOrWhiteSpace(TextBoxPartName.Text))
            {
                TextBoxPartName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TextBoxPartName.BackColor = System.Drawing.Color.White;
            }
            //ButtonPartSave.Enabled = EnableSave();
        }

        private void TextBoxPartInv_TextChanged(object sender, EventArgs e)
        {
            // Makes sure Inventory textbox has numerical value
            int number;
            if (!Int32.TryParse(TextBoxPartInv.Text, out number))
            {
                TextBoxPartInv.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TextBoxPartInv.BackColor = System.Drawing.Color.White;
            }
            //ButtonPartSave.Enabled = EnableSave();
        }

        private void TextBoxPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            // Makes sure Part's Price has numerical value
            int number;
            if (!Int32.TryParse(TextBoxPartPriceCost.Text, out number))
            {
                TextBoxPartPriceCost.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TextBoxPartPriceCost.BackColor = System.Drawing.Color.White;
            }
            //ButtonPartSave.Enabled = EnableSave();
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
                max = Int32.Parse(TextBoxPartMax.Text);
            }
            //ButtonPartSave.Enabled = EnableSave();
        }

        private void TextBoxPartMin_TextChanged(object sender, EventArgs e)
        {
            // Makes sure Part min has numerical value
            int number;
            
            if (!Int32.TryParse(TextBoxPartMin.Text, out number))
            {
                TextBoxPartMin.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TextBoxPartMin.BackColor = System.Drawing.Color.White;
                min = Int32.Parse(TextBoxPartMin.Text);
            }
            //ButtonPartSave.Enabled = EnableSave();
        }

        private void TextBoxX_TextChanged(object sender, EventArgs e)
        {
            //Validates textbox that feeds both InHouse and Outsourced 
            int number;
            if (string.IsNullOrWhiteSpace(TextBoxX.Text) || (isInHouse && !Int32.TryParse(TextBoxX.Text, out number)))
            {
                TextBoxX.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TextBoxX.BackColor = System.Drawing.Color.White;
            }
            //ButtonPartSave.Enabled = EnableSave();
        }
    }
}
