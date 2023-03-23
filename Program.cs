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
