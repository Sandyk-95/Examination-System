Public Class frmAdminResults
    Private Sub frmAdminResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDBDataSet.Result' table. You can move, or remove it, as needed.
        Me.ResultTableAdapter.Fill(Me.MainDBDataSet.Result)

    End Sub
End Class