<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsernameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btPayment = New System.Windows.Forms.Button()
        Me.pnFnB = New System.Windows.Forms.Panel()
        Me.lbTotalPrice = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.btInsert = New System.Windows.Forms.Button()
        Me.lvFnB = New System.Windows.Forms.ListView()
        Me.chPortion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbPortion = New System.Windows.Forms.TextBox()
        Me.lbFnB = New System.Windows.Forms.Label()
        Me.tbFnBCode = New System.Windows.Forms.TextBox()
        Me.pnRoomOrder = New System.Windows.Forms.Panel()
        Me.btOrderRoom = New System.Windows.Forms.Button()
        Me.cbAddTime = New System.Windows.Forms.ComboBox()
        Me.lbAddTime = New System.Windows.Forms.Label()
        Me.tbCustomerName = New System.Windows.Forms.TextBox()
        Me.lbCustomerName = New System.Windows.Forms.Label()
        Me.pnTime = New System.Windows.Forms.Panel()
        Me.lbTimeLeft = New System.Windows.Forms.Label()
        Me.lbRoomPrice = New System.Windows.Forms.Label()
        Me.lbRoomClass = New System.Windows.Forms.Label()
        Me.lbRoomNumber = New System.Windows.Forms.Label()
        Me.pnRoomInfo = New System.Windows.Forms.Panel()
        Me.lbRoomCapacity = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnFnB.SuspendLayout()
        Me.pnRoomOrder.SuspendLayout()
        Me.pnTime.SuspendLayout()
        Me.pnRoomInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsernameToolStripMenuItem, Me.AdministratorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1357, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsernameToolStripMenuItem
        '
        Me.UsernameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.UsernameToolStripMenuItem.Name = "UsernameToolStripMenuItem"
        Me.UsernameToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.UsernameToolStripMenuItem.Text = "Username"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(137, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btPayment)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnFnB)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnRoomOrder)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnTime)
        Me.SplitContainer1.Size = New System.Drawing.Size(1357, 537)
        Me.SplitContainer1.SplitterDistance = 329
        Me.SplitContainer1.TabIndex = 1
        '
        'btPayment
        '
        Me.btPayment.Location = New System.Drawing.Point(481, 492)
        Me.btPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btPayment.Name = "btPayment"
        Me.btPayment.Size = New System.Drawing.Size(100, 28)
        Me.btPayment.TabIndex = 3
        Me.btPayment.Text = "Payment"
        Me.btPayment.UseVisualStyleBackColor = True
        '
        'pnFnB
        '
        Me.pnFnB.Controls.Add(Me.lbTotalPrice)
        Me.pnFnB.Controls.Add(Me.lbTotal)
        Me.pnFnB.Controls.Add(Me.btInsert)
        Me.pnFnB.Controls.Add(Me.lvFnB)
        Me.pnFnB.Controls.Add(Me.tbPortion)
        Me.pnFnB.Controls.Add(Me.lbFnB)
        Me.pnFnB.Controls.Add(Me.tbFnBCode)
        Me.pnFnB.Location = New System.Drawing.Point(269, 135)
        Me.pnFnB.Margin = New System.Windows.Forms.Padding(4)
        Me.pnFnB.Name = "pnFnB"
        Me.pnFnB.Size = New System.Drawing.Size(755, 350)
        Me.pnFnB.TabIndex = 2
        '
        'lbTotalPrice
        '
        Me.lbTotalPrice.AutoSize = True
        Me.lbTotalPrice.Location = New System.Drawing.Point(533, 315)
        Me.lbTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotalPrice.Name = "lbTotalPrice"
        Me.lbTotalPrice.Size = New System.Drawing.Size(28, 17)
        Me.lbTotalPrice.TabIndex = 9
        Me.lbTotalPrice.Text = "....."
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(461, 315)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(54, 17)
        Me.lbTotal.TabIndex = 8
        Me.lbTotal.Text = "TOTAL"
        '
        'btInsert
        '
        Me.btInsert.Location = New System.Drawing.Point(523, 39)
        Me.btInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.btInsert.Name = "btInsert"
        Me.btInsert.Size = New System.Drawing.Size(100, 28)
        Me.btInsert.TabIndex = 7
        Me.btInsert.Text = "Insert"
        Me.btInsert.UseVisualStyleBackColor = True
        '
        'lvFnB
        '
        Me.lvFnB.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chPortion, Me.chCode, Me.chName, Me.chPrice})
        Me.lvFnB.GridLines = True
        Me.lvFnB.Location = New System.Drawing.Point(24, 84)
        Me.lvFnB.Margin = New System.Windows.Forms.Padding(4)
        Me.lvFnB.Name = "lvFnB"
        Me.lvFnB.Size = New System.Drawing.Size(713, 214)
        Me.lvFnB.TabIndex = 6
        Me.lvFnB.UseCompatibleStateImageBehavior = False
        Me.lvFnB.View = System.Windows.Forms.View.Details
        '
        'chPortion
        '
        Me.chPortion.Text = "Portion"
        Me.chPortion.Width = 70
        '
        'chCode
        '
        Me.chCode.Text = "Code"
        Me.chCode.Width = 102
        '
        'chName
        '
        Me.chName.Text = "Name"
        Me.chName.Width = 200
        '
        'chPrice
        '
        Me.chPrice.Text = "Price"
        Me.chPrice.Width = 144
        '
        'tbPortion
        '
        Me.tbPortion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tbPortion.Location = New System.Drawing.Point(235, 39)
        Me.tbPortion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPortion.Name = "tbPortion"
        Me.tbPortion.Size = New System.Drawing.Size(132, 22)
        Me.tbPortion.TabIndex = 5
        Me.tbPortion.Text = "Portion"
        '
        'lbFnB
        '
        Me.lbFnB.AutoSize = True
        Me.lbFnB.Location = New System.Drawing.Point(308, 14)
        Me.lbFnB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFnB.Name = "lbFnB"
        Me.lbFnB.Size = New System.Drawing.Size(133, 17)
        Me.lbFnB.TabIndex = 4
        Me.lbFnB.Text = "Food and Beverage"
        '
        'tbFnBCode
        '
        Me.tbFnBCode.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tbFnBCode.Location = New System.Drawing.Point(381, 39)
        Me.tbFnBCode.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFnBCode.Name = "tbFnBCode"
        Me.tbFnBCode.Size = New System.Drawing.Size(132, 22)
        Me.tbFnBCode.TabIndex = 0
        Me.tbFnBCode.Text = "Code"
        '
        'pnRoomOrder
        '
        Me.pnRoomOrder.Controls.Add(Me.btOrderRoom)
        Me.pnRoomOrder.Controls.Add(Me.cbAddTime)
        Me.pnRoomOrder.Controls.Add(Me.lbAddTime)
        Me.pnRoomOrder.Controls.Add(Me.tbCustomerName)
        Me.pnRoomOrder.Controls.Add(Me.lbCustomerName)
        Me.pnRoomOrder.Location = New System.Drawing.Point(5, 135)
        Me.pnRoomOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.pnRoomOrder.Name = "pnRoomOrder"
        Me.pnRoomOrder.Size = New System.Drawing.Size(265, 350)
        Me.pnRoomOrder.TabIndex = 1
        '
        'btOrderRoom
        '
        Me.btOrderRoom.Location = New System.Drawing.Point(85, 287)
        Me.btOrderRoom.Margin = New System.Windows.Forms.Padding(4)
        Me.btOrderRoom.Name = "btOrderRoom"
        Me.btOrderRoom.Size = New System.Drawing.Size(100, 28)
        Me.btOrderRoom.TabIndex = 4
        Me.btOrderRoom.Text = "Order Room"
        Me.btOrderRoom.UseVisualStyleBackColor = True
        '
        'cbAddTime
        '
        Me.cbAddTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAddTime.FormattingEnabled = True
        Me.cbAddTime.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cbAddTime.Items.AddRange(New Object() {"1 Hour ", "2 Hours", "3 Hours", "4 Hours", "5 Hours", "6 Hours", "7 Hours", "8 Hours", "9 Hours", "10 Hours", "11 Hours", "12 Hours"})
        Me.cbAddTime.Location = New System.Drawing.Point(51, 140)
        Me.cbAddTime.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAddTime.Name = "cbAddTime"
        Me.cbAddTime.Size = New System.Drawing.Size(160, 24)
        Me.cbAddTime.TabIndex = 3
        '
        'lbAddTime
        '
        Me.lbAddTime.AutoSize = True
        Me.lbAddTime.Location = New System.Drawing.Point(97, 110)
        Me.lbAddTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAddTime.Name = "lbAddTime"
        Me.lbAddTime.Size = New System.Drawing.Size(68, 17)
        Me.lbAddTime.TabIndex = 2
        Me.lbAddTime.Text = "Add Time"
        '
        'tbCustomerName
        '
        Me.tbCustomerName.Location = New System.Drawing.Point(51, 59)
        Me.tbCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCustomerName.Name = "tbCustomerName"
        Me.tbCustomerName.Size = New System.Drawing.Size(160, 22)
        Me.tbCustomerName.TabIndex = 1
        '
        'lbCustomerName
        '
        Me.lbCustomerName.AutoSize = True
        Me.lbCustomerName.Location = New System.Drawing.Point(76, 31)
        Me.lbCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCustomerName.Name = "lbCustomerName"
        Me.lbCustomerName.Size = New System.Drawing.Size(109, 17)
        Me.lbCustomerName.TabIndex = 0
        Me.lbCustomerName.Text = "Customer Name"
        '
        'pnTime
        '
        Me.pnTime.Controls.Add(Me.lbTimeLeft)
        Me.pnTime.Location = New System.Drawing.Point(269, 0)
        Me.pnTime.Margin = New System.Windows.Forms.Padding(4)
        Me.pnTime.Name = "pnTime"
        Me.pnTime.Size = New System.Drawing.Size(753, 138)
        Me.pnTime.TabIndex = 0
        '
        'lbTimeLeft
        '
        Me.lbTimeLeft.AutoSize = True
        Me.lbTimeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lbTimeLeft.Location = New System.Drawing.Point(108, 47)
        Me.lbTimeLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTimeLeft.Name = "lbTimeLeft"
        Me.lbTimeLeft.Size = New System.Drawing.Size(524, 48)
        Me.lbTimeLeft.TabIndex = 0
        Me.lbTimeLeft.Text = "56 Minutes, 6 Seconds Left"
        '
        'lbRoomPrice
        '
        Me.lbRoomPrice.AutoSize = True
        Me.lbRoomPrice.Location = New System.Drawing.Point(100, 69)
        Me.lbRoomPrice.Name = "lbRoomPrice"
        Me.lbRoomPrice.Size = New System.Drawing.Size(67, 17)
        Me.lbRoomPrice.TabIndex = 2
        Me.lbRoomPrice.Text = "$10/Hour"
        '
        'lbRoomClass
        '
        Me.lbRoomClass.AutoSize = True
        Me.lbRoomClass.Location = New System.Drawing.Point(117, 47)
        Me.lbRoomClass.Name = "lbRoomClass"
        Me.lbRoomClass.Size = New System.Drawing.Size(29, 17)
        Me.lbRoomClass.TabIndex = 1
        Me.lbRoomClass.Text = "VIP"
        '
        'lbRoomNumber
        '
        Me.lbRoomNumber.AutoSize = True
        Me.lbRoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRoomNumber.Location = New System.Drawing.Point(103, 15)
        Me.lbRoomNumber.Name = "lbRoomNumber"
        Me.lbRoomNumber.Size = New System.Drawing.Size(57, 17)
        Me.lbRoomNumber.TabIndex = 0
        Me.lbRoomNumber.Text = "Room 1"
        '
        'pnRoomInfo
        '
        Me.pnRoomInfo.Controls.Add(Me.lbRoomCapacity)
        Me.pnRoomInfo.Controls.Add(Me.lbRoomNumber)
        Me.pnRoomInfo.Controls.Add(Me.lbRoomPrice)
        Me.pnRoomInfo.Controls.Add(Me.lbRoomClass)
        Me.pnRoomInfo.Location = New System.Drawing.Point(337, 30)
        Me.pnRoomInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.pnRoomInfo.Name = "pnRoomInfo"
        Me.pnRoomInfo.Size = New System.Drawing.Size(267, 138)
        Me.pnRoomInfo.TabIndex = 3
        '
        'lbRoomCapacity
        '
        Me.lbRoomCapacity.AutoSize = True
        Me.lbRoomCapacity.Location = New System.Drawing.Point(84, 90)
        Me.lbRoomCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRoomCapacity.Name = "lbRoomCapacity"
        Me.lbRoomCapacity.Size = New System.Drawing.Size(101, 17)
        Me.lbRoomCapacity.TabIndex = 3
        Me.lbRoomCapacity.Text = "Max 6 Persons"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 565)
        Me.Controls.Add(Me.pnRoomInfo)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnFnB.ResumeLayout(False)
        Me.pnFnB.PerformLayout()
        Me.pnRoomOrder.ResumeLayout(False)
        Me.pnRoomOrder.PerformLayout()
        Me.pnTime.ResumeLayout(False)
        Me.pnTime.PerformLayout()
        Me.pnRoomInfo.ResumeLayout(False)
        Me.pnRoomInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsernameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lbRoomPrice As Label
    Friend WithEvents lbRoomClass As Label
    Friend WithEvents lbRoomNumber As Label
    Friend WithEvents pnRoomInfo As Panel
    Friend WithEvents pnTime As Panel
    Friend WithEvents lbTimeLeft As Label
    Friend WithEvents lbRoomCapacity As Label
    Friend WithEvents pnRoomOrder As Panel
    Friend WithEvents btOrderRoom As Button
    Friend WithEvents cbAddTime As ComboBox
    Friend WithEvents lbAddTime As Label
    Friend WithEvents tbCustomerName As TextBox
    Friend WithEvents lbCustomerName As Label
    Friend WithEvents btPayment As Button
    Friend WithEvents pnFnB As Panel
    Friend WithEvents tbFnBCode As TextBox
    Friend WithEvents lbTotalPrice As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents btInsert As Button
    Friend WithEvents lvFnB As ListView
    Friend WithEvents chPortion As ColumnHeader
    Friend WithEvents chCode As ColumnHeader
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chPrice As ColumnHeader
    Friend WithEvents tbPortion As TextBox
    Friend WithEvents lbFnB As Label
End Class
