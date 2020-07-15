using System;

namespace POO_Trabajo_Grupal_U2_Flores_Lipa
{
  public static class Validater
  {
    public static bool ValidarOpcion(out int opcion, int maximo, int minimo = 0)
    {
      bool esValido = int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcion) &&
        opcion >= minimo && opcion <= maximo;
      if (!esValido)
        ConsoleEx.WriteAlert($"! Debe ingresar un valor entre {minimo} y {maximo}");
      return esValido;
    }
  }
}
