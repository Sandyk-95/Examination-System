<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQues
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opt1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opt2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opt3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opt4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnswerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDBDataSet = New ExaminationSystem.MainDBDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtQuesNo = New System.Windows.Forms.TextBox()
        Me.txtQues = New System.Windows.Forms.TextBox()
        Me.txtOpt1 = New System.Windows.Forms.TextBox()
        Me.txtOpt3 = New System.Windows.Forms.TextBox()
        Me.txtOpt2 = New System.Windows.Forms.TextBox()
        Me.txtOpt4 = New System.Windows.Forms.TextBox()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.QuesTableAdapter = New ExaminationSystem.MainDBDataSetTableAdapters.QuesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add/View Questions"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.QuestionDataGridViewTextBoxColumn, Me.Opt1DataGridViewTextBoxColumn, Me.Opt2DataGridViewTextBoxColumn, Me.Opt3DataGridViewTextBoxColumn, Me.Opt4DataGridViewTextBoxColumn, Me.AnswerDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QuesBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(925, 239)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "QuesNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "QuesNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'QuestionDataGridViewTextBoxColumn
        '
        Me.QuestionDataGridViewTextBoxColumn.DataPropertyName = "Question"
        Me.QuestionDataGridViewTextBoxColumn.HeaderText = "Question"
        Me.QuestionDataGridViewTextBoxColumn.Name = "QuestionDataGridViewTextBoxColumn"
        Me.QuestionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Opt1DataGridViewTextBoxColumn
        '
        Me.Opt1DataGridViewTextBoxColumn.DataPropertyName = "Opt1"
        Me.Opt1DataGridViewTextBoxColumn.HeaderText = "Opt1"
        Me.Opt1DataGridViewTextBoxColumn.Name = "Opt1DataGridViewTextBoxColumn"
        Me.Opt1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Opt2DataGridViewTextBoxColumn
        '
        Me.Opt2DataGridViewTextBoxColumn.DataPropertyName = "Opt2"
        Me.Opt2DataGridViewTextBoxColumn.HeaderText = "Opt2"
        Me.Opt2DataGridViewTextBoxColumn.Name = "Opt2DataGridViewTextBoxColumn"
        Me.Opt2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Opt3DataGridViewTextBoxColumn
        '
        Me.Opt3DataGridViewTextBoxColumn.DataPropertyName = "Opt3"
        Me.Opt3DataGridViewTextBoxColumn.HeaderText = "Opt3"
        Me.Opt3DataGridViewTextBoxColumn.Name = "Opt3DataGridViewTextBoxColumn"
        Me.Opt3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Opt4DataGridViewTextBoxColumn
        '
        Me.Opt4DataGridViewTextBoxColumn.DataPropertyName = "Opt4"
        Me.Opt4DataGridViewTextBoxColumn.HeaderText = "Opt4"
        Me.Opt4DataGridViewTextBoxColumn.Name = "Opt4DataGridViewTextBoxColumn"
        Me.Opt4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnswerDataGridViewTextBoxColumn
        '
        Me.AnswerDataGridViewTextBoxColumn.DataPropertyName = "Answer"
        Me.AnswerDataGridViewTextBoxColumn.HeaderText = "Answer"
        Me.AnswerDataGridViewTextBoxColumn.Name = "AnswerDataGridViewTextBoxColumn"
        Me.AnswerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuesBindingSource
        '
        Me.QuesBindingSource.DataMember = "Ques"
        Me.QuesBindingSource.DataSource = Me.MainDBDataSet
        '
        'MainDBDataSet
        '
        Me.MainDBDataSet.DataSetName = "MainDBDataSet"
        Me.MainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ques. no."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Question"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Option 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(512, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Option 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Option 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Option 4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(132, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Right Answer"
        '
        'txtQuesNo
        '
        Me.txtQuesNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuesBindingSource, "QuesNo", True))
        Me.txtQuesNo.Location = New System.Drawing.Point(88, 296)
        Me.txtQuesNo.Name = "txtQuesNo"
        Me.txtQuesNo.Size = New System.Drawing.Size(38, 26)
        Me.txtQuesNo.TabIndex = 1
        '
        'txtQues
        '
        Me.txtQues.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuesBindingSource, "Question", True))
        Me.txtQues.Location = New System.Drawing.Point(198, 296)
        Me.txtQues.Name = "txtQues"
        Me.txtQues.Size = New System.Drawing.Size(739, 26)
        Me.txtQues.TabIndex = 2
        '
        'txtOpt1
        '
        Me.txtOpt1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuesBindingSource, "Opt1", True))
        Me.txtOpt1.Location = New System.Drawing.Point(198, 328)
        Me.txtOpt1.Name = "txtOpt1"
        Me.txtOpt1.Size = New System.Drawing.Size(308, 26)
        Me.txtOpt1.TabIndex = 3
        '
        'txtOpt3
        '
        Me.txtOpt3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuesBindingSource, "Opt3", True))
        Me.txtOpt3.Location = New System.Drawing.Point(590, 328)
        Me.txtOpt3.Name = "txtOpt3"
        Me.txtOpt3.Size = New System.Drawing.Size(308, 26)
        Me.txtOpt3.TabIndex = 5
        '
        'txtOpt2
        '
        Me.txtOpt2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuesBindingSource, "Opt2", True))
        Me.txtOpt2.Location = New System.Drawing.Point(198, 368)
        Me.txtOpt2.Name = "txtOpt2"
        Me.txtOpt2.Size = New System.Drawing.Size(308, 26)
        Me.txtOpt2.TabIndex = 4
        '
        'txtOpt4
        '
        Me.txtOpt4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuesBindingSource, "Opt4", True))
        Me.txtOpt4.Location = New System.Drawing.Point(590, 368)
        Me.txtOpt4.Name = "txtOpt4"
        Me.txtOpt4.Size = New System.Drawing.Size(308, 26)
        Me.txtOpt4.TabIndex = 6
        '
        'txtAns
        '
        Me.txtAns.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuesBindingSource, "Answer", True))
        Me.txtAns.Location = New System.Drawing.Point(228, 408)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(308, 26)
        Me.txtAns.TabIndex = 7
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(822, 461)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 35)
        Me.BtnClose.TabIndex = 27
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(730, 461)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 35)
        Me.btnDel.TabIndex = 26
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(637, 461)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 35)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(822, 426)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 35)
        Me.btnNext.TabIndex = 24
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(730, 426)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(637, 426)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 35)
        Me.btnPrev.TabIndex = 22
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'QuesTableAdapter
        '
        Me.QuesTableAdapter.ClearBeforeFill = True
        '
        'frmQues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 508)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.txtOpt4)
        Me.Controls.Add(Me.txtOpt2)
        Me.Controls.Add(Me.txtOpt3)
        Me.Controls.Add(Me.txtOpt1)
        Me.Controls.Add(Me.txtQues)
        Me.Controls.Add(Me.txtQuesNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(965, 547)
        Me.MinimumSize = New System.Drawing.Size(965, 547)
        Me.Name = "frmQues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Questions"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtQuesNo As TextBox
    Friend WithEvents txtQues As TextBox
    Friend WithEvents txtOpt1 As TextBox
    Friend WithEvents txtOpt3 As TextBox
    Friend WithEvents txtOpt2 As TextBox
    Friend WithEvents txtOpt4 As TextBox
    Friend WithEvents txtAns As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents QuesNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuesnoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MainDBDataSet As MainDBDataSet
    Friend WithEvents QuesBindingSource As BindingSource
    Friend WithEvents QuesTableAdapter As MainDBDataSetTableAdapters.QuesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuestionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Opt1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Opt2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Opt3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Opt4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnswerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
