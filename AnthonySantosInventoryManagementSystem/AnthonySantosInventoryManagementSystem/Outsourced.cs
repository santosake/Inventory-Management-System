using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnthonySantosInventoryManagementSystem
{
    public class Outsourced : Part
    {
        //instance variable
        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;
        private string companyName;
        
        //constructor
        public Outsourced(int PartID, string Name, double Price, int InStock,
            int Min, int Max, string CompanyName) : base(PartID, Name, Price, InStock, Min, Max)
        {
            partID = PartID;
            name = Name;
            price = Price;
            inStock = InStock;
            min = Min;
            max = Max;
            companyName = CompanyName;
        }

        //Property
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            private set
            {
                //validate for non string exception throw

                companyName = value;
            }
        }
    }
}
