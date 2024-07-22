Imports System
Imports System.IO
Imports System.Runtime.CompilerServices

Module Program
    Sub Main(args As String())
        Console.WriteLine("enter name and address")
        Dim name As String = Console.ReadLine()
        Dim address As String = Console.ReadLine()

        Using sw As StreamWriter = New StreamWriter("D:\programs\visual basic\xyz.txt")
            sw.WriteLine(name)
            sw.WriteLine(address)
        End Using

        Using sr As StreamReader = New StreamReader("D:\programs\visual basic\xyz.txt")
            Dim line As String
            line = sr.ReadLine()
            While (line <> Nothing)
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
        End Using

    End Sub
End Module