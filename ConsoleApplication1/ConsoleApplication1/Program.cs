using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new OOPCSEntities();
            var expenditures = db.Expenditure.ToArray();

            int sum = 0;
            for (int i = 0; i < expenditures.Length; i++)
                sum += expenditures[i].Price;

            //sum = 0;
            //foreach (var exp in expenditures)
                //sum += exp.Price;
        }
    }
}
