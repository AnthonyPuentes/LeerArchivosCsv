using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
class Programa
{

public static void Main(string[] args)
{

CSV csv = new CSV();
csv.leerArchivo();
csv.VerificaArchivo();
List<string[]> miFila = csv.ObtenerContenido();

foreach (string[] array in miFila)
{

Console.WriteLine("id: " + array[0] + "\nNombre: " + array[1] + "\nDirección: " + array[2] + "\nTelefono: " + array[3]);

}

Console.ReadKey();
}

}
}