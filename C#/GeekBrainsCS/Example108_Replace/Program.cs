//Работа с текстом
//Дан текст. В тексте необходимо все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с".

//Ясна ли задача?

string text = "- Я думаю, сказал князь, улыбаясь, что, "
            + "ежели бы вас поставили вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123      - со строк также можно брать индексы
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);

System.Console.WriteLine();

newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);