Imports System.Data.OleDb

Public Class frmResult

    Dim id_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MainDB.accdb;")
    Dim id_com As New OleDbCommand()

    Private Sub frmResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id_read As OleDbDataReader
        id_con.Open()
        id_com = New OleDbCommand("Select * from Result where RollNo =" & frmLogin.txtId.Text & "", id_con)
        id_read = id_com.ExecuteReader()
        If id_read.HasRows Then
            id_read.Read()
            lblRollNo.Text = id_read(0).ToString()
            lblName.Text = id_read(1).ToString()
            lblYear.Text = id_read(2).ToString()
            lblDept.Text = id_read(3).ToString()
            lblTotQuestions.Text = id_read(4).ToString()
            lblAttempted.Text = id_read(5).ToString()
            lblRight.Text = id_read(6).ToString()
            lblObtained.Text = id_read(7).ToString()
        End If
    End Sub

    Private Sub frmResult_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Clearall()
        frmLogin.Show()
    End Sub
End Class