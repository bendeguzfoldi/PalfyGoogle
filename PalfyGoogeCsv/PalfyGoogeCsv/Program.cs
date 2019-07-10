using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter("users.csv", false, Encoding.UTF8);
            string[] a_nevek = File.ReadAllLines("9a.txt");
            string[] b_nevek = File.ReadAllLines("9b.txt");
            string[] c_nevek = File.ReadAllLines("9c.txt");
            string[] e_nevek = File.ReadAllLines("9e.txt");
            string[] f_nevek = File.ReadAllLines("9f.txt");
            string a_osztaly = "a19";
            string b_osztaly = "b19";
            string c_osztaly = "c19";
            string e_osztaly = "e19";
            string f_osztaly = "f19";
            string[] elsosor = File.ReadAllLines("elsosor.txt");
            string tmp;
            string[] temp;


            sw.WriteLine(elsosor[0]);
            //9a----------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < a_nevek.Length; i++)
            {
                tmp = a_nevek[i];

                sw.Write(nevgyar(tmp) + "," + a_osztaly + "." + emailgyar(tmp) + "," + "12345678,,/Homokozo/2019/" + a_osztaly + ",,,,,,,,,,,,,,,,,,True,");
                sw.WriteLine();

            }
            //9b----------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < b_nevek.Length; i++)
            {
                tmp = b_nevek[i];

                sw.Write(nevgyar(tmp) + "," + b_osztaly + "." + emailgyar(tmp) + "," + "12345678,,/Homokozo/2019/" + b_osztaly + ",,,,,,,,,,,,,,,,,,True,");
                sw.WriteLine();

            }
            //9c----------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < c_nevek.Length; i++)
            {
                tmp = c_nevek[i];

                sw.Write(nevgyar(tmp) + "," + c_osztaly + "." + emailgyar(tmp) + "," + "12345678,,/Homokozo/2019/" + c_osztaly + ",,,,,,,,,,,,,,,,,,True,");
                sw.WriteLine();

            }
            //9e----------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < e_nevek.Length; i++)
            {
                tmp = e_nevek[i];

                sw.Write(nevgyar(tmp) + "," + e_osztaly + "." + emailgyar(tmp) + "," + "12345678,,/Homokozo/2019/" + e_osztaly + ",,,,,,,,,,,,,,,,,,True,");
                sw.WriteLine();

            }
            //9f----------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < f_nevek.Length; i++)
            {
                tmp = f_nevek[i];

                sw.Write(nevgyar(tmp) + "," + f_osztaly + "." + emailgyar(tmp) + "," + "12345678,,/Homokozo/2019/" + f_osztaly + ",,,,,,,,,,,,,,,,,,True,");
                sw.WriteLine();

            }
            sw.Close();
            Console.WriteLine("GG");
            Console.ReadLine();
        }
        static string nevgyar(string nev)
        {
            int seged;
            string ret = "";
            string[] temp = nev.Split(' ');
            seged = temp.Length;
            if (seged == 3)
            {
                ret += temp[seged - 2];
                ret += ' ';
                ret += temp[seged - 1];
                ret += ",";
                ret += temp[0];

            }
            else
            {
                ret += temp[seged - 1];
                ret += ",";
                ret += temp[0];

            }
            return ret;
        }
        static string emailgyar(string nev)
        {
            string ret = "";
            string name = nev.ToLower();
            for (int i = 0; i < name.Length; i++)
            {
                char tmp = name[i];
                switch (tmp)
                {
                    case 'á':
                        ret += 'a';
                        break;
                    case 'é':
                        ret += 'e';
                        break;
                    case 'í':
                        ret += 'i';
                        break;
                    case 'ó':
                        ret += 'o';
                        break;
                    case 'ö':
                        ret += 'o';
                        break;
                    case 'ő':
                        ret += 'o';
                        break;
                    case 'ú':
                        ret += 'u';
                        break;
                    case 'ü':
                        ret += 'u';
                        break;
                    case 'ű':
                        ret += 'u';
                        break;
                    case ' ':
                        ret += '.';
                        break;
                    default:
                        ret += tmp;
                        break;
                }
            }
            ret += "@palfy-vizugyi.hu";
            return ret;
        }

    }
}
