using System;

public class Vehiculo : Elemento
{

    public Vehiculo(string descripcion) : base(descripcion) { }

    public void visualiza()
    {
        Console.WriteLine("Descripci�n del veh�culo: " +
          descripcion);
    }
}
