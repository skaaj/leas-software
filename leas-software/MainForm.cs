using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leas_software
{
    public partial class MainForm : Form
    {
        private Model model;

        private SituationsControl situationControl;
        private SplashControl splashControl;
        private UserControl currentControl;
        private NewUserControl newUserControl;

        public MainForm()
        {
            /* Model */
            model = new Model();

            /* UI */
            InitializeComponent();
            InitializeControls();
        }

        /* Access */
        public Model Model
        {
            get
            {
                return model;
            }
        }


        /* Init */
        private void InitializeControls()
        {
            splashControl = new SplashControl();
            newUserControl = new NewUserControl(this);

            this.container.Controls.Add(splashControl);
        }

        public void startUserSession(int id)
        {
            situationControl = new SituationsControl(this);

            this.container.Controls.Clear();
            this.container.Controls.Add(situationControl);
            currentControl = situationControl;
            resizeContainer();
        }

        private void resizeContainer()
        {
            currentControl.Width = this.container.Width; // FIXME : provoque un crash lorsqu'on redimensionne sur le splash
            currentControl.Height = this.container.Height;
        }

        private void onClickSplashMenu(object sender, EventArgs e)
        {
            this.container.Controls.Clear();
            this.container.Controls.Add(splashControl);
            currentControl = splashControl;
        }

        private void onClickSituationsMenu(object sender, EventArgs e)
        {
            this.container.Controls.Clear();
            this.container.Controls.Add(situationControl);
            currentControl = situationControl;
        }

        private void onSizeChanged(object sender, EventArgs e)
        {
            resizeContainer();
        }

        private void onClickHome(object sender, EventArgs e)
        {
            this.container.Controls.Clear();
            this.container.Controls.Add(splashControl);
            currentControl = splashControl;
        }

        private void onClickExit(object sender, EventArgs e) // FIXME : Bien vider les ressources
        {
            this.Dispose();
            Application.Exit();
        }

        private void onClickNewUser(object sender, EventArgs e)
        {
            this.container.Controls.Clear();
            this.container.Controls.Add(newUserControl);
            currentControl = newUserControl;
        }
    }
}
