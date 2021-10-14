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
    public partial class Exam : Form
    {
        DataTable dt = new DataTable();

        public Exam()
        {
            InitializeComponent();
            dt.Columns.Add("Question");
            dt.Columns.Add("A");
            dt.Columns.Add("B");
            dt.Columns.Add("C");
            dt.Columns.Add("D");
            dt.Columns.Add("UrAnswer");
            dt.Columns.Add("Solution");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
