using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItemWithPackage : OrderItem
    {
        private string packageName;
        private decimal packagePrice;

        public OrderItemWithPackage(string name, int quantity, decimal unitPrice, string packageName, decimal packagePrice):
           base (name,quantity,unitPrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
                    }
        protected decimal PackagePrice
        {
            get
            {
                return packagePrice;
            }
        }
        protected string PackageName
        {
            get
            {
                return packageName;
            }
        }

        public override decimal GetValue()
        {
            return base.GetValue() + (Quantity * packagePrice);
        }

        public override string ToString()
        {
            return $"{Name}, cena: {UnitPrice} PLN, opakowanie:{packageName},cena opakowania: {packagePrice}, {Quantity} szt, " +
                $"wartość: {GetValue()} PLN";
        }
    }
}
//„Mleko, cena: 2.20 PLN, opakowanie: butelka,
//cena opakowania: 1 PLN, 5 szt, wartość: 16 PLN”