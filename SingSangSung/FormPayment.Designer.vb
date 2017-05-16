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
        Me.lbTime = New System.Windows.Forms.Label()
        Me.lbLength = New System.Windows.Forms.Label()
        Me.lbRoomPrice = New System.Windows.Forms.Label()
        Me.btConfirm = New System.Windows.Forms.Button()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbPaymentID
        '
        Me.lbPaymentID.AutoSize = True
        Me.lbPaymentID.Location = New System.Drawing.Point(13, 9)
        Me.lbPaymentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPaymentID.Name = "lbPaymentID"
        Me.lbPaymentID.Size = New System.Drawing.Size(107, 17)
        Me.lbPaymentID.TabIndex = 0
        Me.lbPaymentID.Text = "Payment #1234"
        '
        'lbCustomer
        '
        Me.lbCustomer.AutoSize = True
        Me.lbCustomer.Location = New System.Drawing.Point(13, 91)
        Me.lbCustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCustomer.Name = "lbCustomer"
        Me.lbCustomer.Size = New System.Drawing.Size(114, 17)
        Me.lbCustomer.TabIndex = 1
        Me.lbCustomer.Text = "Customer : Gaby"
        '
        'lbRoomNumber
        '
        Me.lbRoomNumber.AutoSize = True
        Me.lbRoomNumber.Location = New System.Drawing.Point(13, 126)
        Me.lbRoomNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRoomNumber.Name = "lbRoomNumber"
        Me.lbRoomNumber.Size = New System.Drawing.Size(57, 17)
        Me.lbRoomNumber.TabIndex = 2
        Me.lbRoomNumber.Text = "Room 1"
        '
        'lbRoomClass
        '
        Me.lbRoomClass.AutoSize = True
        Me.lbRoomClass.Location = New System.Drawing.Point(112, 126)
        Me.lbRoomClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRoomClass.Name = "lbRoomClass"
        Me.lbRoomClass.Size = New System.Drawing.Size(29, 17)
        Me.lbRoomClass.TabIndex = 3
        Me.lbRoomClass.Text = "VIP"
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Location = New System.Drawing.Point(13, 35)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(51, 17)
        Me.lbTime.TabIndex = 4
        Me.lbTime.Text = "Label1"
        '
        'lbLength
        '
        Me.lbLength.AutoSize = True
        Me.lbLength.Location = New System.Drawing.Point(209, 126)
        Me.lbLength.Name = "lbLength"
        Me.lbLength.Size = New System.Drawing.Size(51, 17)
        Me.lbLength.TabIndex = 5
        Me.lbLength.Text = "Label1"
        '
        'lbRoomPrice
        '
        Me.lbRoomPrice.AutoSize = True
        Me.lbRoomPrice.Location = New System.Drawing.Point(467, 126)
        Me.lbRoomPrice.Name = "lbRoomPrice"
        Me.lbRoomPrice.Size = New System.Drawing.Size(51, 17)
        Me.lbRoomPrice.TabIndex = 6
        Me.lbRoomPrice.Text = "Label1"
        '
        'btConfirm
        '
        Me.btConfirm.Location = New System.Drawing.Point(183, 555)
        Me.btConfirm.Name = "btConfirm"
        Me.btConfirm.Size = New System.Drawing.Size(145, 30)
        Me.btConfirm.TabIndex = 7
        Me.btConfirm.Text = "Confirm Payment"
        Me.btConfirm.UseVisualStyleBackColor = True
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(199, 509)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(51, 17)
        Me.lbTotal.TabIndex = 8
        Me.lbTotal.Text = "Label1"
        '
        'FormPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 597)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.btConfirm)
        Me.Controls.Add(Me.lbRoomPrice)
        Me.Controls.Add(Me.lbLength)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.lbRoomClass)
        Me.Controls.Add(Me.lbRoomNumber)
        Me.Controls.Add(Me.lbCustomer)
        Me.Controls.Add(Me.lbPaymentID)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPayment"
        Me.Text = "FormPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPaymentID As Label
    Friend WithEvents lbCustomer As Label
    Friend WithEvents lbRoomNumber As Label
    Friend WithEvents lbRoomClass As Label
    Friend WithEvents lbTime As Label
    Friend WithEvents lbLength As Label
    Friend WithEvents lbRoomPrice As Label
    Friend WithEvents btConfirm As Button
    Friend WithEvents lbTotal As Label
End Class
