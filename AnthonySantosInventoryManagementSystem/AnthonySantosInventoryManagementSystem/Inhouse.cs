using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnthonySantosInventoryManagementSystem
{
    public class Inhouse : Part
    {
        //instance variable
        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;
        private int machineID;

        //Constructor
        public Inhouse(int PartID, string Name, double Price, int InStock,
            int Min, int Max, int MachineID) : base(PartID, Name, Price, InStock, Min, Max)
        {
            partID = PartID;
            name = Name;
            price = Price;
            inStock = InStock;
            min = Min;
            max = Max;
            machineID = MachineID;
        }

        //Property
        public int MachineID
        {
            get
            {
                return machineID;
            }
            private set
            {
                //validate for non numeric exception throw

                machineID = value;
            }
        }
    }
}
