Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer = 3
        Dim i As Integer
        For i = 1 To 5
            Console.WriteLine(a)
            a = a * 10 + 3
        Next
    End Sub
End Module
