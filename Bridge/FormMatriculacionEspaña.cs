using System;

public class FormularioMatriculacionEspaņa :
  FormularioMatriculacion
{
    public FormularioMatriculacionEspaņa(FormularioImpl
    implementacion) : base(implementacion) { }

    protected override bool controlZona(string matricula)
    {
        return matricula.Length == 7;
    }
}
