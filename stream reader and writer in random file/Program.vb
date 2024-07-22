Imports System.IO

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter name and address")
        Dim name As String = Console.ReadLine()
        Dim address As String = Console.ReadLine()

        Dim filePath As String = "D:\programs\visual basic\xyz_random.dat"

        Using writer As New BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate))

            ' Get the current position in the file
            Dim position As Long = writer.BaseStream.Length


            ' Move the cursor to the end of the file
            writer.BaseStream.Seek(position, SeekOrigin.Begin)

            ' Write data to the file at the current position
            writer.Write(name)
            writer.Write(address)
        End Using

        Console.WriteLine("Data stored in xyz_random.dat")

        Using reader As New BinaryReader(File.Open(filePath, FileMode.Open))
            While reader.BaseStream.Position < reader.BaseStream.Length
                Dim readName As String = reader.ReadString()
                Dim readAddress As String = reader.ReadString()

                Console.WriteLine("Name: " & readName)
                Console.WriteLine("Address: " & readAddress)
                Console.WriteLine()
            End While
        End Using
    End Sub
End Module

