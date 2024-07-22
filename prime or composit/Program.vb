Imports System

Module Program
    Sub Main()
        Console.WriteLine("Enter a number:")
        Dim number As Integer = Integer.Parse(Console.ReadLine())

        Dim isPrime As Boolean = True

        If number <= 1 Then
            isPrime = False
        Else
            Dim maxDivisor As Integer = CInt(Math.Floor(Math.Sqrt(number)))

            For i As Integer = 2 To maxDivisor
                If number Mod i = 0 Then
                    isPrime = False
                    Exit For
                End If
            Next
        End If

        If isPrime Then
            Console.WriteLine(number & " is a prime number.")
        Else
            Console.WriteLine(number & " is a composite number.")
        End If

        Console.ReadLine()
    End Sub
End Module
