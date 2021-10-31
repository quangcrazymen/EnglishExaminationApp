using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Form activeForm;

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panelPane.Controls.Add(childForm);
            this.panelPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void YourCart_MouseEnter(object sender, EventArgs e)
        {
            YourCart.BackColor = Color.Blue;
        }

        private void YourCart_MouseLeave(object sender, EventArgs e)
        {
            YourCart.BackColor = Color.DodgerBlue;
        }

        private void TabletSec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowProducts(), sender);
        }

        private void YourCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cart(), sender);
        }
    }
}
