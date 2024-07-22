Imports System

Module Program
    Function reverse(ByVal a As Integer) As String
        Dim b, c, d As Integer
        d = a
        While (a <> 0)
            b = a Mod 10
            c = c * 10 + b
            a = a \ 10
        End While
        If (d = c) Then
            reverse = "pallimdrome"
        Else
            reverse = "not pallimdrome"
        End If
    End Function
    Sub Main(args As String())
        Dim n As Integer
        Console.WriteLine("enter any number")
        n = Console.ReadLine()
        Console.WriteLine("given number is {0}", reverse(n))
    End Sub
End Module
