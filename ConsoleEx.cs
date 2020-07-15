using System;

namespace POO_Trabajo_Grupal_U2_Flores_Lipa
{
  public static class ConsoleEx
  {
    public static void WriteAlert(string texto, ConsoleColor color = ConsoleColor.Red)
    {
      Console.ForegroundColor = color;
      Console.WriteLine($"\t{texto}");
      Console.ForegroundColor = ConsoleColor.Black;
    }
    public static void SetLightTheme()
    {
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
    }
  }
}
