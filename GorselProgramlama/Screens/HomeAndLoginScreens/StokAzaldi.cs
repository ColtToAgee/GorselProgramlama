using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama.Screens.HomeAndLoginScreens
{
    public partial class StokAzaldi : Form
    {
        public string AzalanUrun;
        public StokAzaldi()
        {
            InitializeComponent();
        }

        private void StokAzaldi_Load(object sender, EventArgs e)
        {
            label2.Text = AzalanUrun;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
