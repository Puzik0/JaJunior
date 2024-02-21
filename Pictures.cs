int pictures = 52;
int rowCapacity = 3;

int rowIsFilled = pictures / rowCapacity;
int picturesNotInRow = 52 % 3;
Console.WriteLine($"заполненныйх рядов с картинками: {rowIsFilled} , картинок осталось: {picturesNotInRow}");
Console.ReadKey();
