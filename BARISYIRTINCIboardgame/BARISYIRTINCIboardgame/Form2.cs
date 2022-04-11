using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARISYIRTINCIboardgame
{
    public partial class Form2 : Form
    {
        AboutScreen aboutScreen = new AboutScreen();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutScreen.Show();
        }
    }
}
