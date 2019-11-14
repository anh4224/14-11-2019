using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ExpendituresView
    {
        public int id { get; set; }
        public string Date { get; set; }
        public string Note { get; set; }
        public string Price { get; set; }


        public ExpendituresView(Expenditure expenditure)
        {
            this.id = expenditure.id;
            this.Date = String.Format("Ngay {0}/{1}",
                expenditure.Date.Day, expenditure.Date.Month);
            this.Note = expenditure.Note;
            this.Price = String.Format("{0:n0}", expenditure.Price);
        }
    }
}
