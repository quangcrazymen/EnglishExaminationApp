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
namespace ReadWriteFile
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFileBtn_Click(object sender, EventArgs e)
        {
            string path = filePath.Text + fileName.Text;
            StreamReader sr = new StreamReader(path);
            string str;
            while((str=sr.ReadLine()) != null)
            {
                Display.Text = str;
            }
            sr.Close();
        }
    }
}
