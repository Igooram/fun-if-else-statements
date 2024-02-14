using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_fun_if_else_statements
{
    public partial class FunWith : Form
    {
        public FunWith()
        {
            InitializeComponent();
        }

        private void chkCor_CheckedChanged(object sender, EventArgs e)
        {
            chkCor.Checked = true;
        }

        private void lblchenge_Click(object sender, EventArgs e)
        {
            lblchenge.BackColor = Color.Red;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (chkCor.Checked == true)
            {
                if (lblchenge.BackColor == Color.Red)
                {
                    lblchenge.BackColor = Color.Blue; 
                }

                else if (lblchenge.BackColor == Color.Blue)
                {
                    lblchenge.BackColor = Color.Black;
                }

                else
                {
                    lblchenge.BackColor = Color.Red;
                }

                

                
            }

            else
            {
                MessageBox.Show("the box is not checked");
            }
        }

        
    }
}
