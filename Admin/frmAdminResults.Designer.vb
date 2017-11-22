<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminResults
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RollNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalQuesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttemptedQuesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RightAnswersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarksObtainedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDBDataSet = New ExaminationSystem.MainDBDataSet()
        Me.ResultTableAdapter = New ExaminationSystem.MainDBDataSetTableAdapters.ResultTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollNoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CurrentYearDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.TotalQuesDataGridViewTextBoxColumn, Me.AttemptedQuesDataGridViewTextBoxColumn, Me.RightAnswersDataGridViewTextBoxColumn, Me.MarksObtainedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ResultBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(843, 391)
        Me.DataGridView1.TabIndex = 0
        '
        'RollNoDataGridViewTextBoxColumn
        '
        Me.RollNoDataGridViewTextBoxColumn.DataPropertyName = "RollNo"
        Me.RollNoDataGridViewTextBoxColumn.HeaderText = "RollNo"
        Me.RollNoDataGridViewTextBoxColumn.Name = "RollNoDataGridViewTextBoxColumn"
        Me.RollNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrentYearDataGridViewTextBoxColumn
        '
        Me.CurrentYearDataGridViewTextBoxColumn.DataPropertyName = "Current_Year"
        Me.CurrentYearDataGridViewTextBoxColumn.HeaderText = "Current_Year"
        Me.CurrentYearDataGridViewTextBoxColumn.Name = "CurrentYearDataGridViewTextBoxColumn"
        Me.CurrentYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "Dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "Dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        Me.DeptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalQuesDataGridViewTextBoxColumn
        '
        Me.TotalQuesDataGridViewTextBoxColumn.DataPropertyName = "Total_Ques"
        Me.TotalQuesDataGridViewTextBoxColumn.HeaderText = "Total_Ques"
        Me.TotalQuesDataGridViewTextBoxColumn.Name = "TotalQuesDataGridViewTextBoxColumn"
        Me.TotalQuesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttemptedQuesDataGridViewTextBoxColumn
        '
        Me.AttemptedQuesDataGridViewTextBoxColumn.DataPropertyName = "Attempted_Ques"
        Me.AttemptedQuesDataGridViewTextBoxColumn.HeaderText = "Attempted_Ques"
        Me.AttemptedQuesDataGridViewTextBoxColumn.Name = "AttemptedQuesDataGridViewTextBoxColumn"
        Me.AttemptedQuesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RightAnswersDataGridViewTextBoxColumn
        '
        Me.RightAnswersDataGridViewTextBoxColumn.DataPropertyName = "Right_Answers"
        Me.RightAnswersDataGridViewTextBoxColumn.HeaderText = "Right_Answers"
        Me.RightAnswersDataGridViewTextBoxColumn.Name = "RightAnswersDataGridViewTextBoxColumn"
        Me.RightAnswersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarksObtainedDataGridViewTextBoxColumn
        '
        Me.MarksObtainedDataGridViewTextBoxColumn.DataPropertyName = "Marks_Obtained"
        Me.MarksObtainedDataGridViewTextBoxColumn.HeaderText = "Marks_Obtained"
        Me.MarksObtainedDataGridViewTextBoxColumn.Name = "MarksObtainedDataGridViewTextBoxColumn"
        Me.MarksObtainedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResultBindingSource
        '
        Me.ResultBindingSource.DataMember = "Result"
        Me.ResultBindingSource.DataSource = Me.MainDBDataSet
        '
        'MainDBDataSet
        '
        Me.MainDBDataSet.DataSetName = "MainDBDataSet"
        Me.MainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResultTableAdapter
        '
        Me.ResultTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Results"
        '
        'frmAdminResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 455)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAdminResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Results"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MainDBDataSet As MainDBDataSet
    Friend WithEvents ResultBindingSource As BindingSource
    Friend WithEvents ResultTableAdapter As MainDBDataSetTableAdapters.ResultTableAdapter
    Friend WithEvents RollNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalQuesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttemptedQuesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RightAnswersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarksObtainedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
