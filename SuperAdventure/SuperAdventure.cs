using System;
using System.Drawing;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private readonly Player _player = new Player(10, 10, 0, 1, 20 );
        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home","This is your house");
            
            UpdateUi(ref _player);
        }


        public void UpdateUi(ref Player p) {
            lblHitPoints.ForeColor = p.CurrentHitPoints < (p.MaximumHitPoints / 25) ? Color.Red : DefaultForeColor;

            lblHitPoints.Text = p.CurrentHitPoints.ToString();
            lblGold.Text = p.Gold.ToString();
            lblExp.Text = p.Exp.ToString();
            lblLevel.Text = p.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {
            var labelNames = new string[4] { "Hit Points", "Gold", "Experience", "Level" };
            
            // Looping through the labels and set their text to the corresponding value in the array.
            for (var i = 0; i < labelNames.Length; i++)
            {
                Controls["label" + (i + 1)].Text = labelNames[i];
            }
        }


    }
}
