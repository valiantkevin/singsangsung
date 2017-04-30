<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePass
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
        Me.lbOld = New System.Windows.Forms.Label()
        Me.lbNew1 = New System.Windows.Forms.Label()
        Me.lbNew2 = New System.Windows.Forms.Label()
        Me.tbOld = New System.Windows.Forms.TextBox()
        Me.tbNew1 = New System.Windows.Forms.TextBox()
        Me.tbNew2 = New System.Windows.Forms.TextBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbOld
        '
        Me.lbOld.AutoSize = True
        Me.lbOld.Location = New System.Drawing.Point(46, 51)
        Me.lbOld.Name = "lbOld"
        Me.lbOld.Size = New System.Drawing.Size(95, 17)
        Me.lbOld.TabIndex = 0
        Me.lbOld.Text = "Old Password"
        '
        'lbNew1
        '
        Me.lbNew1.AutoSize = True
        Me.lbNew1.Location = New System.Drawing.Point(45, 102)
        Me.lbNew1.Name = "lbNew1"
        Me.lbNew1.Size = New System.Drawing.Size(100, 17)
        Me.lbNew1.TabIndex = 1
        Me.lbNew1.Text = "New Password"
        '
        'lbNew2
        '
        Me.lbNew2.AutoSize = True
        Me.lbNew2.Location = New System.Drawing.Point(45, 148)
        Me.lbNew2.Name = "lbNew2"
        Me.lbNew2.Size = New System.Drawing.Size(152, 17)
        Me.lbNew2.TabIndex = 2
        Me.lbNew2.Text = "Confirm New Password"
        '
        'tbOld
        '
        Me.tbOld.Location = New System.Drawing.Point(217, 46)
        Me.tbOld.Name = "tbOld"
        Me.tbOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbOld.Size = New System.Drawing.Size(100, 22)
        Me.tbOld.TabIndex = 3
        '
        'tbNew1
        '
        Me.tbNew1.Location = New System.Drawing.Point(217, 97)
        Me.tbNew1.Name = "tbNew1"
        Me.tbNew1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNew1.Size = New System.Drawing.Size(100, 22)
        Me.tbNew1.TabIndex = 4
        '
        'tbNew2
        '
        Me.tbNew2.Location = New System.Drawing.Point(217, 147)
        Me.tbNew2.Name = "tbNew2"
        Me.tbNew2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNew2.Size = New System.Drawing.Size(100, 22)
        Me.tbNew2.TabIndex = 5
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(59, 193)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(108, 36)
        Me.btSave.TabIndex = 6
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(194, 193)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(108, 36)
        Me.btCancel.TabIndex = 7
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'FormChangePass
        '
        Me.AcceptButton = Me.btSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btCancel
        Me.ClientSize = New System.Drawing.Size(378, 253)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.tbNew2)
        Me.Controls.Add(Me.tbNew1)
        Me.Controls.Add(Me.tbOld)
        Me.Controls.Add(Me.lbNew2)
        Me.Controls.Add(Me.lbNew1)
        Me.Controls.Add(Me.lbOld)
        Me.Name = "FormChangePass"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbOld As Label
    Friend WithEvents lbNew1 As Label
    Friend WithEvents lbNew2 As Label
    Friend WithEvents tbOld As TextBox
    Friend WithEvents tbNew1 As TextBox
    Friend WithEvents tbNew2 As TextBox
    Friend WithEvents btSave As Button
    Friend WithEvents btCancel As Button
End Class
