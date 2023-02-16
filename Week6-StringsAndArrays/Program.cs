string hello = "we are the champions?"; // täht "h" asub kohal [0], e kohal [1] jne. jne.

// sõna "hello" pikkus on 5 
// sõna viimane täht = [length-1]

int stringLength = hello.Length;

// string trimmedString = hello.Trim(); // sulud "()" tähistavad, et käsklus teeks midagi

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter); // kuvab esialgse tähe

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter= hello[0];
Console.WriteLine(firstLetter); // Kuvab uue, muudetud tähe

Console.WriteLine(hello); // Kuvab kogu muudetud lause



//int wordCounter = 1;

//for(int i = 0;i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i])) // IsWhiteSpace kontrollib kas sümbol on tühik, tagastab true/false ainult
//    {
//        wordCounter++;
//    }
//}
//Console.WriteLine($"Word count in {hello}: {wordCounter} words."); // näitab kui pikk on "hello world!" tekst

