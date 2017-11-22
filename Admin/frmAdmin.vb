Imports System.Data.OleDb

Public Class frmAdmin

    Dim id_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MainDB.accdb;")
    Dim id_com As New OleDbCommand()

    Private Sub frmAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Clearall()
        frmLogin.Show()
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        frmAdd.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        frmProfile.Show()
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id_read As OleDbDataReader
        id_con.Open()
        id_com = New OleDbCommand("Select * from Admin where Id ='" & frmLogin.txtId.Text & "'", id_con)
        id_read = id_com.ExecuteReader()
        If id_read.HasRows Then
            id_read.Read()
            lblAdminId.Text = id_read(0).ToString()
            lblAdmin.Text = id_read(1).ToString()
            lblSubject.Text = id_read(2).ToString()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Clearall()
        frmLogin.Show()
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        frmPass.Show()
    End Sub

    Private Sub btnSI_Click(sender As Object, e As EventArgs) Handles btnSI.Click
        frmStudent.Show()
    End Sub

    Private Sub btnQues_Click(sender As Object, e As EventArgs) Handles btnQues.Click
        frmQues.Show()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        frmSchedule.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAdminResults.Show()
    End Sub

    Private Sub btnAdminDetails_Click(sender As Object, e As EventArgs) Handles btnAdminDetails.Click
        frmAdminDetails.Show()
    End Sub
End Class