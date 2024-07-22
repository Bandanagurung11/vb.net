Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer = 2
        Dim i As Integer
        Dim s As Integer = 0
        For i = 1 To 15
            s = s + a
            a = a + 2
        Next
        Console.WriteLine("sum of even number is :{0}", s)
    End Sub
End Module
