using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public partial class Form1 : Form
    {
        Player Smith;
        Player Trinity;
        Player Neo;
        Random Dog;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Smith = new Player();
            Trinity = new Player();
            Neo = new Player();

            Smith.Name = "Smith";
            Trinity.Name = "Trinity";
            Neo.Name = "Neo";

            Smith.Money = 50;
            Trinity.Money = 50;
            Neo.Money = 50;

            Smith.HasBet = false;
            Trinity.HasBet = false;
            Neo.HasBet = false;

            lblSmith.Text = Convert.ToString(Smith.Money);
            lblTrinity.Text = Convert.ToString(Trinity.Money);
            lblNeo.Text = Convert.ToString(Neo.Money);

            Dog = new Random();

            btnRace.Enabled = false;
            btnBet.Enabled = false;
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            btnRace.Enabled = true;
            
            if (rbSmith.Checked)
            {
                Smith.Bet = Convert.ToDouble(NudBet.Value);
                Smith.Dog = Convert.ToInt16(NudDog.Value);
                txtSmith.Text = Smith.printmessage();
                lblSmith.Text = Convert.ToString(Smith.Money - Smith.Bet);
                Smith.Money = Smith.Money - Smith.Bet;
                rbSmith.Enabled = false;
                rbSmith.Checked = false;
                Smith.HasBet = true;
            }

            if (rbTrinity.Checked)
            {
                Trinity.Bet = Convert.ToDouble(NudBet.Value);
                Trinity.Dog = Convert.ToInt16(NudDog.Value);
                txtTrinity.Text = Trinity.printmessage();
                lblTrinity.Text = Convert.ToString(Trinity.Money - Trinity.Bet);
                Trinity.Money = Trinity.Money - Trinity.Bet;
                rbTrinity.Enabled = false;
                rbTrinity.Checked = false;
                Trinity.HasBet = true;
            }

            if (rbNeo.Checked)
            {
                Neo.Bet = Convert.ToDouble(NudBet.Value);
                Neo.Dog = Convert.ToInt16(NudDog.Value);
                txtNeo.Text = Neo.printmessage();
                lblNeo.Text = Convert.ToString(Neo.Money - Neo.Bet);
                Neo.Money = Neo.Money - Neo.Bet;
                rbNeo.Enabled = false;
                rbNeo.Checked = false;
                Neo.HasBet = true;
            }   
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            int winningdog = Dog.Next(1, 5);

            MessageBox.Show("Dog No." + winningdog);

            btnRace.Enabled = false;
            
            //Smith
            if (Smith.Dog == winningdog  && Smith.HasBet)
            {
                Smith.Win();
                txtSmith.Text = Smith.printBalance();
                lblSmith.Text = Convert.ToString(Smith.Money);
                rbSmith.Enabled = true;
            }
            else if (Smith.Dog != winningdog && Smith.HasBet)
            {
                Smith.Lose();
                txtSmith.Text = Smith.printBalance();
                lblSmith.Text = Convert.ToString(Smith.Money);
                rbSmith.Enabled = true;
            }

            //Trinity
            if (Trinity.Dog == winningdog && Trinity.HasBet)
            {
                Trinity.Win();
                txtTrinity.Text = Trinity.printBalance();
                lblTrinity.Text = Convert.ToString(Trinity.Money);
                rbTrinity.Enabled = true;
            }
            else if (Trinity.Dog != winningdog && Trinity.HasBet)
            {
                Trinity.Lose();
                txtTrinity.Text = Trinity.printBalance();
                lblTrinity.Text = Convert.ToString(Trinity.Money);
                rbTrinity.Enabled = true;
            }

            //Neo
            if (Neo.Dog == winningdog && Neo.HasBet)
            {
                Neo.Win();
                txtNeo.Text = Neo.printBalance();
                lblNeo.Text = Convert.ToString(Neo.Money);
                rbNeo.Enabled = true;
            }

            else if (Neo.Dog != winningdog && Neo.HasBet)
            {
                Neo.Lose();
                txtNeo.Text = Neo.printBalance();
                lblNeo.Text = Convert.ToString(Neo.Money);
                rbNeo.Enabled = true;
            }

            Smith.HasBet = false;
            Trinity.HasBet = false;
            Neo.HasBet = false;

            Smith.Dog = 0;
            Trinity.Dog = 0;
            Neo.Dog = 0;

            //Radio Button Checks
            if (rbSmith.Checked)
            {
                NudBet.Maximum = Convert.ToDecimal(Smith.Money);
            }

            if (rbTrinity.Checked)
            {
                NudBet.Maximum = Convert.ToDecimal(Trinity.Money);
            }

            if (rbNeo.Checked)
            {
                NudBet.Maximum = Convert.ToDecimal(Neo.Money);
            }

            if (Smith.Money <= 4)
                {
                    rbSmith.Enabled = false;
                    txtSmith.Text = Smith.Busted();
                }

            if (Trinity.Money <= 4)
                {
                    rbTrinity.Enabled = false;
                    txtTrinity.Text = Trinity.Busted();
                }

            if (Neo.Money <= 4)
                {
                    rbNeo.Enabled = false;
                    txtNeo.Text = Neo.Busted();
                }

            btnBet.Enabled = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void rbSmith_CheckedChanged(object sender, EventArgs e)
        {
            NudBet.Minimum = 5;

            if (Smith.Money <= 15)
            {
                NudBet.Maximum = Convert.ToDecimal(Smith.Money);
            }
            if (Smith.Money > 15)
            {
                NudBet.Maximum = 15;
            }
            if (Smith.Money <= 4)
            {
                rbSmith.Enabled = false;
            }

            btnBet.Enabled = true;

        }

        private void rbTrinity_CheckedChanged(object sender, EventArgs e)
        {
            NudBet.Minimum = 5;

            if (Trinity.Money <= 15)
            {
                NudBet.Maximum = Convert.ToDecimal(Trinity.Money);
            }

            if (Trinity.Money > 15)
            {
                NudBet.Maximum = 15;
            }

            if (Trinity.Money <= 4)
            {
                rbTrinity.Enabled = false;
            }

            btnBet.Enabled = true;
        }

        private void rbNeo_CheckedChanged(object sender, EventArgs e)
        {
            NudBet.Minimum = 5;

            if (Neo.Money <= 15)
            {
                NudBet.Maximum = Convert.ToDecimal(Neo.Money);
            }

            if (Neo.Money > 15)
            {
                NudBet.Maximum = 15;
            }

            if (Neo.Money <= 4)
            {
                rbNeo.Enabled = false;
            }

            btnBet.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
