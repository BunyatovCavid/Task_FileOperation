using System;
using System.IO;
using System.Threading.Tasks;

namespace Task_FillCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1-2
            /*
            // DirectoryInfo dr = Directory.CreateDirectory(@"C:\Users\User\Desktop\Task");
            // FileStream file = File.Create(@"C:\Users\User\Desktop\Task\");
            string path = @"C:\Users\User\Desktop\Task\evtapsirigi.txt";

            string filename = " ";
            foreach (var item in path)
            {
                if (item == '\\')
                {
                    filename = " ";
                    continue;
                }
                else if (item == '.')
                {
                    break;
                }

                filename += item;
            }

            // File.AppendAllText(path, "\n siz necesiz");

            string text = File.ReadAllText(path).Trim();

            //Console.WriteLine($"Sizin {filename}n-daki textiniz: " + text);
            int say = 0;
            char item0 = ' ';
            foreach (var item in text)
            {
                if (item == ' ')
                {
                    say++;
                }
                else if (item0 != ','&& item==' ')
                {
                    say++;
                }
                item0 = item;
            }
            Console.WriteLine($"Sizin{filename}n-da olan textinizin soz sayi: {++say}");

            Console.WriteLine($"Sizin{filename}n-da olan textinizin uzunlugu: {text.Length}");
            */
            #endregion
         //   Task3();
            #region Task4
            /*
            try
            {
                
                Console.WriteLine("Yaratmaq istediyiniz folderin adini girin");
                string foldername = Console.ReadLine();
                string path = @"C:\Users\User\Desktop\";
                Directory.CreateDirectory(path + foldername);
                 if (Directory.Exists(path + foldername))
                 {
                     Console.WriteLine();
                     DateTime dt = DateTime.Now;
                     Console.WriteLine($"{foldername} adli folderiniz {dt} tarixinde yaradildi");
                 }
                
                Console.WriteLine();
                Console.WriteLine("Yaratmaq istediyiniz text faylinin adini girin");
                string filename = Console.ReadLine();
                File.Create(path + foldername + @"\" + filename + ".txt");
                if (File.Exists(path + foldername + @"\" + filename + ".txt"))
                {
                    Console.WriteLine();
                    DateTime dt2 = DateTime.Now;
                    Console.WriteLine($"{filename} adli text fayliniz {dt2} tarixinde yaradildi");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            */
            #endregion
            //  MoveAllFiles();
        }
        public static void Task3()
        {

            //File.Create(@"C:\Users\User\Desktop\Task\File3.txt");
            string path = @"C:\Users\User\Desktop\Task\File1.txt";
            string path2 = @"C:\Users\User\Desktop\Task\File2.txt";
            string path3 = @"C:\Users\User\Desktop\Task\File3.txt";
            //  File.AppendAllText(path, "İlham Abbasov 239103ASD 1993");
            //  File.AppendAllText(path2, "NAme Surname 231998ADE 1992");
            //  File.AppendAllText(path3, "Teymur Mammadov 4785965DEF 1995");
            string file1 = File.ReadAllText(path);
            string file2 = File.ReadAllText(path2);
            string file3 = File.ReadAllText(path3);


            string file4n1 = "";
            string file4i1 = "";
            int say = 0;
            foreach (var item in file1)
            {
                if (item == ' ')
                {
                    say++;
                }
                if (say == 0)
                {
                    file4n1 += item;
                }
                else if (say == 2)
                {
                    file4i1 += item;
                }
                else if (say > 2)
                {
                    say = 0;
                    break;
                }
            }
            string file4n2 = "";
            string file4i2 = "";
            foreach (var item in file2)
            {
                if (item == ' ')
                {
                    say++;
                }
                if (say == 0)
                {
                    file4n2 += item;
                }
                else if (say == 2)
                {
                    file4i2 += item;
                }
                else if (say > 2)
                {
                    say = 0;
                    break;
                }
            }
            string file4n3 = "";
            string file4i3 = "";
            foreach (var item in file3)
            {
                if (item == ' ')
                {
                    say++;
                }
                if (say == 0)
                {
                    file4n3 += item;
                }
                else if (say == 2)
                {
                    file4i3 += item;
                }
                else if (say > 2)
                {
                    say = 0;
                    break;
                }
            }
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", file4n1, Environment.NewLine));
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", " ", Environment.NewLine));
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", file4i1, Environment.NewLine));
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", file4n2, Environment.NewLine));
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", " ", Environment.NewLine));
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", file4i2, Environment.NewLine));
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", file4n3, Environment.NewLine));
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", " ", Environment.NewLine));
            File.AppendAllText(@"C:\Users\User\Desktop\Task\file4.txt", string.Format("{0}{1}", file4i3, Environment.NewLine));
        }
        public static void MoveAllFiles()
        {
            string[] files = Directory.GetFiles(@"C:\Users\User\Desktop\Test2");

            for (int i = 0; i < files.Length; i++)
            {
                string filename = " ";
                foreach (var item in files[i])
                {
                    if (item == '\\')
                    {
                        filename = " ";
                        continue;
                    }
                    else if (item == '.')
                    {
                        break;
                    }

                    filename += item;
                }
                DateTime dt = DateTime.Now;
                string dt2 = "";
                foreach (var item in dt.ToString())
                {
                    if (item == '.' || item == ':')
                    {
                        continue;
                    }
                    else
                    {
                        dt2 += item;
                    }
                }
                string adress = @"C:\Users\User\Desktop\Task\" + filename + dt2 + ".txt";
                string fileadress = "";
                foreach (var item in adress)
                {
                    if (item == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        fileadress += item;
                    }
                }
                File.Move(files[i], fileadress);


            }
        }
    }
}
