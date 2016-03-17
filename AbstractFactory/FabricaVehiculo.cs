using System;

public interface FabricaVehiculo
{
  Automovil creaAutomovil(string modelo, string color,
    int potencia, double espacio);

  Scooter creaScooter(string modelo, string color, int
    potencia);
}
