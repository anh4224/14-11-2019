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
    public partial class ViewExpendituresForm : Form
    {
        public ViewExpendituresForm()
        {
            InitializeComponent();
            this.Load += ViewExpendituresForm_Load;
            this.btnAddExpenditure.Click += btnAddExpenditure_Click;
            this.grdExpenditures.KeyDown += grdExpenditures_KeyDown;
        }

        void grdExpenditures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (this.grdExpenditures.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Do you want to delete this?") 
                        == System.Windows.Forms.DialogResult.OK)
                    {
                        ExpendituresView selected = 
                            (ExpendituresView)this.grdExpenditures.SelectedRows[0].DataBoundItem;
                        var db = new OOPCSEntities();
                        Expenditure deleted = db.Expenditure.Find(selected.id);
                        db.Expenditure.Remove(deleted);
                        db.SaveChanges();
                        this.ViewAllExpenditures();
                    } 
                }
            }
        }

      

        void btnAddExpenditure_Click(object sender, EventArgs e)
        {
            (new AddExpenditureForm()).ShowDialog();
            this.ViewAllExpenditures();
        }
        void ViewExpendituresForm_Load(object sender, EventArgs e)
        {
            this.ViewAllExpenditures();
        }
        private void ViewAllExpenditures()
        {
            var db = new OOPCSEntities();
            var expenditures = db.Expenditure.ToArray();

            var expenditureViews = new ExpendituresView[expenditures.Length];
            for (int i = 0; i < expenditureViews.Length; i++)
                expenditureViews[i] = new ExpendituresView(expenditures[i]);

                this.grdExpenditures.DataSource = expenditureViews;
        }

        private void ViewExpendituresForm_Load_1(object sender, EventArgs e)
        {

        }
     
    }
}
