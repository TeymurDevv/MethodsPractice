#region task1
string Divide(int n)
{
    if (n%3==0 && n%7==0)
    {
        return $"{n} Ededi hem 3 e hem 7 ye bolunur";
    }
    return $"{n} Ededi hem 3 e hem 7 ye bolunmur";
}
string divideResult = Divide(21);
Console.WriteLine(divideResult);
#endregion
