// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

System.Console.WriteLine("Enter number (1-7): ");
int day = int.Parse(Console.ReadLine());

switch(day)
{
    case 1: System.Console.WriteLine("Это понедельник!"); break;
    case 2: System.Console.WriteLine("Это вторник!"); break;
    case 3: System.Console.WriteLine("Это среда!"); break;
    case 4: System.Console.WriteLine("Это четверг!"); break;
    case 5: System.Console.WriteLine("Это пятница!"); break;
    case 6: System.Console.WriteLine("Это суббота!"); break;
    case 7: System.Console.WriteLine("Это воскресенье!"); break;
    default: System.Console.WriteLine("Введена неверная цифра"); break;
}