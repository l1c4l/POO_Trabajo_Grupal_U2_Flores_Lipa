using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Trabajo_Grupal_U2_Flores_Lipa
{
  class ProgramaPrincipal
  {
    static void Main()
    {
      int opcion;
      bool continuar = true;
      
      do
      {
        ConsoleEx.SetLightTheme();
        ConsoleEx.WriteAlert("# Trabajo Grupal II Unidad – POO #\n", ConsoleColor.Blue);

        Console.WriteLine("## Ejercicios ##\n\n" +
          "1. Club de fútbol\n" +
          "2. Transporte público\n" +
          "3. Estudiantes\n" +
          "4. Kardex\n" +
          "5. Divertimento S.A.\n" +
          "0. Salir");

        do Console.Write("\n> Presione una tecla (0 - 5): ");
        while (!Validater.ValidarOpcion(out opcion, 5));

        Console.Clear();
        switch (opcion)
        {
          case 1: Ejercicio1.Programa.Main(); break;
          case 2: Ejercicio2.Programa.Main(); break;
          case 3: Ejercicio3.Programa.Main(); break;
          case 4: Ejercicio4.Programa.Main(); break;
          case 5: Ejercicio5.Programa.Main(); break;
          case 0: continuar = false; break;
        }

      } while (continuar);
    }
  }
}
