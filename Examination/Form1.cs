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

        //Read file funtion
        string ReadFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            string str;
            string result="";
            str = sr.ReadLine();
            while(str != null)
            {
                result+= str +'\n';
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
                result += "Question "+i+" : "+str + '\n';
                str = sr.ReadLine();
                i++;
            }
            sr.Close();
            return result;
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            string str;
            str=ReadFile(@"D:\code\CSharp\Buoi5\ReadWriteFile\Buổi 5\TracNghiem_01.txt");
            //QuestionDisplay.Text = str;
            int index = str.IndexOf("A");
            //str = ReadFileAnswer(@"D:\code\CSharp\Buoi5\ReadWriteFile\Buổi 5\DapAn_01.txt");
            //AnswerDisplay.Text = str;

            //USE SPLIT TO SPLIT STRING
            char[] delimiterChars = { '\n', '\t', 'A', 'B', 'C','D' };
            string[] splittedContent = str.Split(delimiterChars);

            //foreach (var word in splittedContent)
            //{
            //    QuestionDisplay.Text += word +'\n';
            //}
            //for(int i = 0; i < 3; i++)
            //{
            //    QuestionDisplay.Text += splittedContent[i];

            //}
            splittedContent = splittedContent.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            //Console.WriteLine(splittedContent[75]);
            for (int i = 0; i < 50; i++)
            {
                dt.Rows.Add(0, 0, 0, 0, 0, 0, 0);
            }
            int indexOfTable = 0;
            for (int i = 0; i < 250; i = i + 5)
            {
                dt.Rows[indexOfTable]["Question"] = splittedContent[i];
                dt.Rows[indexOfTable]["A"] = splittedContent[i + 1];
                dt.Rows[indexOfTable]["B"] = splittedContent[i + 2];
                dt.Rows[indexOfTable]["C"] = splittedContent[i + 3];
                dt.Rows[indexOfTable]["D"] = splittedContent[i + 4];
                indexOfTable++;
            }
            //Question.Text = (string)dt.Rows[0]["Question"];
            Question.Text = dt.Rows[10]["Question"].ToString();
            A.Text = A.Name + dt.Rows[0]["A"].ToString();
        }

        private void Import_Click(object sender, EventArgs e)
        {

        }
    }
}
