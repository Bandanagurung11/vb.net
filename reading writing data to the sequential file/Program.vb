
Imports System.IO

Module Module1
    Sub Main()
        Console.WriteLine("Enter employee information:")
        Console.Write("Name: ")
        Dim name As String = Console.ReadLine()
        Console.Write("Address: ")
        Dim address As String = Console.ReadLine()
        Console.Write("Salary: ")
        Dim salary As Double = CDbl(Console.ReadLine())

        ' Create or open the file for writing
        Dim filePath As String = "D:\programs\visual basic\file.txt"
        Using writer As New BinaryWriter(File.Open(filePath, FileMode.Append))
            ' Write employee information to the file
            writer.Write(name)
            writer.Write(address)
            writer.Write(salary)
        End Using

        Console.WriteLine("Employee information stored in file.txt")

        Using reader As New BinaryReader(File.Open(filePath, FileMode.Open))
            While reader.BaseStream.Position < reader.BaseStream.Length
                Dim readName As String = reader.ReadString()
                Dim readAddress As String = reader.ReadString()
                Dim readSalary As Double = reader.ReadDouble()

                Console.WriteLine("Name: " & readName)
                Console.WriteLine("Address: " & readAddress)
                Console.WriteLine("Salary: " & readSalary)
                Console.WriteLine()
            End While
        End Using
    End Sub
End Module


