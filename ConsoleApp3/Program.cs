   Console.Write("Ingrese el número de filas de la matriz: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas de la matriz: ");
        int columnas = int.Parse(Console.ReadLine());

        // Declarar e inicializar la matriz
        int[,] matriz = new int[filas, columnas];

        // Solicitar al usuario que ingrese los elementos de la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Ingrese el elemento en la posición [{i + 1}, {j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Contar elementos positivos, negativos y nulos
        int positivos = 0, negativos = 0, nulos = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] > 0)
                    positivos++;
                else if (matriz[i, j] < 0)
                    negativos++;
                else
                    nulos++;
            }
        }

        // Mostrar los resultados
        Console.WriteLine($"Elementos positivos: {positivos}");
        Console.WriteLine($"Elementos negativos: {negativos}");
        Console.WriteLine($"Elementos nulos: {nulos}");
    
