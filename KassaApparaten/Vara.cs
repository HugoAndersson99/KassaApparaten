using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaApparaten
{
    public class Vara
    {

        public string Name { get; set; }
        public int Value { get; set; }
        public int TotalAmountSold { get; set; }
        public int TotalAmountOfMoneySold {  get; set; }
        public Vara(string name, int value, int amountSold, int totalMoney)
        {
            Name = name;
            Value = value;
            TotalAmountSold = amountSold;
            TotalAmountOfMoneySold = totalMoney;
        }
        public Vara(string name, int value)
        {
            Name = name;
            Value = value;
            TotalAmountSold = 0;
            TotalAmountOfMoneySold = 0;
        }

        public string GetCSV()
        {
            return Name + ";" + Value + ";" + TotalAmountSold + ";" + TotalAmountOfMoneySold;
        }
    }
}
