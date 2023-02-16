string[] snacks = { "sushi", "pizza", "burger", "chicken", "Asian takeaway" }; // Program otsustab mida massiivist valida

// Indeksid - sushi [0], pizza[1], burger [2], chicken[3], Asian takeaway[4]. Kokku on massiivi pikkus 5

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat: {snacks[randomIndex]}.");
