using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddExpenditureForm : Form
    {
        public AddExpenditureForm()
        {
            InitializeComponent();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = this.dtpDate.Value;
            string note = this.txtNote.Text;
            int price = Decimal.ToInt32(this.nudUpDown.Value);

            var expenditure = new Expenditure();
            expenditure.Date = date;
            expenditure.Note = note;
            expenditure.Price = price;

            var db = new OOPCSEntities();
            db.Expenditure.Add(expenditure);
            db.SaveChanges();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
