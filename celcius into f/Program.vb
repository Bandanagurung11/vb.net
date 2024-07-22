Imports System

Module Program
    Sub Main(args As String())
        Dim c As Double
        Dim f As Double
        Console.WriteLine("enter temperature in celcius")
        c = Console.ReadLine()
        f = 5 / 9 * c + 32
        Console.WriteLine("temperature in f {0}", f)
    End Sub
End Module
