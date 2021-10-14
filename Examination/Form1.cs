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

namespace Examination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakeTable()
        {
            DataTable table = new DataTable("Exam");
            DataColumn column;

        }

        void ReadFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            string str;
            str = sr.ReadLine();
            while(str != null)
            {
                QuestionDisplay.Text += str +'\n';
                str = sr.ReadLine();
            }
            sr.Close();
        }
        private void Test_Click(object sender, EventArgs e)
        {
            
            ReadFile(@"D:\code\CSharp\Buoi5\ReadWriteFile\Buổi 5\TracNghiem_01.txt");
        }
    }
}
