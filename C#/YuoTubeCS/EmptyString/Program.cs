// как определить состояние строки
// пустая, не пустая, null (ничто)

string empty = ""; // string empty = string.Empty;
string whiteSpaced = " ";
string notEmpty = " b";
string nullStr = null;

bool isNullOrEmpty = string.IsNullOrEmpty(empty);
System.Console.WriteLine(isNullOrEmpty);

isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
System.Console.WriteLine(isNullOrEmpty);

isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
System.Console.WriteLine(isNullOrEmpty);

isNullOrEmpty = string.IsNullOrEmpty(nullStr);
System.Console.WriteLine(isNullOrEmpty);

bool isNullOrWhiteSpaced = string.IsNullOrWhiteSpace(whiteSpaced); // этим чаще всего делается проверка на пустую строку
System.Console.WriteLine(isNullOrWhiteSpaced);