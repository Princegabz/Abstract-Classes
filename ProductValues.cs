using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AbstractClasses1
{
    class ProductValues : Products//extends the product class

    {
        private String custNumber;
        public ProductValues(string Name, double Price, double Qty, String CustNumber) : base(Name, Price, Qty)//base sends information to the previous page
        {
            custNumber = CustNumber;//They are not in the product class to show that they can be seperated
        }
        public string CustNumber
        {
            get
            {
                return custNumber;
            }
            set
            {
                custNumber = value;
            }



        }
        public override string toString()//converts an object to its string representation so that it is suitable for display.
        {
            return "Customer No: " + custNumber + "\t Product name: " + this.ProductName + " Price:R" + this.ProductPrice + "\t Qty:" + this.ProductQty;
        }
    }
}