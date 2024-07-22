Imports System
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())
        Dim a As Integer = 1
        Dim b As Integer = 1
        Dim s, i As Integer
        For i = 0 To 10
            Console.WriteLine(a)
            s = a + b


            a = b
            b = s
        Next

    End Sub
End Module
