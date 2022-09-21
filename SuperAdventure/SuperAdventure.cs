using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private readonly Player _player = new Player();
        public SuperAdventure()
        {
            InitializeComponent();

            UpdateUi(_player);
        }


        public void UpdateUi(Player p) {
            if (p.CurrentHitPoints < (p.TotalHitPoints / 25))
            {
                lblHitPoints.ForeColor = Color.Red;
            }
            else
            {
                lblHitPoints.ForeColor = DefaultForeColor;
            }

            lblHitPoints.Text = p.CurrentHitPoints.ToString();
            lblGold.Text = p.Gold.ToString();
            lblExp.Text = p.Exp.ToString();
            lblLevel.Text = p.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {
            string[] labelNames = new string[4] { "Hit Points", "Gold", "Experience", "Level" };
            label1.Text = labelNames[0];
            label2.Text = labelNames[1];
            label3.Text = labelNames[2];
            label4.Text = labelNames[3];
        }


    }
}
