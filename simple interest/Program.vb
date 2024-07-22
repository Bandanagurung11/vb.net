Imports System

Module Program
    Sub Main(args As String())
        Dim p, t, r As Double
        Dim si As Double
        Console.WriteLine("enter principle, time and rate")
        p = Console.ReadLine()
        t = Console.ReadLine()
        r = Console.ReadLine()
        si = p * t * r / 100
        Console.WriteLine("your simple interest is {0}", si)

    End Sub
End Module
