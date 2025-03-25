// Дан текст. В нем нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
        + "ежели бы вас послали вместо нашего милого Винценгерде, "
        + "вы бы звяли приступом согласие прусского короля. "
        + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{

    string result = String.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string rez = Replace(text, 'к', 'К');
rez = Replace(rez, 'С', 'с');
rez = Replace(rez, ' ', '/');

Console.WriteLine(rez);