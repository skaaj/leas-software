using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leas_software
{
    public partial class GlossaryControl : UserControl
    {
        private MainForm context;
        private DataGridViewRow newRow;

        public GlossaryControl(MainForm context)
        {
            InitializeComponent();

            this.context = context;
            RefreshData();
        }

        public void RefreshData()
        {
            DataRowCollection words = context.Model.Database.GetWords();

            if (words == null) return;

            dataGridView.Rows.Clear();
            foreach (DataRow word in words)
            {
                string label   = word["label"].ToString();
                string level   = word["level"].ToString();
                string lexical = word["lexical"].ToString();

                dataGridView.Rows.Add(label, level, lexical);
            }
        }

        private void onAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            newRow = e.Row;
            MessageBox.Show("onAddedRow!!" + newRow.ToString());
        }

        private void onRowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (newRow != null)
            {
                MessageBox.Show("Trying to validate " + newRow.ToString());
                newRow = null;
            }
        }
    }
}
