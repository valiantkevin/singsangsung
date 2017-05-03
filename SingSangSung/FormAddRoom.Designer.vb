<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddRoom
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
        Me.tbRoom = New System.Windows.Forms.TextBox()
        Me.cbClass = New System.Windows.Forms.ComboBox()
        Me.lbRoom = New System.Windows.Forms.Label()
        Me.lbClass = New System.Windows.Forms.Label()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbRoom
        '
        Me.tbRoom.Location = New System.Drawing.Point(134, 50)
        Me.tbRoom.Name = "tbRoom"
        Me.tbRoom.Size = New System.Drawing.Size(121, 22)
        Me.tbRoom.TabIndex = 0
        '
        'cbClass
        '
        Me.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClass.FormattingEnabled = True
        Me.cbClass.Location = New System.Drawing.Point(134, 116)
        Me.cbClass.Name = "cbClass"
        Me.cbClass.Size = New System.Drawing.Size(121, 24)
        Me.cbClass.TabIndex = 1
        '
        'lbRoom
        '
        Me.lbRoom.AutoSize = True
        Me.lbRoom.Location = New System.Drawing.Point(40, 53)
        Me.lbRoom.Name = "lbRoom"
        Me.lbRoom.Size = New System.Drawing.Size(62, 17)
        Me.lbRoom.TabIndex = 2
        Me.lbRoom.Text = "Room ID"
        '
        'lbClass
        '
        Me.lbClass.AutoSize = True
        Me.lbClass.Location = New System.Drawing.Point(50, 116)
        Me.lbClass.Name = "lbClass"
        Me.lbClass.Size = New System.Drawing.Size(42, 17)
        Me.lbClass.TabIndex = 3
        Me.lbClass.Text = "Class"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(53, 193)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 4
        Me.btAdd.Text = "Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(167, 193)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 5
        Me.btCancel.Text = "Finish"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'FormAddRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 253)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.lbClass)
        Me.Controls.Add(Me.lbRoom)
        Me.Controls.Add(Me.cbClass)
        Me.Controls.Add(Me.tbRoom)
        Me.Name = "FormAddRoom"
        Me.Text = "FormAddRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbRoom As TextBox
    Friend WithEvents cbClass As ComboBox
    Friend WithEvents lbRoom As Label
    Friend WithEvents lbClass As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents btCancel As Button
End Class
