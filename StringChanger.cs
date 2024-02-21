string name = "Скучнов";
string secondname = "Георгий";

Console.WriteLine($"имя: {name}, фамилия {secondname}");

string clipboard = name; //не уверен можно ли это сделать без буфера
name = secondname;
secondname = clipboard;

Console.WriteLine($"имя: {name}, фамилия {secondname}");