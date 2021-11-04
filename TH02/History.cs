using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TH02
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        string ReadFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            string str;
            string result = "";
            str = sr.ReadLine();
            while (str != null)
            {
                result += str + '\n';
                str = sr.ReadLine();
            }
            sr.Close();
            return result;
        }

        private void History_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTimeTests.Text = now.ToString();
            purchasedHistory.Text = ReadFile(@"D:\code\CSharp\Buoi5\ReadWriteFile\History.txt");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            purchasedHistory.Text += @"Date: 11/4/2021 4:37:52 PM
Samsung Chromebook 4 11.6, Intel Celeron N4020
Price: $129.00
Rating: 4.0
Shipping Date: 4 days
Guarentee: 2 years
Qty&1
Total: 129
*************************************************"+'\n';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            purchasedHistory.Text+= @"Date: 11/4/2021 4:37:40 PM
Lenovo Ideapad Slim 7i Pro, 14.0
Price: $999.00
Rating: 3.5
Shipping Date: 2 days
Guarentee: 1 years
Qty&2
Total: 1998
*************************************************"+'\n';
        }
    }
    
}
