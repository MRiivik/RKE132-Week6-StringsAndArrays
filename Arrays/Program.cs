// Massiive kasutatakse, et salvestada andmeid ühte kohta
// Massiive kujutatakse 'string[]'
// string[] fruit = {"apples", "oranges", "bananas"}; NÄIDE 1
string[] fruit = new string[3]; // [3] - näitab mitu elementi on massiivis

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} fruits in your array.");

for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0])); // Muudab elementide tähed suureks
}

// Saab ka kasutada teist lahendust:

foreach (string element in fruit) // foreach - kuvab kõik massiivi 'fruit' elemendid. element - kõik elemendid massiivis 'fruit'
{
    element = element.Replace(element[0], char.ToUpper(element[0]));
    Console.WriteLine(element);
}