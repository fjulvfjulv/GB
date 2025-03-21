Console.Clear();

int xa = 1, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;

// Проверяем, не выходит ли курсор за пределы консоли
int maxWidth = Console.BufferWidth - 1;
int maxHeight = Console.BufferHeight - 1;

// Корректируем координаты, если они выходят за пределы
ya = Math.Min(ya, maxHeight);
yb = Math.Min(yb, maxHeight);
yc = Math.Min(yc, maxHeight);

xa = Math.Min(xa, maxWidth);
xb = Math.Min(xb, maxWidth);
xc = Math.Min(xc, maxWidth);

// Устанавливаем курсор и выводим символы
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 1000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}



// Ожидание, чтобы консоль не закрылась сразу
Console.ReadKey();