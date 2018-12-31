using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnthonySantosInventoryManagementSystem
{
    public abstract class Part
    {
        //instance variables
        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        //constructor
        public Part(int PartID, string Name, double Price, int InStock, int Min, int Max)
        {
            partID = PartID;
            name = Name;
            price = Price;
            inStock = InStock;
            min = Min;
            max = Max;
        }

        //Properties
        public int PartID
        {
            get
            {
                return partID;
            }
            set
            {
                MessageBox.Show("test");
                partID = value;      
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                //10.7 placeholder for non numeric exception throw

                price = value;
            }
        }

        public int InStock
        {
            get
            {
                return inStock;
            }
            set
            {
                //10.7 placeholder for non numeric exception throw

                inStock = value;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                //VALIDATE min<max and also for non numeric exception throw

                min = value;
            }
        }

        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                //validate for numeric value

                max = value;
            }
        } 
    }
}
