Imports System

Module Program
    Sub Main(args As String())
        Dim r As Integer
        Console.WriteLine("enter the radius of circle:")
        r = Console.ReadLine()
        area(r) 'calling sub procedure
    End Sub
    Sub area(ByVal r As Integer)
        Dim A As Double
        A = 3.14 * r * r
        Console.WriteLine("Area of circle is {0}", A)
    End Sub
End Module
