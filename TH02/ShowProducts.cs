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
    public partial class ShowProducts : Form
    {
        
        public ShowProducts()
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

        void WriteFile(string file,string str)
        {
            string[] Informations = str.Split('\n');
            Informations = Informations.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            try
            {
                //streamWrite override all the content in txt file


                //StreamWriter sw = new StreamWriter(file);
                //foreach (string info in Informations)
                //{
                //    sw.Write(info);
                //}
                //sw.Write('\n');
                //sw.Close();

                //Use File.AppendText
                File.AppendAllText(file, str);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
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

        float ExtractPrice(string str)
        {
            int start = str.IndexOf('$')+1;
            float Price = float.Parse(str.Substring(start,6));
            return Price;
        }
        //Convert element in a array to title
        string ShowTitle(string str)
        {
            string[] Informations = str.Split('\t');
            str = Informations[0] + '\n'
                + "Price: $" + Informations[1] + '\n'
                + "Rating: " + Informations[2] + '\n'
                + "Shipping Date: " + Informations[3] + " days" + '\n'
                + "Guarentee: " + Informations[4] + " years"+'\n';
            return str;
        }

        private void populate()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            //Load imgs from file
            String[] paths = { };
            paths = Directory.GetFiles("D:/code/CSharp/Buoi5/ReadWriteFile/TH02Image/LaptopProducts");

            try
            {
                foreach(String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            listView1.SmallImageList = imgs;
            
            string content = ReadFile("D:/code/CSharp/Buoi5/ReadWriteFile/ListOfItems.txt");
            string[] product = content.Split('\n');

            for(int i = 1; i < product.Length-1 ; i++)
            {
                listView1.Items.Add(ShowTitle(product[i]), i-1);
            }
            

        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            //LV properties
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
