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
    public partial class Mobile : Form
    {
        public Mobile()
        {
            InitializeComponent();
        }
        private void populate()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            //Load imgs from file
            String[] paths = { };
            paths = Directory.GetFiles("D:/code/CSharp/Buoi5/ReadWriteFile/TH02Image/phoneProducts");

            try
            {
                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            listView1.SmallImageList = imgs;

            string content = ReadFile("D:/code/CSharp/Buoi5/ReadWriteFile/PhoneList.txt");
            string[] product = content.Split('\n');

            for (int i = 1; i < product.Length - 1; i++)
            {
                listView1.Items.Add(ShowTitle(product[i]), i - 1);
            }

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

        void WriteFile(string file, string str)
        {
            string[] Informations = str.Split('\n');
            Informations = Informations.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            try
            {

                //Use File.AppendText
                File.AppendAllText(file, str);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        string ShowTitle(string str)
        {
            string[] Informations = str.Split('\t');
            str = Informations[0] + '\n'
                + "Price: $" + Informations[1] + '\n'
                + "Rating: " + Informations[2] + '\n'
                + "Shipping Date: " + Informations[3] + " days" + '\n'
                + "Guarentee: " + Informations[4] + " years" + '\n';
            return str;
        }

        private void Mobile_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Products", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            populate();
        }
        public string _textBox1
        {
            get { return TextBox1.Text; }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String selected = listView1.SelectedItems[0].SubItems[0].Text;
            //MessageBox.Show(selected);
            //OpenChildForm(new DetailPage(), sender);
            //Test.Text = ExtractPrice(listView1.SelectedItems[0].Text).ToString();
            TextBox1.Text = selected;
            //WriteFile("D:/code/CSharp/Buoi5/ReadWriteFile/CartData.txt", selected);
            DetailPage frm = new DetailPage();
            frm._textBox = _textBox1;
            frm.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
