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
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            listView1.SmallImageList = imgs;

            string content = ReadFile("D:/code/CSharp/Buoi5/ReadWriteFile/CartData.txt");
            string[] product = content.Split('\n');
            product = product.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            string str;
            int a = 0;
            for (int i = 0; i< product.Length; i = i + 6)
            {

                str = product[i] + '\n' +
                    product[i + 1] + '\n' +
                    product[i + 2] + '\n' +
                    product[i + 3] + '\n' +
                    product[i + 4] + '\n' +
                    product[i + 5] + '\n';
                listView1.Items.Add(str, a);
                a++;
            }
        }

        float ExtractPrice(string str)
        {
            int start = str.IndexOf('$') + 1;
            float Price = float.Parse(str.Substring(start, 6));
            return Price;
        }

       int ExtractQuantity(string str)
        {
            int start = str.IndexOf('&') + 1;
            int Quantity = int.Parse(str.Substring(start, 1));
            return Quantity;
        }

        private void YourCart_Click(object sender, EventArgs e)
        {
            populate();
            totalPrice = CalculatePrice();
            Total.Text = '$' + totalPrice.ToString();

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Products", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            String selected = listView1.SelectedItems[0].SubItems[0].Text;
            //MessageBox.Show(selected);
            int index = selected.IndexOf('&')+1;
            Quantity.Value =selected[index]-'0';
        }


        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            String selected = listView1.SelectedItems[0].SubItems[0].Text;
            int Length = selected.Length;
            //if(listView1.SelectedItems[0].SubItems[0].Text.Length)
            selected.Substring(0, Length - 2);
            listView1.SelectedItems[0].SubItems[0].Text = selected;
            listView1.SelectedItems[0].SubItems[0].Text = listView1.SelectedItems[0].SubItems[0].Text.Remove(Length - 2, 1).Insert(Length - 2, Quantity.Value.ToString());

            Total.Text ='$'+ CalculatePrice().ToString();
        }

        float totalPrice;
        float CalculatePrice()
        {
            float totalPrice = 0 ;

            foreach (ListViewItem Item in listView1.Items)
            {
                totalPrice += ExtractPrice(Item.Text) * ExtractQuantity(Item.Text);
            }

            return totalPrice;
            //totalPrice += ExtractPrice(listView1.Items[0].SubItems[0].Text) * ExtractQuantity(listView1.Items[0].SubItems[0].Text);
        }

        private void AcceptPayment_Click(object sender, EventArgs e)
        {
            this.Close();
            DateTime now = DateTime.Now;
            string content ="Date: "+now.ToString()+'\n'+ ReadFile("D:/code/CSharp/Buoi5/ReadWriteFile/CartData.txt")+"Total: "+totalPrice.ToString()+'\n'+"*************************************************"+'\n';
            File.AppendAllText("D:/code/CSharp/Buoi5/ReadWriteFile/History.txt", content);
            File.WriteAllText("D:/code/CSharp/Buoi5/ReadWriteFile/CartData.txt", String.Empty);
        }

        private void Normal_CheckedChanged(object sender, EventArgs e)
        {
            totalPrice = CalculatePrice() + 15;
            Total.Text = '$' + (totalPrice).ToString();
        }

        private void Express_CheckedChanged(object sender, EventArgs e)
        {
            totalPrice = CalculatePrice() + 30;
            Total.Text = '$' + (CalculatePrice() + 30).ToString();
        }

        private void Ten_Click(object sender, EventArgs e)
        {
            totalPrice = (totalPrice * 90)/100;
            Total.Text = '$' + totalPrice.ToString();
            Ten.Enabled = false;
        }

        private void Fifthteen_Click(object sender, EventArgs e)
        {
            totalPrice = (totalPrice * 85) / 100;
            Total.Text = '$' + totalPrice.ToString();
            Fifthteen.Enabled = false;
        }

        private void Twenty_Click(object sender, EventArgs e)
        {
            totalPrice = (totalPrice * 80) / 100;
            Total.Text = '$' + totalPrice.ToString();
            Twenty.Enabled = false;
        }

        private void CartClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
