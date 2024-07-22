Imports System

Module Program
    Sub Main(args As String())
        Dim n, i As Integer
        Dim c As Integer = 0
        Console.WriteLine("enter any number")
        n = Console.ReadLine()
        For i = 1 To n
            If (n Mod i = 0) Then
                c = c + 1
            End If
        Next
        If (c <= 2) Then
            Console.WriteLine("it is prime number")
        ElseIf (c > 2) Then
            Console.WriteLine("it is composite number")
        Else
            Console.WriteLine("neither prime or composite number")
        End If
    End Sub
End Module
