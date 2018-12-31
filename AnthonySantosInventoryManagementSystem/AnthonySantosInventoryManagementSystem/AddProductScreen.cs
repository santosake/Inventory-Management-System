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
    public partial class AddProductScreen : Form
    {
        public AddProductScreen()
        {
            InitializeComponent();
            FormatDGV(DataGridViewPartsAvailable);
            FormatDGV(DataGridViewPartsInProduct);
            Display();
        }

        public BindingList<Part> associatedParts = new BindingList<Part>();
        public int Index = -1;
        public int IndexDelete = -1;
        public Part selectedPart;
        public int idxSelectedPart;

        //formatting for the DGV
        private void FormatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = true;
        }

        private void Display()
        {
            DataGridViewPartsAvailable.AutoGenerateColumns = false;
            DataGridViewPartsInProduct.AutoGenerateColumns = false;
            DataGridViewPartsAvailable.DataSource = Inventory.MyPartList;
            DataGridViewPartsInProduct.DataSource = associatedParts;
            DataGridViewPartsAvailable.ClearSelection();
            DataGridViewPartsInProduct.ClearSelection();
        }

        public void CurrentSelectedPart()
        {
            if (Index >= 0)
            {
                for (int j = 0; j < Inventory.MyPartList.Count; j++)
                {
                    if (Inventory.MyPartList[j].PartID == (int)DataGridViewPartsAvailable.Rows[Index].Cells[0].Value)
                    {
                        selectedPart = Inventory.MyPartList[j];
                    }
                }
            }
        }

        private void ButtonSearchPart_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchPart.Text == "")
            {
                MessageBox.Show("Please enter the name of the part to be searched.");
            }
            else
            {
                string x = TextBoxSearchPart.Text;
                int count = 0;

                for (int j = 0; j < Inventory.MyPartList.Count; j++)
                {


                    if (Inventory.MyPartList[j].Name.Equals(x))
                    {
                        DataGridViewPartsAvailable.ClearSelection();
                        DataGridViewPartsAvailable.Rows[j].Selected = true;
                        count++;
                    }


                }

                if (count < 1)
                {
                    MessageBox.Show("Part Name not found exactly as searched.(Case Sensitive)");
                }

            }
        }

        private void ButtonAddPart_Click(object sender, EventArgs e)
        {
            if (Index >= 0)
            {
                CurrentSelectedPart();
                associatedParts.Add(selectedPart);
                Display();
            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }

        }

        private void ButtonDeletePart_Click(object sender, EventArgs e)
        {
            if (IndexDelete >= 0)
            {
                for (int j = 0; j < associatedParts.Count; j++)
                {
                    if (associatedParts[j].PartID == (int)DataGridViewPartsInProduct.Rows[IndexDelete].Cells[0].Value)
                    {
                        if (MessageBox.Show("Please Confirm Delete Action", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            associatedParts.RemoveAt(j);
                        }
                        //associatedParts.RemoveAt(j);
                    }
                }
                Display();
                IndexDelete = -1;
            }
            else
            {
                MessageBox.Show("Select a row");
            }
        }

        private void ButtonProductSave_Click(object sender, EventArgs e)
        {
            Product x = new Product(associatedParts, Int32.Parse(TextBoxProductID.Text), TextBoxProductName.Text, Double.Parse(TextBoxProductPriceCost.Text),
               Int32.Parse(TextBoxProductInv.Text), Int32.Parse(TextBoxProductMin.Text), Int32.Parse(TextBoxProductMin.Text));
            Inventory.MyProductList.Add(x);
            this.Hide();                       
        }

        private void ButtonProductCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
            //this.Hide();
        }

        private void TextBoxProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxProductInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxProductPriceCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxProductMax_TextChanged(object sender, EventArgs e)
        {
            // Makes sure Product Max has numerical value
            int number;
            if (!Int32.TryParse(TextBoxProductMax.Text, out number))
            {
                TextBoxProductMax.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Please enter an integer for Max's Value.");
            }
            else
            {
                TextBoxProductMax.BackColor = System.Drawing.Color.White;
            }
        }

        private void TextBoxProductMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewPartsAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
            idxSelectedPart = DataGridViewPartsAvailable.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.LookupPart((int)DataGridViewPartsAvailable.Rows[idxSelectedPart].Cells[0].Value);
            DataGridViewPartsAvailable.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void DataGridViewPartsInProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexDelete = e.RowIndex;
            idxSelectedPart = DataGridViewPartsInProduct.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.LookupPart((int)DataGridViewPartsInProduct.Rows[idxSelectedPart].Cells[0].Value);
            DataGridViewPartsInProduct.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void TextBoxSearchPart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
