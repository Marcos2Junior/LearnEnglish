using LearnEnglish.Desktop.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class FrmInfo : BaseForm
    {
        public FrmInfo()
        {
            InitializeComponent();
            Text = "Informations";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.marcosjunior.me") { UseShellExecute = true });
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            pictureBox1.RoundBorder();
        }

        private void btn_hotkey_Click(object sender, EventArgs e)
        {
            new FrmHotKey().ShowDialog();
        }
    }

}
