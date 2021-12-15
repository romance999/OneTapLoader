using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneTapLoaderTemplate.UI
{
    public partial class LoaderFrm : Form
    {
        public LoaderFrm()
        {
            InitializeComponent();
        }

        private void LoaderFrm_Load(object sender, EventArgs e)
        {

        }

        private void rainbowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rainbowCheckBox.Checked)
            {
                //reset the panel color//
                topPnl.ForeColor = Color.FromArgb(227, 176, 98);
            }
            else
            {

            }
        }
    }
}
