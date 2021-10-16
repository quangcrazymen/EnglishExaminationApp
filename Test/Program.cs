using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test
{
    class Program
    {
        public DataTable dt = new DataTable();
        public Program()
        {
            dt.Columns.Add("Question");
            dt.Columns.Add("A");
            dt.Columns.Add("B");
            dt.Columns.Add("C");
            dt.Columns.Add("D");
            dt.Columns.Add("UrAnswer");
            dt.Columns.Add("Solution");
        }
        public string ReadFile(string file)
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
        static void Main(string[] args)
        {
            Program program = new Program();
            
            
            
            Console.WriteLine("Hello World!");
            //dt.Rows.Add("asdasdasd", 1, 2, 3, 4, "dasdasd", "sadsad");
            //dt.Rows.Add("asdasdasd", 2, 4, 6, 8, "dasdasd", "sadsad");
            //Console.WriteLine(dt.Rows[1]["B"]);
            string str;
            str = program.ReadFile(@"D:\code\CSharp\Buoi5\ReadWriteFile\Buổi 5\TracNghiem_01.txt");
            //Console.WriteLine(str);
            char[] delimiterChars = { '\n', '\t', 'A', 'B', 'C', 'D' };
            string[] splittedContent = str.Split(delimiterChars);
            //foreach(var word in splittedContent)
            //{
            //    Console.WriteLine(word);

            //}

            //This line to remove "" or null from Array
            

            //string[] content = testStr.Split(',');
            //Console.WriteLine(content[5]);
            Console.WriteLine(splittedContent.Length);
            for(int i = 0; i < 50; i++)
            {
                program.dt.Rows.Add(0, 0, 0, 0, 0, 0, 0);
            }
            int index = 0;
            for(int i = 0; i < 250; i=i+5)
            {
                program.dt.Rows[index]["Question"] = splittedContent[i];
                program.dt.Rows[index]["A"] = splittedContent[i+1];
                program.dt.Rows[index]["B"] = splittedContent[i+2];
                program.dt.Rows[index]["C"] = splittedContent[i+3];
                program.dt.Rows[index]["D"] = splittedContent[i+4];
                index++;
            }
            Console.WriteLine(program.dt.Rows[45]["Question"]);
        }
    }
}
