Imports System

Module Program
    Sub sum(ByVal a As Integer)
        Dim sum As Integer = 0
        Dim i As Integer
        For i = 1 To 15
            sum = sum + a
            a = a + 2
        Next
        Console.WriteLine("sum of 15 th even number is {0}", sum)
    End Sub
    Sub Main(args As String())
        sum(2)
    End Sub
End Module
