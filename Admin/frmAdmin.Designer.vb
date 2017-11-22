<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnAdminDetails = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnQues = New System.Windows.Forms.Button()
        Me.btnSI = New System.Windows.Forms.Button()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.lblAdminId = New System.Windows.Forms.Label()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Times New Roman", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(22, 10)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(243, 46)
        Me.lblAdmin.TabIndex = 0
        Me.lblAdmin.Text = "Admin Name"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Times New Roman", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(26, 59)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(72, 23)
        Me.lblSubject.TabIndex = 1
        Me.lblSubject.Text = "Subject"
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(581, 22)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(82, 34)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.btnAdminDetails)
        Me.pnl1.Controls.Add(Me.Button1)
        Me.pnl1.Controls.Add(Me.btnPassword)
        Me.pnl1.Controls.Add(Me.btnTest)
        Me.pnl1.Controls.Add(Me.btnQues)
        Me.pnl1.Controls.Add(Me.btnSI)
        Me.pnl1.Controls.Add(Me.btnAddAdmin)
        Me.pnl1.Controls.Add(Me.btnProfile)
        Me.pnl1.Controls.Add(Me.lblAdminId)
        Me.pnl1.Location = New System.Drawing.Point(20, 98)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(643, 397)
        Me.pnl1.TabIndex = 3
        '
        'btnAdminDetails
        '
        Me.btnAdminDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminDetails.Image = CType(resources.GetObject("btnAdminDetails.Image"), System.Drawing.Image)
        Me.btnAdminDetails.Location = New System.Drawing.Point(179, 61)
        Me.btnAdminDetails.Name = "btnAdminDetails"
        Me.btnAdminDetails.Size = New System.Drawing.Size(149, 150)
        Me.btnAdminDetails.TabIndex = 8
        Me.btnAdminDetails.Text = "Admin Details"
        Me.btnAdminDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdminDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdminDetails.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(480, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 150)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Results"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.Transparent
        Me.btnPassword.Image = CType(resources.GetObject("btnPassword.Image"), System.Drawing.Image)
        Me.btnPassword.Location = New System.Drawing.Point(334, 232)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(129, 150)
        Me.btnPassword.TabIndex = 6
        Me.btnPassword.Text = "Change Password"
        Me.btnPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.Transparent
        Me.btnTest.Image = CType(resources.GetObject("btnTest.Image"), System.Drawing.Image)
        Me.btnTest.Location = New System.Drawing.Point(179, 232)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(149, 150)
        Me.btnTest.TabIndex = 5
        Me.btnTest.Text = "Schedule Test"
        Me.btnTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'btnQues
        '
        Me.btnQues.BackColor = System.Drawing.Color.Transparent
        Me.btnQues.Image = CType(resources.GetObject("btnQues.Image"), System.Drawing.Image)
        Me.btnQues.Location = New System.Drawing.Point(31, 232)
        Me.btnQues.Name = "btnQues"
        Me.btnQues.Size = New System.Drawing.Size(129, 150)
        Me.btnQues.TabIndex = 4
        Me.btnQues.Text = "Add/View Questions"
        Me.btnQues.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnQues.UseVisualStyleBackColor = False
        '
        'btnSI
        '
        Me.btnSI.BackColor = System.Drawing.Color.Transparent
        Me.btnSI.Image = CType(resources.GetObject("btnSI.Image"), System.Drawing.Image)
        Me.btnSI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSI.Location = New System.Drawing.Point(489, 61)
        Me.btnSI.Name = "btnSI"
        Me.btnSI.Size = New System.Drawing.Size(124, 150)
        Me.btnSI.TabIndex = 3
        Me.btnSI.Text = "Student Info"
        Me.btnSI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSI.UseVisualStyleBackColor = False
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAdmin.Image = CType(resources.GetObject("btnAddAdmin.Image"), System.Drawing.Image)
        Me.btnAddAdmin.Location = New System.Drawing.Point(334, 61)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(129, 150)
        Me.btnAddAdmin.TabIndex = 2
        Me.btnAddAdmin.Text = "Add Admin"
        Me.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnProfile.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProfile.Location = New System.Drawing.Point(31, 61)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(129, 150)
        Me.btnProfile.TabIndex = 1
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'lblAdminId
        '
        Me.lblAdminId.AutoSize = True
        Me.lblAdminId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminId.Location = New System.Drawing.Point(19, 15)
        Me.lblAdminId.Name = "lblAdminId"
        Me.lblAdminId.Size = New System.Drawing.Size(49, 19)
        Me.lblAdminId.TabIndex = 0
        Me.lblAdminId.Text = "Admin"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 530)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblAdmin)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnl1 As Panel
    Friend WithEvents btnPassword As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnQues As Button
    Friend WithEvents btnSI As Button
    Friend WithEvents btnAddAdmin As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents lblAdminId As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAdminDetails As Button
End Class
