Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer = 1
        Dim i As Integer
        For i = 1 To 20
            Console.WriteLine(a)
            a = a + i
        Next
    End Sub
End Module
