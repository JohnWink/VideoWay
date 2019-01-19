using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoWay
{
    public partial class Biggerview : Form
    {
        public string link;
        public Biggerview(String video)
        {
            link = video;
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Biggerview_Load(object sender, EventArgs e)
        {
            //add the link from the list from the previous form
            webBrowser1.Navigate(link);
        }
    }
}
