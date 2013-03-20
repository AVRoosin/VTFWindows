using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello XML!!!");
            var xdoc=new XmlDocument();
            xdoc.Load("dict.xdxf");
            XmlNodeList words =xdoc.GetElementsByTagName("ar");
            for (int numbers = 0; numbers < 682; numbers++)
            {
                String str = words[numbers].InnerText;
                int j = 0;
                int i;
                int k = 0;
                bool flag = false;
                Char n = '\n';
                for (i = 0; i < str.Length - 1; i++)
                {
                    if (str[i].CompareTo(n) == 0)
                    {
                        if (flag == false)
                        {
                            k = i;
                            flag = true;
                        }
                        else
                        {
                            j = i;
                        }
                    }
                }
                String word = str.Substring(k + 1, j-1);
                String translation = str.Substring(j+1);
                Console.Write(word);
                Console.Write("=");
                Console.WriteLine(translation);
                Console.Read();
            }
        }
    }
}
