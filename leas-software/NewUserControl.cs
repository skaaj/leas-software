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
    public partial class NewUserControl : UserControl
    {
        private MainForm context;

        public NewUserControl(MainForm context)
        {
            InitializeComponent();

            this.context = context;
        }

        private void onClickAge(object sender, EventArgs e)
        {
            this.numericAge.Select(0, this.numericAge.Value.ToString().Length);
        }

        private void onSubmit(object sender, EventArgs e)
        {
            /* TODO : prompt l'ajout */
            string nom = this.boxUserName.Text;
            int age = (int)numericAge.Value;
            string sexe = comboBoxSex.Text;
            if (!nom.Equals(String.Empty) || !sexe.Equals(String.Empty))
            {
                context.Model.setCurrentUser(nom, age, sexe);
                context.startUserSession(0);
            }
        }

        private void onLeave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Equals(String.Empty))
            {
                tb.Text = "Veuillez remplir ce champs";
                tb.ForeColor = Color.DarkRed;
                tb.BackColor = Color.Pink;
            }
            else
            {
                tb.ForeColor = Color.Black;
                tb.BackColor = Color.White;
            }
        }
    }
}
