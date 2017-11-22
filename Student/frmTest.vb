Imports System.Data.OleDb

Public Class frmTest

    Dim Data_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MainDB.accdb;")
    Dim Data_com As New OleDbCommand()
    Dim attempted As Integer = 0
    Dim Mrkobt As Integer = 0
    Dim hour, min, sec As Integer
    Dim n As Integer  'n=total questions
    Dim Ans As String
    Dim AttemptedQues(100) As Integer
    Dim SelectedOption(100) As String

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Data_read As OleDbDataReader
            Data_con.Open()
            Data_com = New OleDbCommand("Select * from Student where RollNo = " & frmLogin.txtId.Text & "", Data_con)
            Data_read = Data_com.ExecuteReader()
            If Data_read.HasRows Then
                Data_read.Read()
                lblhr.Text = Data_read(8).ToString()
                lblmin.Text = Data_read(9).ToString()
                lblsec.Text = Data_read(10).ToString()
                n = Data_read(11).ToString
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Data_con.Close()
        End Try
        Timer1.Start()

        hour = lblhr.Text
        min = lblmin.Text
        sec = lblsec.Text
        lblHour.Text = hour
        lblMinute.Text = min
        lblSeconds.Text = sec

        LoadQues()

        lblId.Text = frmLogin.txtId.Text
        lblName.Text = frmMainStudent.lblName.Text
        lblTotal_Ques.Text = n

    End Sub

    Public Sub LoadQues()
        Try
            Dim Data_read As OleDbDataReader
            Data_con.Open()
            Data_com = New OleDbCommand("Select * from  Ques where QuesNo =" & lblQuesNum.Text & "", Data_con)
            Data_read = Data_com.ExecuteReader()
            If Data_read.HasRows Then
                Data_read.Read()
                lblQues.Text = Data_read(1).ToString()
                RadioButton1.Text = Data_read(2).ToString()
                RadioButton2.Text = Data_read(3).ToString()
                RadioButton3.Text = Data_read(4).ToString()
                RadioButton4.Text = Data_read(5).ToString()
                Ans = Data_read(6).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Data_con.Close()
        End Try
        'Radio()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked Or RadioButton4.Checked Then
            Try
                If attempted <= lblTotal_Ques.Text Then
                    attempted += 1
                    lblAttempted.Text = attempted
                    lblRemaining.Text = n - attempted
                    Dim bc As String
                    If RadioButton1.Checked = True Then
                        bc = RadioButton1.Text
                    ElseIf RadioButton2.Checked = True Then
                        bc = RadioButton2.Text
                    ElseIf RadioButton3.Checked = True Then
                        bc = RadioButton3.Text
                    ElseIf RadioButton4.Checked = True Then
                        bc = RadioButton4.Text
                    Else
                        bc = 0
                    End If
                    If Ans = bc Then
                        Mrkobt += 1
                    End If
                    AttemptedQues(lblQuesNum.Text) = lblQuesNum.Text
                    SelectedOption(lblQuesNum.Text) = bc
                Else
                    EndExam()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Data_con.Close()
            End Try

            NextQues()
            LoadQues()
        Else
            MsgBox("Please select an option")
        End If
    End Sub

    Public Sub Reset()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

    Public Sub EndExam()
        If MsgBox("Do you want to End This Examination (Y/N)?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Evaluation()
            Me.Close()
            frmResult.Show()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        NextQues()
        LoadQues()
        Radio()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        PrevQues()
        LoadQues()
        Reset()
        Radio()
    End Sub

    Public Sub NextQues()
        If lblTotal_Ques.Text = lblAttempted.Text Then
            MsgBox("You have successfully submitted answers to all questions. Click End Examination to end your Exam !!!!")
        End If
        If lblQuesNum.Text < n Then
            Dim inc As Integer = lblQuesNum.Text
            lblQuesNum.Text = inc + 1
            btnNext.Enabled = True
            btnPrev.Enabled = True
            Reset()
        Else
            btnNext.Enabled = False
        End If
    End Sub

    Public Sub PrevQues()
        If lblQuesNum.Text > 1 Then
            Dim inc As Integer = lblQuesNum.Text
            lblQuesNum.Text = inc - 1
            btnPrev.Enabled = True
            btnNext.Enabled = True
        Else
            btnPrev.Enabled = False
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        EndExam()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If sec > 0 Then
            sec -= 1
        ElseIf min > 0 Then
            sec = 60
            min -= 1
        ElseIf hour > 0 Then
            min = 60
            hour -= 1
        End If
        lblHour.Text = hour
        lblMinute.Text = min
        lblSeconds.Text = sec
        If min = 5 And sec = 0 Then
            MsgBox("You have last five minutes remaining , Please hurry up!!!!!!")
        ElseIf min = 0 And sec = 0 Then
            Timer1.Stop()
            MsgBox("Your time is up!!")
            Evaluation()
            Me.Close()
            frmResult.Show()
        End If
    End Sub

    Public Sub Evaluation()
        Try
            Data_con.Open()
            Dim str As String = "insert into Result values(" & frmMainStudent.lblRollNo.Text & ", '" & frmMainStudent.lblName.Text & "', '" & frmMainStudent.lblYear.Text & "', '" & frmMainStudent.lblDept.Text & "',  " & n & ", " & attempted & ", " & Mrkobt & ", " & Mrkobt & ")"
            Dim com As New OleDbCommand(str, Data_con)
            com.ExecuteNonQuery()
            Data_con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Data_con.Close()
        End Try
    End Sub

    Public Sub Radio()
        For i As Integer = 1 To lblQuesNum.Text Step 1
            If AttemptedQues(i) = lblQuesNum.Text And (SelectedOption(i) = RadioButton1.Text Or SelectedOption(i) = RadioButton2.Text Or SelectedOption(i) = RadioButton3.Text Or SelectedOption(i) = RadioButton4.Text) Then
                If SelectedOption(i) = RadioButton1.Text Then
                    RadioButton1.Checked = True
                ElseIf SelectedOption(i) = RadioButton2.Text Then
                    RadioButton2.Checked = True
                ElseIf SelectedOption(i) = RadioButton3.Text Then
                    RadioButton3.Checked = True
                ElseIf SelectedOption(i) = RadioButton4.Text Then
                    RadioButton4.Checked = True
                End If
                btnSubmit.Enabled = False
            Else
                btnSubmit.Enabled = True
            End If
        Next
    End Sub
End Class