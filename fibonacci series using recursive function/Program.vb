Imports System

Module Program
    Function Fibonacci(ByVal n As Integer) As Integer
        If n <= 1 Then
            Return n
        Else
            Return Fibonacci(n - 1) + Fibonacci(n - 2)
        End If
    End Function

    Sub Main(args As String())
        Dim n As Integer = 10
        Dim i As Integer
        Console.WriteLine(" Fibonacci series:")

        For i = 0 To n
            Console.Write(Fibonacci(i) & " ")
        Next

        Console.ReadLine()
    End Sub
End Module






