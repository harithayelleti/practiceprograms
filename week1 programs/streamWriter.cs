using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream_writer
{

    class fileexample
    {
        class writetofile
        {
            public void Data()
            {
                //This will create a file name sample.txt from your local machine
                //stream writer is the inbuilt func in c#
                //streamwriter "name" = new streamwriter("loc of file")
                StreamWriter sync = new StreamWriter("C:\\Users\\Hari\\Desktop\\sync.txt");
                //to write on the console scren 
                Console.WriteLine("Enter what you want to see");
                //to display the input from the user
                string display = Console.ReadLine();
                //to writeline in the buffer
                sync.WriteLine(display);
                //to write the output stream

                sync.Flush();
                //we neeed to close the writer
                sync.Close();

            }




            //driver code/main method
            class Program
            {
                static void Main(string[] args)
                {

                    writetofile wr = new writetofile();
                    wr.Data();
                    Console.ReadKey();

                    FileStream fd = new FileStream("C:\\Users\\Hari\\Desktop\\sync.txt", FileMode.OpenOrCreate);
                    StreamReader sd = new StreamReader(fd);
                    String lines = sd.ReadLine();
                    Console.WriteLine(lines);

                    sd.Close();
                    fd.Close();

                    Console.ReadLine();
                }

            }
        }
    }
}
