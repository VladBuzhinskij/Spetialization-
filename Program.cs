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
