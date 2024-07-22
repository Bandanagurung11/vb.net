Imports System

Module Program
    Sub Main(args As String())
        Dim h, l, b As Double
        Dim a As Double
        Console.WriteLine("enter height lenght and breadth of walls")
        h = Console.ReadLine()
        l = Console.ReadLine()
        b = Console.ReadLine()
        a = 2 * h * (l + b)
        Console.WriteLine("ares of 4 walls is {0}", a)
    End Sub
End Module
