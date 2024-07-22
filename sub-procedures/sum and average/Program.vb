Imports System

Module Program
    Sub calculate(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer)
        Dim sum, av As Integer
        sum = a + b + c
        av = a + b + c / 3
        Console.WriteLine("sum is {0}", sum)
        Console.WriteLine("average is:{0}", av)
    End Sub
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.WriteLine("enter three number")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        calculate(a, b, c)
    End Sub
End Module
