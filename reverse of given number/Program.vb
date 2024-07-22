Imports System

Module Program
    Sub Main(args As String())
        Dim a, r, rev As Integer
        Console.WriteLine("enter any number")
        a = Console.ReadLine()
        While (a <> 0)
            r = a Mod 10
            rev = rev * 10 + r
            a = a / 10
        End While
        Console.WriteLine("reverse is: {0}", rev)
    End Sub
End Module
