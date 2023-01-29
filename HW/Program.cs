Console.Clear();
int num = UserNumber("Введите номер задачи: 41 или 43: ", "Ошибка ввода!");
if (num == 41) FirstTask();
else SecondTask();

void FirstTask()
{
    int num = UserArrayNumber("Введите число - размер массива: ", "Ошибка ввода!");    
    int[] array = GetArray(num);
    int cnt = PosCnt(array);
    Console.WriteLine($"Количество положительных чисел массива: [{String.Join(", ", array)}] -> {cnt}");
}

void SecondTask()
{
    Console.WriteLine("Находим точку пересечения двух прямых");
    double b1 = Convert.ToDouble(UserArrayNumber("Введите точку b1: ", "Ошибка ввода!"));
    double k1 = Convert.ToDouble(UserArrayNumber("Введите точку k1: ", "Ошибка ввода!"));
    double b2 = Convert.ToDouble(UserArrayNumber("Введите точку b2: ", "Ошибка ввода!"));
    double k2 = Convert.ToDouble(UserArrayNumber("Введите точку k2: ", "Ошибка ввода!"));
    double[] crossPoint = CrossPoint(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения двух прямых: ({String.Join(";", crossPoint)})");
}

int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = UserArrayNumber($"Введите {i + 1}-й элемент массива: ", "Ошибка ввода");
    }
    return result;
}

int UserNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect && (userNumber == 41 || userNumber == 43))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int UserArrayNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int PosCnt(int[] array)
{
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) cnt++;
    }
    return cnt;
}

double[] CrossPoint(double b1, double k1, double b2, double k2)
{
    double resX = (b2 - b1) / (k1 - k2);
    double resY = resX * k1 + b1;
    double[] result = new double [2];
    result[0] = resX;
    result[1] = resY;
    return result;
}



