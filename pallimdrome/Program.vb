Imports System

Module Program
    Sub Main(args As String())
        Dim a, d, b, rev As Integer
        Console.WriteLine("enter number:")
        a = Console.ReadLine()
        b = a
        While (a <> 0)
            d = a Mod 10
            rev = Rev * 10 + d
            a = a / 10
        End While
        If (b = rev) Then
            Console.WriteLine("it is a pallimdrome")
        Else
            Console.WriteLine("it is not a pallimdrome")
        End If
    End Sub
End Module
