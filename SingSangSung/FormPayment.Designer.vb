<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayment
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
        Me.lbPaymentID = New System.Windows.Forms.Label()
        Me.lbCustomer = New System.Windows.Forms.Label()
        Me.lbRoomNumber = New System.Windows.Forms.Label()
        Me.lbRoomClass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbPaymentID
        '
        Me.lbPaymentID.AutoSize = True
        Me.lbPaymentID.Location = New System.Drawing.Point(189, 9)
        Me.lbPaymentID.Name = "lbPaymentID"
        Me.lbPaymentID.Size = New System.Drawing.Size(82, 13)
        Me.lbPaymentID.TabIndex = 0
        Me.lbPaymentID.Text = "Payment #1234"
        '
        'lbCustomer
        '
        Me.lbCustomer.AutoSize = True
        Me.lbCustomer.Location = New System.Drawing.Point(189, 46)
        Me.lbCustomer.Name = "lbCustomer"
        Me.lbCustomer.Size = New System.Drawing.Size(85, 13)
        Me.lbCustomer.TabIndex = 1
        Me.lbCustomer.Text = "Customer : Gaby"
        '
        'lbRoomNumber
        '
        Me.lbRoomNumber.AutoSize = True
        Me.lbRoomNumber.Location = New System.Drawing.Point(209, 65)
        Me.lbRoomNumber.Name = "lbRoomNumber"
        Me.lbRoomNumber.Size = New System.Drawing.Size(44, 13)
        Me.lbRoomNumber.TabIndex = 2
        Me.lbRoomNumber.Text = "Room 1"
        '
        'lbRoomClass
        '
        Me.lbRoomClass.AutoSize = True
        Me.lbRoomClass.Location = New System.Drawing.Point(218, 85)
        Me.lbRoomClass.Name = "lbRoomClass"
        Me.lbRoomClass.Size = New System.Drawing.Size(24, 13)
        Me.lbRoomClass.TabIndex = 3
        Me.lbRoomClass.Text = "VIP"
        '
        'FormPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 274)
        Me.Controls.Add(Me.lbRoomClass)
        Me.Controls.Add(Me.lbRoomNumber)
        Me.Controls.Add(Me.lbCustomer)
        Me.Controls.Add(Me.lbPaymentID)
        Me.Name = "FormPayment"
        Me.Text = "FormPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPaymentID As Label
    Friend WithEvents lbCustomer As Label
    Friend WithEvents lbRoomNumber As Label
    Friend WithEvents lbRoomClass As Label
End Class
