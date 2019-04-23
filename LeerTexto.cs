using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace GitHubPractica.Clases
{
    public class LeerTexto
    {
        public static List<string> LeerText()
        {
            string[] lines= new string[] { };
            List<string> myCollection = new List<string>();

            var fileStream = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lines = line.Split(" ");
                    foreach (string num in lines)
                    {
                       // Console.WriteLine(num);
                         myCollection.Add(num);
                    }
                }
             
            }
            return myCollection;

        }
    }
}
