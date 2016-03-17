using System;

public class Vendedor
{
    protected ConstructorDocumentacionVehiculo constructor;

    public Vendedor(ConstructorDocumentacionVehiculo constructor)
    {
        this.constructor = constructor;
    }

    public Documentacion construye(string nombreCliente)
    {
        constructeur.construyeSolicitudPedido(nombreCliente);
        constructeur.construyeSolicitudMatriculacion
        (nombreCliente);
        Documentacion documentacion = constructor.resultado();
        return documentacion;
    }
}
