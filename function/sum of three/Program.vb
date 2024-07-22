Imports System

Module Program
    Function sum(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Dim s As Integer = 0
        s = a + b + c
        Return s
    End Function
    Sub Main(args As String())
        Dim a, b, c, x As Integer
        Console.WriteLine("enter any three number:")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        x = sum(a, b, c)
        Console.WriteLine("sum of three number is {0}", x)
    End Sub
End Module

