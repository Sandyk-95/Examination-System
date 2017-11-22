Public Class frmSchedule
    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDBDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.MainDBDataSet.Student)
        'TODO: This line of code loads data into the 'MainDBDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.MainDBDataSet.Student)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        StudentBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        StudentBindingSource.MoveNext()
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        StudentBindingSource.EndEdit()
        StudentTableAdapter.Update(MainDBDataSet.Student)
    End Sub
End Class