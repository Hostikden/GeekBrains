int n = 1;

void FindWords(string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        Console.WriteLine($"{n++} {new System.String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWords(alphabet, word, lenght + 1);
    }
}

FindWords("аисв", new char[2]);