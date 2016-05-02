using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TunablesEditorCode
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.nextgenupdate.com/forums/gta-5-mod-tools/787824-all-updates-tunables-editor-blus-bles.html");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("soon");
        }
    }
}
