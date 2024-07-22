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

        ' Create or open the file for random access
        Dim filePath As String = "D:\programs\visual basic\file_random.txt"
        Using writer As New BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate))
            ' Get the current position in the file
            Dim position As Long = writer.BaseStream.Length

            ' Move the cursor to the end of the file
            writer.BaseStream.Seek(position, SeekOrigin.Begin)

            ' Write employee information to the file at the current position
            writer.Write(name)
            writer.Write(address)
            writer.Write(salary)
        End Using

        Console.WriteLine("Employee information stored in file_random.txt")

        Using reader As New BinaryReader(File.Open(filePath, FileMode.Open))
            While reader.BaseStream.Position < reader.BaseStream.Length
                Dim readPosition As Long = reader.BaseStream.Position
                Dim readName As String = reader.ReadString()
                Dim readAddress As String = reader.ReadString()
                Dim readSalary As Double = reader.ReadDouble()

                Console.WriteLine("Position: " & readPosition)
                Console.WriteLine("Name: " & readName)
                Console.WriteLine("Address: " & readAddress)
                Console.WriteLine("Salary: " & readSalary)
                Console.WriteLine()
            End While
        End Using
    End Sub
End Module

