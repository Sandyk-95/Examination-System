Imports System.Data.OleDb

Public Class frmLogin

    Dim id_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MainDB.accdb;")
    Dim id_com As New OleDbCommand()

    Public Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            If txtId.Text <> "" And txtPass.Text <> "" And lstType.SelectedItem IsNot "" Then
                Dim id_read As OleDbDataReader
                id_con.Open()
                If lstType.SelectedItem = "Admin" Then
                    id_com = New OleDbCommand("Select * from Admin where Id ='" & txtId.Text & "'", id_con)
                    id_read = id_com.ExecuteReader()
                    If id_read.HasRows Then
                        id_read.Read()
                        If txtPass.Text = id_read(5).ToString() And txtId.Text = "Admin" Then
                            Me.Hide()
                            frmAdmin.btnAddAdmin.Enabled = True
                            frmAdmin.Show()
                        ElseIf txtPass.Text = id_read(5).ToString() And txtId.Text = id_read(0).ToString Then
                            Me.Hide()
                            frmAdmin.btnAddAdmin.Enabled = False
                            frmAdmin.btnAdminDetails.Enabled = False
                            frmAdmin.Show()
                        Else
                            MsgBox("Please enter correct Id or Password")
                            Clearall()
                        End If
                    End If
                ElseIf lstType.SelectedItem = "Student" Then
                    id_com = New OleDbCommand("Select * from Student where RollNo =" & txtId.Text & "", id_con)
                    id_read = id_com.ExecuteReader()
                    If id_read.HasRows Then
                        id_read.Read()
                        If txtPass.Text = id_read(2).ToString() Then
                            Me.Hide()
                            frmMainStudent.Show()
                        Else
                            MsgBox("Please enter correct Id or Password")
                            Clearall()
                        End If
                    End If
                Else
                    MsgBox("Please select login type", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "")
                End If
            Else
                MsgBox("Fill in Id and password fields", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            id_con.Close()
        End Try
    End Sub

    Public Sub Clearall()
        txtId.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clearall()
    End Sub
End Class
