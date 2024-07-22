Imports System
Imports System.Linq.Expressions

Module Program
    Sub Main(args As String())
        Dim r As Integer
        Const pi As Double = 3.14
        Dim a As Double
        Console.WriteLine("enter radius of circle")
        r = Console.ReadLine()
        a = pi * r * r
        Console.WriteLine("area of ther circle is {0}", a)

    End Sub
End Module
