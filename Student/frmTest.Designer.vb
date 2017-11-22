<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTest))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.lblhr = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAttempted = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal_Ques = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblQuesNum = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblQues = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 126)
        Me.Panel1.TabIndex = 61
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblName.Location = New System.Drawing.Point(168, 47)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 19)
        Me.lblName.TabIndex = 61
        Me.lblName.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(22, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 19)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblsec)
        Me.Panel2.Controls.Add(Me.lblhr)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lblmin)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblSeconds)
        Me.Panel2.Controls.Add(Me.lblHour)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblMinute)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblRemaining)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblAttempted)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblTotal_Ques)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(491, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 115)
        Me.Panel2.TabIndex = 58
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.BackColor = System.Drawing.Color.Transparent
        Me.lblsec.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblsec.Location = New System.Drawing.Point(393, 36)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(25, 19)
        Me.lblsec.TabIndex = 74
        Me.lblsec.Text = "00"
        '
        'lblhr
        '
        Me.lblhr.AutoSize = True
        Me.lblhr.BackColor = System.Drawing.Color.Transparent
        Me.lblhr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblhr.Location = New System.Drawing.Point(282, 36)
        Me.lblhr.Name = "lblhr"
        Me.lblhr.Size = New System.Drawing.Size(25, 19)
        Me.lblhr.TabIndex = 70
        Me.lblhr.Text = "00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(371, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 19)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(315, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 19)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = ":"
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.BackColor = System.Drawing.Color.Transparent
        Me.lblmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblmin.Location = New System.Drawing.Point(338, 36)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(25, 19)
        Me.lblmin.TabIndex = 72
        Me.lblmin.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(269, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Total Time "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(268, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 19)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Remaining Time "
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.BackColor = System.Drawing.Color.Transparent
        Me.lblSeconds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSeconds.Location = New System.Drawing.Point(393, 83)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(25, 19)
        Me.lblSeconds.TabIndex = 68
        Me.lblSeconds.Text = "00"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.BackColor = System.Drawing.Color.Transparent
        Me.lblHour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHour.Location = New System.Drawing.Point(282, 85)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(25, 19)
        Me.lblHour.TabIndex = 64
        Me.lblHour.Text = "00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(371, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 19)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(315, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 19)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = ":"
        '
        'lblMinute
        '
        Me.lblMinute.AutoSize = True
        Me.lblMinute.BackColor = System.Drawing.Color.Transparent
        Me.lblMinute.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinute.Location = New System.Drawing.Point(336, 83)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(25, 19)
        Me.lblMinute.TabIndex = 66
        Me.lblMinute.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(16, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Questions Remaining"
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.BackColor = System.Drawing.Color.Transparent
        Me.lblRemaining.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRemaining.Location = New System.Drawing.Point(220, 81)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(25, 19)
        Me.lblRemaining.TabIndex = 50
        Me.lblRemaining.Text = "00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(16, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 19)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Questions Attempted"
        '
        'lblAttempted
        '
        Me.lblAttempted.AutoSize = True
        Me.lblAttempted.BackColor = System.Drawing.Color.Transparent
        Me.lblAttempted.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAttempted.Location = New System.Drawing.Point(220, 46)
        Me.lblAttempted.Name = "lblAttempted"
        Me.lblAttempted.Size = New System.Drawing.Size(25, 19)
        Me.lblAttempted.TabIndex = 48
        Me.lblAttempted.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Total Questions"
        '
        'lblTotal_Ques
        '
        Me.lblTotal_Ques.AutoSize = True
        Me.lblTotal_Ques.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal_Ques.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotal_Ques.Location = New System.Drawing.Point(220, 10)
        Me.lblTotal_Ques.Name = "lblTotal_Ques"
        Me.lblTotal_Ques.Size = New System.Drawing.Size(25, 19)
        Me.lblTotal_Ques.TabIndex = 46
        Me.lblTotal_Ques.Text = "00"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblId.Location = New System.Drawing.Point(168, 7)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 19)
        Me.lblId.TabIndex = 47
        Me.lblId.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(22, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Roll No."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.btnEnd)
        Me.Panel4.Controls.Add(Me.lblQuesNum)
        Me.Panel4.Controls.Add(Me.btnPrev)
        Me.Panel4.Controls.Add(Me.btnNext)
        Me.Panel4.Controls.Add(Me.btnSubmit)
        Me.Panel4.Controls.Add(Me.RadioButton4)
        Me.Panel4.Controls.Add(Me.RadioButton3)
        Me.Panel4.Controls.Add(Me.RadioButton2)
        Me.Panel4.Controls.Add(Me.RadioButton1)
        Me.Panel4.Controls.Add(Me.lblQues)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 126)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(936, 436)
        Me.Panel4.TabIndex = 62
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnd.AutoSize = True
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnEnd.FlatAppearance.BorderSize = 0
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.ForeColor = System.Drawing.Color.White
        Me.btnEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEnd.Location = New System.Drawing.Point(699, 318)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(172, 37)
        Me.btnEnd.TabIndex = 49
        Me.btnEnd.Text = "End Examination"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblQuesNum
        '
        Me.lblQuesNum.AutoSize = True
        Me.lblQuesNum.BackColor = System.Drawing.Color.Transparent
        Me.lblQuesNum.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuesNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuesNum.Location = New System.Drawing.Point(353, 106)
        Me.lblQuesNum.Name = "lblQuesNum"
        Me.lblQuesNum.Size = New System.Drawing.Size(19, 23)
        Me.lblQuesNum.TabIndex = 48
        Me.lblQuesNum.Text = "1"
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrev.AutoSize = True
        Me.btnPrev.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPrev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrev.Location = New System.Drawing.Point(576, 322)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(94, 29)
        Me.btnPrev.TabIndex = 47
        Me.btnPrev.Text = "Previous "
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(478, 322)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 29)
        Me.btnNext.TabIndex = 46
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSubmit.Location = New System.Drawing.Point(381, 322)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(78, 29)
        Me.btnSubmit.TabIndex = 44
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton4.Location = New System.Drawing.Point(356, 231)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(132, 27)
        Me.RadioButton4.TabIndex = 43
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton3.Location = New System.Drawing.Point(356, 200)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(132, 27)
        Me.RadioButton3.TabIndex = 42
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton2.Location = New System.Drawing.Point(356, 169)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(132, 27)
        Me.RadioButton2.TabIndex = 41
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton1.Location = New System.Drawing.Point(356, 138)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(132, 27)
        Me.RadioButton1.TabIndex = 40
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'lblQues
        '
        Me.lblQues.AutoSize = True
        Me.lblQues.BackColor = System.Drawing.Color.Transparent
        Me.lblQues.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblQues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQues.Location = New System.Drawing.Point(377, 106)
        Me.lblQues.Name = "lblQues"
        Me.lblQues.Size = New System.Drawing.Size(79, 23)
        Me.lblQues.TabIndex = 39
        Me.lblQues.Text = "Question"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblsec As Label
    Friend WithEvents lblhr As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblmin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMinute As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblRemaining As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAttempted As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal_Ques As Label
    Friend WithEvents lblId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblQuesNum As Label
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblQues As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnEnd As Button
End Class
