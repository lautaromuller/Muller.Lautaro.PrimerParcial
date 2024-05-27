using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Prueba de clases";

        Zoologico zoologico = new Zoologico();

        Pinguino pinguino = new Pinguino("Pingüino Emperador", Habitat.Antartida, 5, 30.5, "Aptenodytes forsteri");
        Colibri colibri = new Colibri("Colibrí Rubí", Habitat.Bosque, 2, "Verde", 50.0);
        Halcon halcon = new Halcon("Halcón Peregrino", Habitat.Montaña, 4, 1.2, "Amplio");

        zoologico += pinguino;
        zoologico += colibri;
        Console.WriteLine(zoologico.MostrarAves());
        //zoologico += halcon;
        Console.WriteLine(zoologico == pinguino);
        Console.WriteLine(zoologico == halcon);
        zoologico += pinguino;
        zoologico += halcon;
        Console.WriteLine("Aves en el zoológico:");
        Console.WriteLine(zoologico.MostrarAves());


        zoologico.OrdenarPorNombre(false);
        Console.WriteLine("-------------------\n");
        Console.WriteLine("Aves ordenadas por nombre (Descendente):");

        zoologico.OrdenarPorEdad(true);
        Console.WriteLine("-------------------\n");
        Console.WriteLine("Aves ordenadas por edad:");

        pinguino.Alimentarse();
        colibri.Alimentarse();
        halcon.Alimentarse();

        pinguino.Volar();
        colibri.Volar();
        halcon.Volar();
    }
}