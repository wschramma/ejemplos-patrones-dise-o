using System;

public class FormularioMatriculacionEspa�a :
  FormularioMatriculacion
{
    public FormularioMatriculacionEspa�a(FormularioImpl
    implementacion) : base(implementacion) { }

    protected override bool controlZona(string matricula)
    {
        return matricula.Length == 7;
    }
}
