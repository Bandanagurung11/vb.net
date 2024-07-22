Imports System
Imports System.ComponentModel.Design

Module Program
    Sub Main()
        Dim n As Integer
        Console.WriteLine("Enter any number:")
        n = Console.ReadLine()
        Check(n)
    End Sub
    Sub Check(ByVal n As Integer)
        Dim i As Integer
        Dim c As Integer = 0
        For i = 1 To n
            If (n Mod i = 0) Then
                c = c + 1
            End If
        Next
        If (c = 2) Then
            Console.WriteLine("The given number is prime")
        Else
            Console.WriteLine("The given number is composite")
        End If
    End Sub
End Module
