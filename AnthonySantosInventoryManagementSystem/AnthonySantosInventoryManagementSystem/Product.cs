using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AnthonySantosInventoryManagementSystem
{
    public class Product
    {
        //instance variables
        public static BindingList<Part> myAssociatedParts = new BindingList<Part>();
        private int productID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        //constructor
        public Product(BindingList<Part> MyAssociatedParts, int ProductID, string Name,
            double Price, int InStock, int Min, int Max)
        {
            myAssociatedParts = MyAssociatedParts;
            productID = ProductID;
            name = Name;
            price = Price;
            inStock = InStock;
            min = Min;
            max = Max;
        }

        //auto-implemented property
        public BindingList<Part> MyAssociatedParts { get { return myAssociatedParts; } set { myAssociatedParts = value; } }

        //Properties
        

        public int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                //non numeric validation needed
                //    int number;

                //    bool success = Int32.TryParse(value, out number);



                //    if(success)
                //    {
                //        productID = value;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Product ID requires a numerical value.");
                //    }
                productID = value;
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
                //validation for non numeric here

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
                //validation for non numeric here

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
                //validate min<max and non numeric here

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
                //validate for non numeric here

                max = value;
            }
        }


        //add Part to associatedParts list
        public void AddPart(Part x)
        {
            myAssociatedParts.Add(x);
        }

        //remove Part from associatedParts list
        public void RemovePart(Part x)
        {
            //LINQ query to select from associatedParts
            var searched =
                from p in myAssociatedParts // data source is associatedParts
                where p == x
                select p;

            //attempt to remove the result above
            if (searched.Any())
            {
                myAssociatedParts.Remove(x);
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        //Queires associatedParts, makes new list of only PartIDs, loops new
        //list to return match.
        public int LookupPart(int x)
        {
            //local variable to track status and to change status to PartID
            //when found.
            int status = 0;

            //creates new list of only PartID
            var filteredlist =
                from p in myAssociatedParts // data source is associatedParts
                select p.PartID;

            //loops through new PartID list returning the match
            foreach (var element in filteredlist)
            {
                if (element == x)
                {
                    status = element;
                }             
            }
            return status; //**WARNING** might be a potential issue later
        }
    }
}
