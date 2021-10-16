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
    public partial class ImportUI : Form
    {
        //Read file funtion
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

        string ReadFileAnswer(string file)
        {
            StreamReader sr = new StreamReader(file);
            string str;
            string result = "";
            str = sr.ReadLine();
            int i = 1;
            while (str != null)
            {
                result += "Question " + i + " : " + str + '\n';
                str = sr.ReadLine();
                i++;
            }
            sr.Close();
            return result;
        }
        public ImportUI()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string str;
            str = ReadFile(@"D:\code\CSharp\Buoi5\ReadWriteFile\Buổi 5\TracNghiem_01.txt");
            QuestionDisplay.Text = str;
            
        }

        private void Key_Click(object sender, EventArgs e)
        {
            string str;
            str = ReadFileAnswer(@"D:\code\CSharp\Buoi5\ReadWriteFile\Buổi 5\DapAn_01.txt");
            AnswerDisplay.Text = str;
        }
    }
}
