<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipRental
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
        Me.btnDisplayRentals = New System.Windows.Forms.Button()
        Me.btnDisplayBill = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lstPrices = New System.Windows.Forms.ListBox()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplayRentals
        '
        Me.btnDisplayRentals.Location = New System.Drawing.Point(32, 25)
        Me.btnDisplayRentals.Name = "btnDisplayRentals"
        Me.btnDisplayRentals.Size = New System.Drawing.Size(174, 23)
        Me.btnDisplayRentals.TabIndex = 0
        Me.btnDisplayRentals.Text = "Display Rental Rates"
        Me.btnDisplayRentals.UseVisualStyleBackColor = True
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Location = New System.Drawing.Point(32, 185)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(174, 23)
        Me.btnDisplayBill.TabIndex = 1
        Me.btnDisplayBill.Text = "Display Customer Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select an item (1, 2, or 3):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select a duration (H or F):"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(171, 90)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(35, 20)
        Me.txtItem.TabIndex = 4
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(171, 124)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(35, 20)
        Me.txtDuration.TabIndex = 5
        '
        'lstPrices
        '
        Me.lstPrices.FormattingEnabled = True
        Me.lstPrices.Items.AddRange(New Object() {"Price of Equipment                           Half-day                 Full-day", ""})
        Me.lstPrices.Location = New System.Drawing.Point(229, 25)
        Me.lstPrices.Name = "lstPrices"
        Me.lstPrices.Size = New System.Drawing.Size(405, 69)
        Me.lstPrices.TabIndex = 6
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.Location = New System.Drawing.Point(229, 100)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(405, 108)
        Me.lstBill.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(229, 217)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(559, 217)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 9
        Me.btnEnd.Text = "end"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmEquipRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 252)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.lstPrices)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.btnDisplayRentals)
        Me.Name = "frmEquipRental"
        Me.Text = "Welcome to Eddie's Equipment Rental!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplayRentals As System.Windows.Forms.Button
    Friend WithEvents btnDisplayBill As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents lstPrices As System.Windows.Forms.ListBox
    Friend WithEvents lstBill As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
