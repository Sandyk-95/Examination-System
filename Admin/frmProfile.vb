Imports System.Data.OleDb

Public Class frmProfile

    Dim id_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MainDB.accdb;")
    Dim id_com As New OleDbCommand()

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id_read As OleDbDataReader
        id_con.Open()
        id_com = New OleDbCommand("Select * from Admin where Id ='" & frmLogin.txtId.Text & "'", id_con)
        id_read = id_com.ExecuteReader()
        If id_read.HasRows Then
            id_read.Read()
            lblId.Text = id_read(0).ToString()
            lblName.Text = id_read(1).ToString()
            lblSubject.Text = id_read(2).ToString()
            lblMob.Text = id_read(3).ToString()
            lblEmail.Text = id_read(4).ToString()
        End If
    End Sub
End Class