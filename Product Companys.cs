using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AbstractClasses1
{
    class ProductCompanys : ProductValues
    {
        //Constructer from ProductValue class
        private string vatNumber;
        public ProductCompanys(string Name, double Price, double Qty, string Number, String vatNumber) : base(Name, Price, Qty, Number)
        {
            VatNumber = vatNumber;
        }
        public string VatNumber
        {
            get
            {
                return vatNumber;
            }
            set
            {
                vatNumber = value;
            }
        }

        public override string toString()//to string is a method//override means no other methods exist
        {
            //calls this method and the previous method
            return base.toString() + "\nCompany Vat Number " + VatNumber;//base goes to inheritated class which is Product Values
        }



    }
}