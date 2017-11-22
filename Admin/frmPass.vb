Imports System.Data.OleDb

Public Class frmPass
    Dim id_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MainDB.accdb;")
    Dim id_com As New OleDbCommand()

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Try
            If txtPass.Text <> "" And txtPass2.Text <> "" And txtPass.Text = txtPass2.Text Then
                id_con.Open()
                Dim str As String = "update Admin set Pass = '" & txtPass.Text & "' where Id ='" & frmAdmin.lblAdminId.Text & "' "
                Dim com As New OleDbCommand(str, id_con)
                com.ExecuteNonQuery()
                id_con.Close()
                MsgBox("Password is changed successfully")
            Else
                MsgBox("Passwords do not match", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class