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
    public partial class Cart : Form
    {
        public Cart()
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

        private void populate()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            //Load imgs from file
            String[] paths = { };
            paths = Directory.GetFiles("D:/code/CSharp/Buoi5/ReadWriteFile/TH02Image/LaptopProducts");

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

            string content = ReadFile("D:/code/CSharp/Buoi5/ReadWriteFile/CartData.txt");
            string[] product = content.Split('\n');
            product = product.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            string str;
            int a = 0;
            for (int i = 0; i< product.Length; i = i + 5)
            {
                
                str = product[i] + '\n'+
                    product[i+1] + '\n'+
                    product[i+2] + '\n'+
                    product[i+3] + '\n'+
                    product[i+4] + '\n';
                listView1.Items.Add(str, a);
                a++;
            }
        }

        private void YourCart_Click(object sender, EventArgs e)
        {
            populate();      
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Products", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
