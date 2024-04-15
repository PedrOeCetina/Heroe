using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Los_Heroes.Modelos;

public class Heroe
{
    public int Id;
    public string Nombre;

    // private string _IdentidadSecreta{
    //   get { return _IdentidadSecreta; }
    // set { _IdentidadSecreta = IdentidadSecreta.Trim(); }
    //}
    public string IdentidadSecreta;
    public string Ciudad;
    public Poder[] Poderes;
    public bool Volar;

    public Heroe(string nombre, int id)
    {
        Id = id;
        Nombre = nombre;
        Poderes = [];
    }

    public Heroe()
    {
        Poderes = [];
    }

    public void MostrarHeroe()
    {
        Console.WriteLine($"{Id}" +
                          $"\n{Nombre}" +
                          $"\n{IdentidadSecreta}" +
                          $"\n{Ciudad}" +
                          $"\nVolar {Volar}\nPoderes:");
        ListaPoderes();
    }

    private void ListaPoderes()
    {

            for (int i = 0; i < Poderes.Length; i++)
            {
                Console.WriteLine($"\n {Poderes[i].Nombre}");
                Console.WriteLine($" {Poderes[i].descripcion}");
                Console.WriteLine($" {Poderes[i].nivel}");
            }
        
    }
}