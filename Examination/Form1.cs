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
        int currentQuestion = 1;
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

        void toQuestion(int currentQuestion)
        {
            int i = currentQuestion - 1;
            if (currentQuestion ==1) 
            {
                BackBtn.Visible = false;
            }
            else if (currentQuestion == 49)
            {
                NextBtn.Visible = false;
            }
            if(currentQuestion != 1)
            {
                BackBtn.Visible = true;
            }
            else if (currentQuestion != 49)
            {
                NextBtn.Visible = true;
            }
            Question.Text = dt.Rows[i]["Question"].ToString();
            A.Text = A.Name + dt.Rows[i]["A"].ToString();
            B.Text = B.Name + dt.Rows[i]["B"].ToString();
            C.Text = C.Name + dt.Rows[i]["C"].ToString();
            D.Text = D.Name + dt.Rows[i]["D"].ToString();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            string str;
            string key;
            str=ReadFile(@"D:\code\CSharp\Buoi5\ReadWriteFile\Buổi 5\TracNghiem_01.txt");
            key=ReadFile(@"D:\code\CSharp\Buoi5\ReadWriteFile\Buổi 5\DapAn_01.txt");
            //int index = str.IndexOf("A")

            //USE SPLIT TO SPLIT STRING
            char[] delimiterChars = { '\n', '\t', 'A', 'B', 'C','D' };
            string[] splittedContent = str.Split(delimiterChars);
            string[] KeyAnswer = key.Split('\n');
            splittedContent = splittedContent.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            //Add Question and answer into DataTable
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
            //
            toQuestion(1);
            //Adding Key to data table
            for (int i = 0; i < 50; i++)
            {
                dt.Rows[i]["Solution"] = KeyAnswer[i];
            }
            

        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2(), sender);
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            toQuestion(currentQuestion);
            currentQuestion -= 1;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            toQuestion(currentQuestion);
            currentQuestion += 1;
        }

        private void A_CheckedChanged(object sender, EventArgs e)
        {
            dt.Rows[currentQuestion]["UrAnswer"] = 'A';
        }

        private void B_CheckedChanged(object sender, EventArgs e)
        {
            dt.Rows[currentQuestion]["UrAnswer"] = 'B';
        }

        private void C_CheckedChanged(object sender, EventArgs e)
        {
            dt.Rows[currentQuestion]["UrAnswer"] = 'C';
        }

        private void D_CheckedChanged(object sender, EventArgs e)
        {
            dt.Rows[currentQuestion]["UrAnswer"] = 'D';
        }

        void AddAnswer(int currentQuestion)
        {
            int i = currentQuestion - 1;
            string labelQ = 'Q' + currentQuestion.ToString();
            if(dt.Rows[i]["UrAnswer"].ToString()== dt.Rows[i]["Question"].ToString())
            {
                ResultPanel.Items.Add(labelQ, 1);
                ResultPanel.LargeImageList = imageList1;
                ResultPanel.View = View.LargeIcon;
            }
            else
            {
                ResultPanel.Items.Add(labelQ, 0);
                ResultPanel.LargeImageList = imageList1;
                ResultPanel.View = View.LargeIcon;
            }

        }

        private void ResultBoard_Click(object sender, EventArgs e)
        {
            int i = 0;
            while ((int)dt.Rows[i]["UrAnswer"] != 0){
                AddAnswer(i+1);
            }
        }
    }
}
