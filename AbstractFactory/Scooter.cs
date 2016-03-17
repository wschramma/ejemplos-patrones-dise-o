using System;

public abstract class Scooter
{
  protected string modelo;
  protected string color;
  protected int potencia;

  public Scooter(string modelo, string color, int
    potencia)
  {
    this.modelo = modelo;
    this.color = color;
    this.potencia = potencia;
  }
  public abstract void mostrarCaracteristicas();
}
