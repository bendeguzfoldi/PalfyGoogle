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
            string[] nevsor = File.ReadAllLines("nevsor.txt");
            string[] elsosor = File.ReadAllLines("elsosor.txt");
            string szervezeti_egyseg;
            Console.WriteLine("Add meg a szervezeti egység teljes elérési útját (kezdés évig):");
            szervezeti_egyseg = Console.ReadLine();
            Console.Clear();
            int counter = 0;
            string tmp="";
            string[] temp;
            string osztaly = "";
            sw.WriteLine(elsosor[0]);
            for (int i = 0; i < nevsor.Length; i++)
            {
                tmp = nevsor[i];
                switch (nevsor[i])
                {
                    case "a19":
                        osztaly = "a19";
                        counter = counter - 1;
                        break;
                    case "b19":
                        osztaly = "b19";
                        counter = counter - 1;
                        break;
                    case "c19":
                        osztaly = "c19";
                        counter = counter - 1;
                        break;
                    case "e19":
                        osztaly = "e19";
                        counter = counter - 1;
                        break;
                    case "f19":
                        osztaly = "f19";
                        counter = counter - 1;
                        break;
                    default:
                        sw.Write(nevgyar(tmp) + "," + osztaly + "." + emailgyar(tmp) + "," + "12345678,," + szervezeti_egyseg + "/" + osztaly + ",,,,,,,,,,,,,,,,,,True,");
                        sw.WriteLine();
                        break;
                        
                }
               
                counter++;
            }
            sw.Close();
            
            Console.WriteLine(counter + " darab felhasználó sikeresen létrehozva!");
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
