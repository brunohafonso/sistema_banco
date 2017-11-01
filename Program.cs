using System;
using utilidades;

namespace terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            documento doc = new documento(); 
            System.Console.WriteLine(doc.validar_documento());
                       
        }
    }
}
