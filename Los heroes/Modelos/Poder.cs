using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Los_Heroes.Modelos;

public class Poder
{

    public string Nombre;
    public string descripcion;
    public nivelpoder nivel;

    public Poder()
    {

    }

    public Poder(string nombre)
    {
        Nombre = nombre;
        nivel = nivelpoder.NivelUno;
    }
}