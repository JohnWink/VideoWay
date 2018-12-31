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
    public partial class VideoWatchForm : Form
    {
        public VideoWatchForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string from the comment box  and then add to the listbox 2 has an item
            // it will need to put the users name + " " +date  + ": "+ ritchtextbox1.text;
            string comment = richTextBox1.Text;
            listBox2.Items.Add(comment);
            //clear comment box
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //first it will seach the position of the selected item
            int pos = listBox2.SelectedIndex;
            // we make a string of the comment we intend to reply
            string commentre = listBox2.SelectedItem.ToString();
            //after we will search if theres space chars on the sellected item, if so we will add those spacces, if not there no spacess added
            string space = "";
            int count = 0;
            while (commentre[count] == ' ')
            {
                count++;
                space = space + " ";
            }

            //on the reply it it will add more spaces to make a stair effect
            // needs: space + "       " + user + " " + date + ": " + ritchtextbox1.text;
            string reply = space + "      " + richTextBox1.Text;
            //it will add the new line (reply after the commnet)
            listBox2.Items.Insert(pos + 1, reply);
            //clear comment box
            richTextBox1.Text = "";
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            // if an item is sellected then the reply button becomes enabled
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //when pressed and if  the item is sellect from list box 1, then this button becomes enabled, and it will open
            // a new form whit the link info and open a bigger webpage so the user can see it in a bigger view
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
