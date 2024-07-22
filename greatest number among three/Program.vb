Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.WriteLine("enter three number")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        If (a > b And a > c) Then
            Console.WriteLine("the greatest number is {0}", a)
        ElseIf (b > a And b > c) Then
            Console.WriteLine("the greatest number is {0}", b)
        Else
            Console.WriteLine("the greatest number is {0}", c)
        End If
    End Sub
End Module
