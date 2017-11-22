Public Class frmAdminDetails
    Private Sub frmAdminDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDBDataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.MainDBDataSet.Admin)

    End Sub
End Class