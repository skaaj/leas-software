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

        private SplashControl     splashControl;
        private SituationsControl situationControl;
        private NewUserControl    newUserControl;
        private LoadUserControl   loadUserControl;
        private GlossaryControl   glossaryControl;
        private ResultControl     resultControl;

        private UserControl       currentControl;

        public MainForm()
        {
            /* Model */
            model = new Model();

            /* UI */
            InitializeComponent();
            InitializeControls();
            InvertSaisieState();
        }

        /* Access */
        public Model Model
        {
            get
            {
                return model;
            }
        }

        /* Controls */
        private void InitializeControls()
        {
            splashControl    = new SplashControl();
            newUserControl   = new NewUserControl(this);
            loadUserControl  = new LoadUserControl(this);
            glossaryControl = new GlossaryControl(this);
            resultControl = new ResultControl(this);

            SelectControl(splashControl);
        }

        private void SelectControl(UserControl uc)
        {
            if (currentControl == uc) return;

            this.container.Controls.Clear();
            this.container.Controls.Add(uc);
            currentControl = uc;

            resizeContainer();
        }

        /* Dispatcher */
        public void StartUserSession(int id)
        {
            model.SetCurrentUser(id);

            situationControl = new SituationsControl(this);
            InvertSaisieState();
            SelectControl(situationControl);
        }

        public void SelectResultControl()
        {
            resultControl.RefreshGrid();
            SelectControl(resultControl);
        }

        public void SelectSituationControl()
        {
            SelectControl(situationControl);
        }

        private void onClickSplashMenu(object sender, EventArgs e)
        {
            SelectControl(splashControl);
        }

        private void onClickSituationsMenu(object sender, EventArgs e)
        {
            SelectControl(situationControl);
        }

        private void onClickHome(object sender, EventArgs e)
        {
            SelectControl(splashControl);
        }

        private void onClickNewUser(object sender, EventArgs e)
        {
            SelectControl(newUserControl);
        }

        private void onClickLoadUser(object sender, EventArgs e)
        {
            loadUserControl.RefreshData();
            SelectControl(loadUserControl);
        }

        /* Events */
        private void onSizeChanged(object sender, EventArgs e)
        {
            resizeContainer();
        }

        private void resizeContainer()
        {
            currentControl.Width = this.container.Width;
            currentControl.Height = this.container.Height;
        }

        private void onClickExit(object sender, EventArgs e) // FIXME : Bien vider les ressources
        {
            this.Dispose();
            Application.Exit();
        }

        private void onClickGlossary(object sender, EventArgs e)
        {
            SelectControl(glossaryControl);
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // TODO
        {
            NotifySaving();
        }

        public void NotifySaving()
        {
            toolStripButtonRefresh.Text = "Dernière sauvegarde : " + DateTime.Now.ToLongTimeString();
        }

        public void InvertSaisieState()
        {
            buttonSaisie.Enabled = !buttonSaisie.Enabled;
        }

        private void onClickSaisie(object sender, EventArgs e)
        {
            if (situationControl == null) return;
            SelectControl(situationControl);
        }
    }
}
