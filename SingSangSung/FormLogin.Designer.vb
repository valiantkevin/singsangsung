<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frLogin
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
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(293, 75)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(100, 22)
        Me.tbUsername.TabIndex = 0
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(293, 123)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(100, 22)
        Me.tbPassword.TabIndex = 1
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Location = New System.Drawing.Point(112, 80)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(73, 17)
        Me.lbUsername.TabIndex = 2
        Me.lbUsername.Text = "Username"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(112, 128)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(69, 17)
        Me.lbPassword.TabIndex = 3
        Me.lbPassword.Text = "Password"
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(115, 222)
        Me.btLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 23)
        Me.btLogin.TabIndex = 4
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(317, 222)
        Me.btExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(75, 23)
        Me.btExit.TabIndex = 5
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'frLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 293)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUsername)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lbUsername As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents btLogin As Button
    Friend WithEvents btExit As Button
End Class
