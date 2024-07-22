Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.WriteLine("enter three number")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        If (a < b And a < c) Then
            Console.WriteLine("{0} is the smallest number", a)
        ElseIf (B < a And b < c) Then
            Console.WriteLine("{0} is the smallest number", b)
        Else
            Console.WriteLine("{0} is the smallest number", c)
        End If
    End Sub
End Module
