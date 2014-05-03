using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace leas_software
{
    public partial class LoadUserControl : UserControl
    {
        private MainForm context;

        private string selected_name;
        private int selected_age;
        private bool selected_sex;

        public LoadUserControl(MainForm context)
        {
            InitializeComponent();

            this.dataGridView.Columns["nameCol"].DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            this.dataGridView.Columns["ageCol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.Columns["sexCol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.context = context;
            this.RefreshData();
        }

        public void RefreshData()
        {
            DataRowCollection users = context.Model.Database.GetPatients();

            if (users == null) return;

            dataGridView.Rows.Clear();
            foreach (DataRow user in users)
            {
                string name = new CultureInfo("en-US").TextInfo.ToTitleCase(user["name"].ToString());
                string age  = user["age"].ToString();
                string sex  = user["sex"].ToString();
                
                sex = (sex == "True") ? "Homme" : "Femme";

                dataGridView.Rows.Add(name, age, sex);
            }
        }

        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1) return;

            DataGridViewRow row = dataGridView.Rows[index];
            selected_name = row.Cells[0].Value.ToString();
            selected_age = int.Parse(row.Cells[1].Value.ToString());
            selected_sex = (row.Cells[2].Value.ToString() == "Homme") ? true : false;

            buttonLoad.BackColor = Color.LightGreen;
            buttonLoad.ForeColor = Color.Green;
            buttonLoad.Text = String.Format("Charger la saisie \"{0}\"", selected_name);
        }

        private void onResize(object sender, EventArgs e)
        {
            dataGridView.Height = buttonLoad.Top;
        }

        private void onClick(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
                return;

            int id = context.Model.Database.GetUserID(selected_name, selected_age, selected_sex);
            context.StartUserSession(id);
        }
    }
}
