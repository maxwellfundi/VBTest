
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data

Public Class frmRegistration

    Dim f_name As String
    Dim l_name As String
    Dim email As String

    Dim connectionPath As String = "Server=localhost; User Id=root; Password=P@55w0rd; Database=vb_test"
    Dim sqlConnection As MySqlConnection = New MySqlConnection
    Dim datatable As DataTable()

    Public Function Register() As Boolean

        sqlConnection = New MySqlConnection()
        sqlConnection.ConnectionString = connectionPath
        Dim insertCommand As New MySqlCommand
        Dim str_reg As String
        Try
            str_reg = "insert into registration (f_name, l_name, email) values ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "')"
            MsgBox(str_reg, vbOKCancel)
            insertCommand.Connection = sqlConnection
            insertCommand.CommandText = str_reg
            insertCommand.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
            MsgBox("Error occured: Could not insert record")
        End Try

    End Function

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Look out, the Geek is coming", vbOKOnly)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Register()
    End Sub
End Class
