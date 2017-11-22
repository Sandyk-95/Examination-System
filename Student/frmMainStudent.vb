Imports System.Data.OleDb

Public Class frmMainStudent

    Dim id_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MainDB.accdb;")
    Dim id_com As New OleDbCommand()

    Private Sub frmMainStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id_read As OleDbDataReader
        Dim date1 As Date
        id_con.Open()
        id_com = New OleDbCommand("Select * from Student where RollNo =" & frmLogin.txtId.Text & "", id_con)
        id_read = id_com.ExecuteReader()
        If id_read.HasRows Then
            id_read.Read()
            lblRollNo.Text = id_read(0).ToString()
            lblName.Text = id_read(1).ToString()
            lblDept.Text = id_read(3).ToString()
            lblYear.Text = id_read(4).ToString()
            lblMob.Text = id_read(5).ToString()
            lblEmail.Text = id_read(6).ToString()
            If id_read(7).ToString <> "" Then
                date1 = id_read(7).ToString()
                date1.ToString("d")
                lblSchedule.Text = date1
                If Today.ToString("d") = date1 Then
                    lbl1.Hide()
                    btnTest.Enabled = True
                Else
                    lbl1.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub frmMainStudent_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Clearall()
        frmLogin.Show()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Me.Hide()
        frmTest.Show()
    End Sub
End Class