Imports System

Module Program
    Sub Main(args As String())
        Dim l, b, h As Integer
        Dim v As Integer
        Console.WriteLine("enter length breadth and height of cubiod")
        l = Console.ReadLine()
        b = Console.ReadLine()
        h = Console.ReadLine()
        v = l * b * h
        Console.WriteLine("cubiod volume is:{0}", v)
    End Sub
End Module
