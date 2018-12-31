using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AnthonySantosInventoryManagementSystem
{
    public class Inventory
    {
        //instance variables      
        private static BindingList<Product> myProductList = new BindingList<Product>();
        private static BindingList<Part> myPartList = new BindingList<Part>();
        
        //storage for current part selected
        public static Part CurrentPart { get; set; }
        
        //storage for current product selected
        public static Product CurrentProduct { get; set; }

        //constructor
        public Inventory(BindingList<Part> MyPartList, BindingList<Product> MyProductList)
        {
            myPartList = MyPartList;
            myProductList = MyProductList;
        }

        //properties to get and set lists
        public static BindingList<Part> MyPartList { get { return myPartList; } set { myPartList = value; } }
        public static BindingList<Product> MyProductList { get { return myProductList; } set { myProductList = value; } }

        //Add a product to inventory
        public void AddProduct(Product x)
        {
            myProductList.Add(x);
        }

        //Remove a product from inventory
        public void RemoveProduct(Product x)
        {
            //LINQ query to select from products
            var searched =
                from p in myProductList // data source is myProductList
                where p == x
                select p;

            //attempt to remove the result above
            if (searched.Any())
            {
                myProductList.Remove(x);
            }
            //**WARNING might need to add exception handling here
        }

        //Lookup a product in inventory
        public static Product LookupProduct(int x)
        {
            for (int j = 0; j < MyProductList.Count; j++)
            {
                if (MyProductList[j].ProductID.Equals(x))
                {
                    return MyProductList[j];
                }
            }
            return null;

            ////local variable to track status and to change status to ProductID
            ////when found.
            //int status = 0;

            ////creates new list of only ProductID
            //var filteredlist =
            //    from p in myProductList // data source is products
            //    select p.ProductID;

            ////loops through new PartID list returning the match
            //foreach (var element in filteredlist)
            //{
            //    if (element == x)
            //    {
            //        status = element;
            //    }
            //}
            //return status; //**WARNING** might be a potential issue later
        }

        //Update a product in inventory
        internal static void UpdateProduct(Product product)
        {
            //not exactly sure what to do here
            //maybe i need to work on windows forms first

            //find product first (int x) is the position index
            //send in new information for the product
            //update in the list

            int indexSwapPoint = MyProductList.IndexOf(CurrentProduct);

            MyProductList.RemoveAt(indexSwapPoint);
            MyProductList.Insert(indexSwapPoint, product);
        }

        //Add part to inventory
        public void AddPart(Part x)
        {
            myPartList.Add(x);

        }

        //Delete part from inventory
        public void DeletePart(Part x)
        {
            //LINQ query to select from parts
            var searched =
                from p in myPartList // data source is parts
                where p == x
                select p;

            //attempt to remove the result above
            if (searched.Any())
            {
                myPartList.Remove(x);
            }
            //**WARNING may need to add exception handling here
        }

        //lookup a part in inventory
        public static Part LookupPart(int x)
        {
            for (int j = 0; j < MyPartList.Count; j++)
            {
                if (MyPartList[j].PartID.Equals(x))
                {
                    return MyPartList[j];
                }
            }
            return null;

            ////local variable to track status and to change status to PartID
            ////when found.
            //int status = 0;

            ////creates new list of only PartID
            //var filteredlist =
            //    from p in myPartList // data source is associatedParts
            //    select p.PartID;

            ////loops through new PartID list returning the match
            //foreach (var element in filteredlist)
            //{
            //    if (element == x)
            //    {
            //        status = element;
            //    }
            //}
            //return status; //**WARNING** might be a potential issue later
        }

        //Update a part in inventory
        internal static void UpdatePart(Part part)
        {
            int indexSwapPoint = MyPartList.IndexOf(CurrentPart);

            MyPartList.RemoveAt(indexSwapPoint);
            MyPartList.Insert(indexSwapPoint, part);
        }
    }
}
