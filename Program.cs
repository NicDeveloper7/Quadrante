    int coordinate1, coordinate2;

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("---- Bem Vindo ao Quadrante Cartesiano ----");
    Console.ResetColor();

    Console.WriteLine("Onde se encontra a coordenada X? ");
    coordinate1 = int.Parse(Console.ReadLine()!);
      
    Console.WriteLine("Onde se encontra a coordenada Y? ");
    coordinate2 = int.Parse(Console.ReadLine()!);

    Console.ResetColor();

    if (coordinate1 > 0 && coordinate2 > 0)
    {
        Console.Clear();    
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");
        
        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no primeiro quadrante");
    }

    if (coordinate1 < 0 && coordinate2 > 0)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no segundo quadrante");
    }

    if (coordinate1 < 0 && coordinate2 < 0)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();
        
        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no terceiro quadrante");
    }
    if (coordinate1 > 0 && coordinate2 < 0)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no quarto quadrante");
    }

    if (coordinate1 == 0 && coordinate2 == 0)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica na origem");
    }

    if (coordinate1 != 0 && coordinate2 == 0)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no eixo das abscissas");
    }

    if (coordinate1 == 0 && coordinate2 != 0)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no eixo das ordenadas");
    }


    
