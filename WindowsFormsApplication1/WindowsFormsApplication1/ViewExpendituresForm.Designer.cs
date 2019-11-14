namespace WindowsFormsApplication1
{
    partial class ViewExpendituresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdExpenditures = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddExpenditure = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenditures)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdExpenditures
            // 
            this.grdExpenditures.AllowUserToAddRows = false;
            this.grdExpenditures.AllowUserToDeleteRows = false;
            this.grdExpenditures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenditures.Location = new System.Drawing.Point(-2, 23);
            this.grdExpenditures.Name = "grdExpenditures";
            this.grdExpenditures.ReadOnly = true;
            this.grdExpenditures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExpenditures.Size = new System.Drawing.Size(554, 311);
            this.grdExpenditures.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddExpenditure});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddExpenditure
            // 
            this.btnAddExpenditure.Name = "btnAddExpenditure";
            this.btnAddExpenditure.Size = new System.Drawing.Size(66, 20);
            this.btnAddExpenditure.Text = "Add new";
            // 
            // ViewExpendituresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 335);
            this.Controls.Add(this.grdExpenditures);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewExpendituresForm";
            this.Text = "View all of expenditures";
            this.Load += new System.EventHandler(this.ViewExpendituresForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenditures)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdExpenditures;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddExpenditure;
    }
}