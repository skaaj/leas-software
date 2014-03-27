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
    public partial class NewUserControl : UserControl
    {
        private MainForm context;

        public NewUserControl(MainForm context)
        {
            InitializeComponent();

            this.context = context;
        }

        private void onSubmit(object sender, EventArgs e)
        {
            /* TODO : prompt l'ajout */
            string nom  = this.boxUserName.Text;
            int age     = (int)numericAge.Value;
            bool sexe = (comboBoxSex.Text == "Homme") ? true : false;
            int category = (int)numericCategory.Value;

            if (!nom.Equals(String.Empty) && !sexe.Equals(String.Empty))
            {
                int id = context.Model.AddUser(nom, age, sexe, category);
                context.StartUserSession(id);

                boxUserName.Clear();
                numericAge.Value = 25;
            }
        }

        private void onEnter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            tb.Select(0, tb.Text.Length);
            tb.ForeColor = Color.Black;
            tb.BackColor = Color.White;
        }

        private void onLeave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string mustFill = "Veuillez remplir ce champs";
            if (tb.Text.Equals(String.Empty) || tb.Text.Equals(mustFill))
            {
                tb.Text = mustFill;
                tb.ForeColor = Color.DarkRed;
                tb.BackColor = Color.Pink;
            }
            else
            {
                tb.ForeColor = Color.Black;
                tb.BackColor = Color.White;
                tb.Text = new CultureInfo("fr-FR").TextInfo.ToTitleCase(tb.Text);
            }
        }

        private void onClickAge(object sender, EventArgs e)
        {
            this.numericAge.Select(0, this.numericAge.Value.ToString().Length);
        }

        private void onClickName(object sender, EventArgs e)
        {
            this.boxUserName.Select(0, this.boxUserName.Text.Length);
        }

        private void onValidated(object sender, EventArgs e)
        {
            string input = this.comboBoxSex.Text.ToUpper();
            if (!input.Equals("HOMME") && !input.Equals("FEMME"))
            {
                this.comboBoxSex.Text = "Homme";
            }
        }
    }
}
