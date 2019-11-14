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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnViewExpenditures.Click += btnViewExpenditures_Click;
        }
        void btnViewExpenditures_Click(object sender, EventArgs e)
        {
            var form = new ViewExpendituresForm();
            form.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
