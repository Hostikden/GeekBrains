using System.Text;  // для использования стрингбилдера подключаем пространство имён .Text!!!

StringBuilder sb = new StringBuilder();
sb.Append("My ");
sb.Append("name ");
sb.Append("is ");
sb.Append("Den");
sb.AppendLine("!"); // AppendLine - перевод каретки на новую строку
sb.AppendLine("Hello!");

string str = sb.ToString(); // переводим в строку

System.Console.WriteLine(str); // выводим строку

// используется при складывании большого количества строк
// работает быстрее чем конкат либо другие сложения строк