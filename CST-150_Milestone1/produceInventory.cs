using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone1
{
    public partial class produceInvFrm : Form
    {
        public produceInvFrm()
        {
            InitializeComponent();
        }

        private void addItemTxt_TextChanged(object sender, EventArgs e)
        {
            //addItemTxt.Text = prodInvLstBx.Text;
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            prodInvLstBx.Items.Add(addItemTxt.Text);
            //Code inspired by https://www.youtube.com/watch?v=tqH-pZd2au0 and modified for my needs.
        }

        private void produceInvFrm_Load(object sender, EventArgs e)
        {

        }

        private void removeItmBtn_Click(object sender, EventArgs e)
        {
            if(prodInvLstBx.SelectedIndex != -1)
            {
                prodInvLstBx.Items.RemoveAt(prodInvLstBx.SelectedIndex);
            }
        }
    }
}
