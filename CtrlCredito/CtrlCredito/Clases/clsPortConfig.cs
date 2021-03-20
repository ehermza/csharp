using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrldeCredito
{
    class clsPortConfig
    {
        private string filepath =
            System.IO.Path.GetDirectoryName(
              System.Reflection.Assembly.GetExecutingAssembly().Location);

        public void Write(string idPort, int baudios)
        {
            //string[] lines = { "R,9600,COM3", "" };
            filepath += @"\portconfig.txt";
            if (!File.Exists(filepath)) {
                File.Create(filepath);
            }
            using (StreamWriter file = new StreamWriter(filepath))
            {
                file.WriteLine(String.Format(("R,{0},COM{1}"), baudios, idPort));
            }
        }

        public string GetPort()
        {
            string line, info = "";
            filepath += @"\portconfig.txt";

            if (!File.Exists(filepath)) {
                using (FileStream FS = File.Create(filepath))
                {
                    byte[] infobytes= new UTF8Encoding(true).GetBytes("R,9600,COM3");
                    FS.Write(infobytes, 0, infobytes.Length);
                    Console.WriteLine(infobytes);
                }
            }
            try
            {
                StreamReader file = new StreamReader(filepath);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.IndexOf('R') != -1)
                        info = line;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return info;
        }

    }
}
