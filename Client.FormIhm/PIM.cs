using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Sql;

namespace Client.FormIhm
{
    public partial class PIM : Form
    {

        private PimState state = PimState.Deconnecter;
        private PimState State
        {
            get { return this.state; }
            set { OnPimStateChanged(value); }
        }

        public event PimStateEventHandler PimStateChanged;
        public delegate void PimStateEventHandler(object sender, PimState state);

        private void OnPimStateChanged(PimState newState)
        {
            if (newState != this.state)
            {
                this.state = newState;
                if (this.PimStateChanged != null)
                {
                    PimStateChanged(this, this.state);
                }
            }
        }


        public PIM()
        {
            InitializeComponent();
            this.PimStateChanged += PIM_PimStateChanged;
        }

        void PIM_PimStateChanged(object sender, PimState state)
        {
            MessageBox.Show("StateChanged");
        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var bagage2 = MyAirport.Pim.Model.Factory.Model.GetBagage(this.textBox1.Text);
                this.tbAlpha.Text = bagage2.LigneAlpha.ToString();
                this.tbAlpha.Enabled = false;
                this.tbClasseBag.Text = bagage2.ClasseBagage.ToString();
                this.tbClasseBag.Enabled = false;
                this.tbCompagnie.Text = bagage2.Compagnie;
                this.tbCompagnie.Enabled = false;
                this.tbItineraire.Text = bagage2.Itineraire;
                this.tbItineraire.Enabled = false;
                this.tbJourExploitation.Text = bagage2.DateCreation.ToString();
                this.tbJourExploitation.Enabled = false;
                this.tbLigne.Text = bagage2.Ligne.ToString();
                this.tbLigne.Enabled = false;
                this.cbContinuation.Checked = bagage2.Continuation;
                this.cbContinuation.Enabled = false;
                this.cbRush.Checked = bagage2.Rush;
                this.cbRush.Enabled = false;
            }
            catch (ApplicationException appEx)
            {
                this.tbAlpha.Text = this.tbClasseBag.Text = this.tbCompagnie.Text = this.tbItineraire.Text = this.tbJourExploitation.Text = this.tbLigne.Text = "";
                this.cbContinuation.Checked = this.cbRush.Checked = false;
                this.tbAlpha.Enabled = this.tbClasseBag.Enabled = this.tbCompagnie.Enabled = this.tbItineraire.Enabled = this.tbJourExploitation.Enabled =
                this.tbLigne.Enabled = this.cbContinuation.Enabled = this.cbRush.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Une erreur s’est produite dans le traitement de votre demande.\nMerci de bien vouloir re tester ultérieurement ou de contacter votre administrateur.", "Erreur dans le traitement de votre demande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void réinitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
