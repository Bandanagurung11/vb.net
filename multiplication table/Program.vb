Imports System

Module Program
    Sub Main(args As String())
        Dim n, i As Integer
        Console.WriteLine("enter any number")
        n = Console.ReadLine()
        For i = 1 To 10
            Console.WriteLine(n & " x " & i & " = " & (n * i))
        Next
    End Sub
End Module
