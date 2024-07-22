Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer
        Dim arm As Integer = 0
        Console.WriteLine("enter any number")
        a = Console.ReadLine()
        b = a
        While (a <> 0)
            c = a Mod 10
            arm = (c * c * c) + arm
            a = a \ 10
        End While
        If (b = arm) Then
            Console.WriteLine("it is a armostrong number")
        Else
            Console.WriteLine("it is not a armstong number")
        End If
    End Sub
End Module
