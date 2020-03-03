    private static string[] contentType =
    {
        "Movie",
        "game",
        "track",
        "picture",
        "Book"
    };

    private static string GenerateString(int n)
    {
        var s = string.Empty;
        for (var i = 0; i < n; ++i)
        {
            s += (char) (rnd.Next('a', 'z' + 1));
        }

        return s;
    }

    private static string CreateContent()
    {
        var type = contentType[rnd.Next(0, contentType.Length)];
        switch (type.ToLower())
        {
            case "movie":
                return
                    $"movie;{rnd.Next(100, 2000)};{GenerateString(rnd.Next(1, 15))};{rnd.Next(20, 300)};" +
                    $"{rnd.Next(1900, 2021)};{GenerateString(rnd.Next(4, 20))}";
            case "game":
                return
                    $"game;{rnd.Next(200, 5000)};{GenerateString(rnd.Next(3, 15))};{GenerateString(rnd.Next(4, 20))};" +
                    $"{GenerateString(rnd.Next(4, 20))};{rnd.Next(1, 1000)}";
            case "track":
                return
                    $"track;{rnd.Next(5, 1000)};{GenerateString(rnd.Next(3, 15))};{GenerateString(rnd.Next(4, 20))};" +
                    $"{GenerateString(rnd.Next(4, 20))};{rnd.Next(1, 60)}";
            default:
                return
                    $"{type};{rnd.Next(100, 2000)};{GenerateString(rnd.Next(10, 200))}";
        }
    }

    private static Random rnd = new Random(1514);
    private static void GenerateQueries()
    {
        for (int testNum = firstTest; testNum <= lastTest; testNum++)
        {
            using (StreamWriter input = new StreamWriter(path + testNum.ToString("D2")))
            {
                input.WriteLine(rnd.Next(500, 10000));
                var length = rnd.Next(15, 100);
                input.WriteLine(length);
                for (int i = 0; i < length; ++i)
                {
                    input.WriteLine(CreateContent());
                }
            }
        }
    }

    foreach (var file in Directory.GetFiles(path))
        {
            if (file.EndsWith(".a"))
                continue;

            Console.SetIn(new StreamReader(file));
            Console.SetOut(new StreamWriter(file + ".a"));

        Console.Out.Close();
        }