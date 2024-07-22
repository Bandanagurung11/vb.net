Imports System

Module Program
    Function factoriaL(ByVal n As Integer) As Integer
        If (n <= 1) Then
            Return 1
        Else
            Return n * factoriaL(n - 1)
        End If
    End Function
    Sub Main(args As String())
        Dim n, x As Integer
        Console.WriteLine("enter any number:")
        n = Console.ReadLine()
        x = factoriaL(n)
        Console.WriteLine("the factorial is{0}", x)
    End Sub
End Module
