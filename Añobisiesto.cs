 Console.Write("Ingresa un año: ");
        int anio = int.Parse(Console.ReadLine());

        if
            (EsBisiesto(anio))
            Console.WriteLine("El año " + anio + " es bisiesto");
        
        else
        
            Console.WriteLine("El año " + anio + " no es bisiesto");

        Console.ReadKey();

    static bool EsBisiesto(int anio)
    {
        if (anio % 4 != 0) return false;
        if (anio % 100 != 0) return true;
        if (anio % 400 != 0) return false;
        return true;
    }
