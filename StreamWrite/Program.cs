using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StreamWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path01 = @"C:\Curso C\StremWrite.txt";
            String Destinopath01 = @"C:\Curso C\StremWrite2.txt";//arquivo sera criado , porem letras (Maiusculas)

            try  {
                string[] Lines= File.ReadAllLines(path01);//arquivo de origem
                //agora vamos instanciar o arquivo path para sair escrito no arquivo de origem
                using (StreamWriter sw = File.AppendText(Destinopath01))//abrir arquivo de escrita e adicionar no final posição
                {
                    foreach (string Line in Lines)
                    {
                        sw.WriteLine(Line.ToUpper());

                    }
                }
            
            }

            catch (IOException) {

                Console.WriteLine("Erro inesperado !! ");
            }
        }
    }
}
