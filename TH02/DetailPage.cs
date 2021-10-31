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
    public partial class DetailPage : Form
    {
        public DetailPage()
        {
            InitializeComponent();
        }
        public string _textBox
        {
            set { productInfo.Text = value; }
        }
        void WriteFile(string file, string str)
        {
            str = str.Substring(0,str.Length-1);
            str = str + '\n' + "Qty&" + Quantity.Value.ToString()+'\n';
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
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            WriteFile("D:/code/CSharp/Buoi5/ReadWriteFile/CartData.txt", productInfo.Text);
            this.Close();
        }

    }
}
