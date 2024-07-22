Imports System

Module Program
    Function multiplication(ByVal a As Integer) As String
        Dim i As Integer
        Dim result As String = ""

        For i = 1 To 10
            result &= a & " * " & i & " = " & (a * i) & Environment.NewLine
        Next

        Return result
    End Function

    Sub Main(args As String())
        Dim a As Integer
        Console.WriteLine("Enter a number:")
        a = Console.ReadLine()
        Console.WriteLine(multiplication(a))
    End Sub
End Module

