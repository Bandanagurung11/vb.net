Imports System
Module Program
    Sub digit(ByVal a As Integer)
        Dim b, c As Integer
        While (a <> 0)
            b = a Mod 10
            c = c + b
            a = a \ 10

        End While
        Console.WriteLine("sum of digit is {0}", c)

    End Sub
    Sub main()
        Dim a As Integer
        Console.WriteLine("enter any number")
        a = Console.ReadLine()
        digit(a)
    End Sub
End Module
