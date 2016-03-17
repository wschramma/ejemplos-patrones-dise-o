using System;

public class FabricaVehiculoGasolina : FabricaVehiculo
{
  public Automovil creaAutomobile(string modelo, string
    color, int potencia, double espacio)
  {
    return new AutomovilGasolina(modelo, color,
      potencia, espacio);
  }

  public Scooter creaScooter(string modelo, string
    color, int potencia)
  {
    return new ScooterGasolina(modelo, color, potencia);
  }
}