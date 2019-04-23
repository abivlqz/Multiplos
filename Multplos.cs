using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
namespace GitHubPractica.Clases
{
    public class Separar_numeros
    {
        public static void Separarnum()
        {
            List<string> lines = new List<string>();
            lines = LeerTexto.LeerText();
            int multiplos = 0;

            foreach (string line in lines)
            {


                bool isMultiple = int.Parse(line) % 10 == 0;
                if(isMultiple== true)
                {
                    Console.WriteLine("este numero es multiplo de diez: "+line);
                }
                multiplos = multiplos + Convert.ToInt32(isMultiple);




            }
            Console.WriteLine("Estos numeros son multiplos: " + multiplos);

        }
    }
}
