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
    public partial class InventoryManagementSystemMainScreen : Form
    {
        //saves DataGridViewPart user selection

        public int Index = -1;
        public int IndexProduct = -1;

        public int idxSelectedPart;
        public int idxSelectedProduct;

        //stores user's currently selected part
        public Part selectedPart;
        public Product selectedProduct;

        //**START HERE**
        public InventoryManagementSystemMainScreen()
        {
            InitializeComponent();
            //BuildPartList();
            FormatDGV(DataGridViewPart);
            FormatDGV(DataGridViewProduct);
            Display();
        }

        public void CurrentSelectedPart()
        {
            if (Index >= 0)
            {
                for (int j = 0; j < Inventory.MyPartList.Count; j++)
                {
                    if (Inventory.MyPartList[j].PartID == (int)DataGridViewPart.Rows[Index].Cells[0].Value)
                    {
                        selectedPart =  Inventory.MyPartList[j];
                    }
                }
            }
        }

        public void CurrentSelectedProduct()
        {
            if (IndexProduct >= 0)
            {
                for (int j = 0; j < Inventory.MyProductList.Count; j++)
                {
                    if (Inventory.MyProductList[j].ProductID == (int)DataGridViewProduct.Rows[IndexProduct].Cells[0].Value)
                    {
                        selectedProduct = Inventory.MyProductList[j];
                    }
                }
            }
        }

        //formatting for the DGV
        private void FormatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = true;
        }

        //Populates the list of Parts
        private void BuildPartList()
        {
            //Inventory.MyPartList.Clear();
            Inventory.MyPartList.Add(new Inhouse(987, "guitar body", 100, 9, 1, 10, 88));
            Inventory.MyPartList.Add(new Inhouse(876, "guitar neck", 50, 7, 1, 10, 76));
            Inventory.MyPartList.Add(new Outsourced(234, "tuning pegs", 2, 20, 6, 100, "Grover"));
            Inventory.MyPartList.Add(new Outsourced(456, "guitar strings", 15, 48, 6, 100, "Elixir"));
        }

        //Update display dgv with the current list
        private void Display()
        {
            DataGridViewPart.AutoGenerateColumns = false;
            DataGridViewProduct.AutoGenerateColumns = false;
            DataGridViewPart.DataSource = Inventory.MyPartList;
            DataGridViewProduct.DataSource = Inventory.MyProductList;
            DataGridViewPart.ClearSelection();
            DataGridViewProduct.ClearSelection();
        }

        //testing these functions
        private void DataGridViewPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Index = DataGridViewPart.CurrentCell.RowIndex;
            Index = e.RowIndex;
            idxSelectedPart = DataGridViewPart.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.LookupPart((int)DataGridViewPart.Rows[idxSelectedPart].Cells[0].Value);
            DataGridViewPart.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void DataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Index = DataGridViewPart.CurrentCell.RowIndex;
            IndexProduct = e.RowIndex;
            idxSelectedProduct = DataGridViewProduct.CurrentCell.RowIndex;
            Inventory.CurrentProduct = Inventory.LookupProduct((int)DataGridViewProduct.Rows[idxSelectedProduct].Cells[0].Value);
            DataGridViewProduct.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void InventoryManagementMainScreen_Load(object sender, EventArgs e)
        {
            Display();
        }

        //Event handlers
        private void ButtonAddPart_Click(object sender, EventArgs e)
        {
            AddPartScreen addPart = new AddPartScreen();
            addPart.Show();
        }

        private void ButtonModifyPart_Click(object sender, EventArgs e)
        {
            if (Index >= 0)
            {
                CurrentSelectedPart();
                ModifyPartScreen modifyPart = new ModifyPartScreen();
                modifyPart.Show();
                
            }
            else
            {
                MessageBox.Show("Select a part to Modify.");
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductScreen addProduct = new AddProductScreen();
            addProduct.Show();
        }

        private void ButtonExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            //Application.Exit();
        }

        private void ButtonModifyProduct_Click(object sender, EventArgs e)
        {
            if (IndexProduct >= 0)
            {
                CurrentSelectedProduct();
                ModifyProductScreen modifyProduct = new ModifyProductScreen();
                modifyProduct.Show();
                
            }
            else
            {
                MessageBox.Show("Select a product to Modify.");
            }
        }

        private void ButtonDeletePart_Click(object sender, EventArgs e)
        {
            
            if (Index >= 0)
            {
                for (int j = 0; j < Inventory.MyPartList.Count; j++)
                {
                    if (Inventory.MyPartList[j].PartID == (int)DataGridViewPart.Rows[Index].Cells[0].Value)
                    {
                        if(MessageBox.Show("Please Confirm Delete Action","Message", MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            Inventory.MyPartList.RemoveAt(j);
                        }
                        //Inventory.MyPartList.RemoveAt(j);
                    }
                }
                Display();
                Index = -1;
            }
            else
            {
                MessageBox.Show("Select a part");
            }
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (IndexProduct >= 0)
            {
                for (int j = 0; j < Inventory.MyProductList.Count; j++)
                {
                    if (Inventory.MyProductList[j].ProductID == (int)DataGridViewProduct.Rows[IndexProduct].Cells[0].Value)
                    {
                        if (MessageBox.Show("Please Confirm Delete Action", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Inventory.MyProductList.RemoveAt(j);
                        }
                        //Inventory.MyProductList.RemoveAt(j);
                    }
                }
                Display();
                Index = -1;
            }
            else
            {
                MessageBox.Show("Select a product");
            }
        }

        private void ButtonSearchProduct_Click(object sender, EventArgs e)
        {
            if (TextBoxSearchProduct.Text == "")
            {
                MessageBox.Show("Please enter the name of the product to be searched.");
            }
            else
            {
                string x = TextBoxSearchProduct.Text;
                int count = 0;

                for (int j = 0; j < Inventory.MyProductList.Count; j++)
                {


                    if (Inventory.MyProductList[j].Name.Equals(x))
                    {
                        DataGridViewProduct.ClearSelection();
                        DataGridViewProduct.Rows[j].Selected = true;
                        count++;
                    }


                }

                if (count < 1)
                {
                    MessageBox.Show("Product Name not found exactly as searched.(Case Sensitive)");
                }

                //                if (dataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchText)
                //{
                //                    dataGridView.Rows[i].Cells[j].Selected = true;
                //                }

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
                        DataGridViewPart.ClearSelection();
                        DataGridViewPart.Rows[j].Selected = true;
                        count++;
                    }
                    
                    
                }

                if (count < 1)
                {
                    MessageBox.Show("Part Name not found exactly as searched.(Case Sensitive)");
                }

//                if (dataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchText)
//{
//                    dataGridView.Rows[i].Cells[j].Selected = true;
//                }

            }
        }

        private void DataGridViewPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
            idxSelectedPart = DataGridViewPart.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.LookupPart((int)DataGridViewPart.Rows[idxSelectedPart].Cells[0].Value);
            DataGridViewPart.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void DataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexProduct = e.RowIndex;
            idxSelectedProduct = DataGridViewProduct.CurrentCell.RowIndex;
            Inventory.CurrentProduct = Inventory.LookupProduct((int)DataGridViewProduct.Rows[idxSelectedProduct].Cells[0].Value);
            DataGridViewProduct.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        //private void ButtonTestPartList_Click(object sender, EventArgs e)
        //{
        //    BuildPartList();
        //    DataGridViewPart.ClearSelection();
        //}
    }
}
