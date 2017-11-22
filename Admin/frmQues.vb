Public Class frmQues
    Private Sub frmQues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDBDataSet.Ques' table. You can move, or remove it, as needed.
        Me.QuesTableAdapter.Fill(Me.MainDBDataSet.Ques)
        'TODO: This line of code loads data into the 'MainDBDataSet.Ques' table. You can move, or remove it, as needed.
        Me.QuesTableAdapter.Fill(Me.MainDBDataSet.Ques)

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        QuesBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        QuesBindingSource.MoveNext()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        QuesBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        QuesBindingSource.EndEdit()
        QuesTableAdapter.Update(MainDBDataSet.Ques)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        QuesBindingSource.RemoveCurrent()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class