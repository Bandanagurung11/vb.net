Imports System

Module Program
    Sub Main(args As String())
        Dim n As Integer
        Console.WriteLine("enter number")
        n = Console.ReadLine()
        If (n Mod 2 = 0) Then
            Console.WriteLine("even number")
        Else
            Console.WriteLine("odd number")
        End If
    End Sub
End Module
