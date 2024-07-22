Imports System.IO

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim empName As String = txtName.Text
        Dim empAddress As String = txtAddress.Text
        Dim empSalary As Decimal = Convert.ToDecimal(txtSalary.Text)

        Dim empInfo As String = empName & "|" & empAddress & "|" & empSalary.ToString()

        Try
            Using writer As New StreamWriter("emp.dat", True)
                writer.WriteLine(empInfo)
            End Using

            MessageBox.Show("Employee information saved successfully.")
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtAddress.Clear()
        txtSalary.Clear()
    End Sub
End Class

