Imports System

Module Program
    Function greatest(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer)
        If (a > b And a > c) Then
            Console.WriteLine("greatest number is{0}", a)
        ElseIf (B > a And b > c) Then
            Console.WriteLine("greatest number is {0}", b)
        Else
            Console.WriteLine("greatest number is{0}", c)
        End If
    End Function
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.WriteLine("enter three number")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        greatest(a, b, c)
    End Sub
End Module
