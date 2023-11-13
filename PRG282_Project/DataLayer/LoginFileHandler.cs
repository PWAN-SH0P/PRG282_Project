using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;


namespace PRG282_Project.DataLayer
{
    internal class LoginFileHandler
    {
        string path = "HighlySecureLoginData.txt";

        public List<string> GetAllLines()
        {
            List<string> list = new List<string>(); 

            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                {
                    list.Add(stream.ReadLine());
                }
            }
            return list;
        }

        public List<string> GetStudents()
        {
            List<string> list = new List<string>();

            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                {
                    string username = stream.ReadLine().Split(',')[0];
                    list.Add(username);
                }
            }
            return list;
        }

        public void Write(string username, string password)
        {
            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.Write($"{username},{password}");
            }
        }
    }
}
