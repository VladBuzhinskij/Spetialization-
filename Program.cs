String[] SelectLine(String[] Array)
{
    Int32 j = 0;
    String[] Result = new String[Array.Length];
    String Line = String.Empty;
    for (int i = 0; i < Array.Length; i++)
    {
        Line = Array[i];
        if (Line.Length <= 3)
        {
            Result[j] = Line;
            j++;
        }
    }
    return Result;
}
String[] DeleteNullLine(String[] Array)
{
    Int32 j = 0;
    Int32 k = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] != null) j++;
    }
    String[] Result = new String[j];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] != null)
        {
            Result[k] = Array[i];
            k++;
        }
    }
    return Result;
}



Console.WriteLine("Введите массивы строк через запятую");
String Input = Console.ReadLine();
if (Input != null)
{
    String[] Array = Input.Split(',');
    String[] InterimResult = SelectLine(Array);
    String[] Result = DeleteNullLine(InterimResult);
    for (int i = 0; i < Result.Length; i++) Console.Write($"{Result[i]}  ");
}
else Console.WriteLine("Ошибка");
