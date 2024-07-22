Imports System

Module Program
    Function reverse(ByVal a As Integer)
        Dim b, c, d As Integer
        While (a <> 0)
            b = a Mod 10
            c = c * 10 + b
            a = a \ 10
        End While
        Return c
    End Function
    Sub Main(args As String())
        Dim n As Integer
        Console.WriteLine("enter any number")
        n = Console.ReadLine()
        Console.WriteLine("reverse is : {0}", reverse(n))
    End Sub
End Module
