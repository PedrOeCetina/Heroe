
using Los_Heroes.Modelos;
using System.Reflection.Emit;

var fuerza = new Poder();
fuerza.Nombre = "Super fuerza";
fuerza.descripcion = "Muy fuerte";
fuerza.nivel = nivelpoder.NivelDos;
var laser = new Poder();
laser.Nombre = "Rayo laser";
laser.descripcion = "Un potente rayo de plasma que derrite cosas";
laser.nivel = nivelpoder.NivelTres;
var salto = new Poder();
salto.Nombre = "Super salto";
salto.descripcion = "Un impulso vertical generado desde las piernas gracias a la super fuerza";
salto.nivel = nivelpoder.NivelUno;
var velocidad = new Poder();
velocidad.Nombre = "Super velocidad";
velocidad.descripcion = "Un impulso horizontal generado desde las piernas gracias a la super fuerza";

var superMan = new Heroe(nombre: "SuperMan", id: 1);
var flash = new Heroe("Flash", 2);
var doom = new Villano();

doom.MostrarHeroe();

superMan.Id = 1;
superMan.Nombre = "SuperMan";
superMan.IdentidadSecreta = "         Clark Kent     ";
superMan.Ciudad = "Metropolis";
superMan.Poderes = [fuerza, laser, salto, velocidad];
superMan.Volar = true;


superMan.MostrarHeroe();
flash.MostrarHeroe();

public enum nivelpoder
{
    NivelUno,
    NivelDos,
    NivelTres
}