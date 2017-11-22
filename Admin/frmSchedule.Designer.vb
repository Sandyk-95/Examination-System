<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedule
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTestDate = New System.Windows.Forms.DateTimePicker()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDBDataSet = New ExaminationSystem.MainDBDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RollNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalQuesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRollNo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.StudentTableAdapter = New ExaminationSystem.MainDBDataSetTableAdapters.StudentTableAdapter()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schedule Test"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Test Date"
        '
        'dtpTestDate
        '
        Me.dtpTestDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Test Date", True))
        Me.dtpTestDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTestDate.Location = New System.Drawing.Point(105, 300)
        Me.dtpTestDate.Name = "dtpTestDate"
        Me.dtpTestDate.Size = New System.Drawing.Size(149, 26)
        Me.dtpTestDate.TabIndex = 2
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.MainDBDataSet
        '
        'MainDBDataSet
        '
        Me.MainDBDataSet.DataSetName = "MainDBDataSet"
        Me.MainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollNoDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.CurrentYearDataGridViewTextBoxColumn, Me.TestDateDataGridViewTextBoxColumn, Me.HourDataGridViewTextBoxColumn, Me.MinDataGridViewTextBoxColumn, Me.SecDataGridViewTextBoxColumn, Me.TotalQuesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(946, 177)
        Me.DataGridView1.TabIndex = 3
        '
        'RollNoDataGridViewTextBoxColumn
        '
        Me.RollNoDataGridViewTextBoxColumn.DataPropertyName = "RollNo"
        Me.RollNoDataGridViewTextBoxColumn.HeaderText = "RollNo"
        Me.RollNoDataGridViewTextBoxColumn.Name = "RollNoDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "Dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "Dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        '
        'CurrentYearDataGridViewTextBoxColumn
        '
        Me.CurrentYearDataGridViewTextBoxColumn.DataPropertyName = "Current Year"
        Me.CurrentYearDataGridViewTextBoxColumn.HeaderText = "Current Year"
        Me.CurrentYearDataGridViewTextBoxColumn.Name = "CurrentYearDataGridViewTextBoxColumn"
        '
        'TestDateDataGridViewTextBoxColumn
        '
        Me.TestDateDataGridViewTextBoxColumn.DataPropertyName = "Test Date"
        Me.TestDateDataGridViewTextBoxColumn.HeaderText = "Test Date"
        Me.TestDateDataGridViewTextBoxColumn.Name = "TestDateDataGridViewTextBoxColumn"
        '
        'HourDataGridViewTextBoxColumn
        '
        Me.HourDataGridViewTextBoxColumn.DataPropertyName = "hour"
        Me.HourDataGridViewTextBoxColumn.HeaderText = "hour"
        Me.HourDataGridViewTextBoxColumn.Name = "HourDataGridViewTextBoxColumn"
        '
        'MinDataGridViewTextBoxColumn
        '
        Me.MinDataGridViewTextBoxColumn.DataPropertyName = "min"
        Me.MinDataGridViewTextBoxColumn.HeaderText = "min"
        Me.MinDataGridViewTextBoxColumn.Name = "MinDataGridViewTextBoxColumn"
        '
        'SecDataGridViewTextBoxColumn
        '
        Me.SecDataGridViewTextBoxColumn.DataPropertyName = "sec"
        Me.SecDataGridViewTextBoxColumn.HeaderText = "sec"
        Me.SecDataGridViewTextBoxColumn.Name = "SecDataGridViewTextBoxColumn"
        '
        'TotalQuesDataGridViewTextBoxColumn
        '
        Me.TotalQuesDataGridViewTextBoxColumn.DataPropertyName = "Total_Ques"
        Me.TotalQuesDataGridViewTextBoxColumn.HeaderText = "Total_Ques"
        Me.TotalQuesDataGridViewTextBoxColumn.Name = "TotalQuesDataGridViewTextBoxColumn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Roll No."
        '
        'lblRollNo
        '
        Me.lblRollNo.AutoSize = True
        Me.lblRollNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "RollNo", True))
        Me.lblRollNo.Location = New System.Drawing.Point(99, 248)
        Me.lblRollNo.Name = "lblRollNo"
        Me.lblRollNo.Size = New System.Drawing.Size(61, 19)
        Me.lblRollNo.TabIndex = 5
        Me.lblRollNo.Text = "Roll No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Name"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Full Name", True))
        Me.lblName.Location = New System.Drawing.Point(101, 274)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 19)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'btnSchedule
        '
        Me.btnSchedule.Location = New System.Drawing.Point(413, 349)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(168, 29)
        Me.btnSchedule.TabIndex = 8
        Me.btnSchedule.Text = "Schedule Test"
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(251, 350)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 28)
        Me.btnPrev.TabIndex = 9
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(332, 350)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 28)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Time"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "hour", True))
        Me.TextBox1.Location = New System.Drawing.Point(413, 245)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(73, 26)
        Me.TextBox1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(356, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Hours"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(492, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Minutes"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "min", True))
        Me.TextBox2.Location = New System.Drawing.Point(549, 245)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(73, 26)
        Me.TextBox2.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(630, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Seconds"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "sec", True))
        Me.TextBox3.Location = New System.Drawing.Point(694, 245)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(73, 26)
        Me.TextBox3.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(297, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total Questions"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Total_Ques", True))
        Me.TextBox4.Location = New System.Drawing.Point(413, 283)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(73, 26)
        Me.TextBox4.TabIndex = 18
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 389)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRollNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtpTestDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Test"
        Me.TopMost = True
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTestDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRollNo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnSchedule As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents MainDBDataSet As MainDBDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As MainDBDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents RollNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalQuesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
