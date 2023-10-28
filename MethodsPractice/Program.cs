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
#region task2
string evenSum(int n, int m)
{
    if (n%2==0 && m%2==0)
    {
        int result = n + m;
        return $"{n} ve {m} ededleri cutdur ve iki reqemin cemi {result} olur";
    }
    return $"{n} ve {m} ededlerinden her hansi biri cut deyil";
}
string evenSumResult = evenSum(2, 5);
Console.WriteLine(evenSumResult);

#endregion
#region task3
string OddCounter(int n, int m)
{
    int odd= default(int);
    if (m>n)
    {
        for (int i = n; i <= m; i++)
        {
            if (i%2==1)
            {
                odd++;
            }
        }
        return $"{m} ve {n} ededleri arasinda {odd} sayda tek eded var";
    }
    return $"1-ci eded 2-ci ededden kicikdir";
}
string oddCounterResult = OddCounter(10, 15);
Console.WriteLine(oddCounterResult);
#endregion
