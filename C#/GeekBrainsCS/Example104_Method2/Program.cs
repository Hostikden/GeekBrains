/*
Методы, которые ничего не возвраащают, но принимают какие-нибудь аргументы
*/

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

Method2("текст сообщения");
// существуют именованные методы, часто применяются:
Method2(msg: "текст варинат два");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);       // 4 - кол-во раз вывода "Текст"
//именнованные аргументы не обязательно записывать по порядку
//в этом их особенность
Method21(count: 4, msg: "новый текст");