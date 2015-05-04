<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditCard
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txtNewBal = New System.Windows.Forms.TextBox()
        Me.txtMinPayment = New System.Windows.Forms.TextBox()
        Me.txtCharges = New System.Windows.Forms.TextBox()
        Me.txtOldBal = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(6, 71)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(225, 34)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate New Balance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Minimum Payment"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Charges:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Old balance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Credits:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "New Balance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Minimum Payment:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(3, 173)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(46, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(195, 173)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(34, 23)
        Me.btnEnd.TabIndex = 7
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'txtNewBal
        '
        Me.txtNewBal.Location = New System.Drawing.Point(100, 111)
        Me.txtNewBal.Name = "txtNewBal"
        Me.txtNewBal.Size = New System.Drawing.Size(129, 20)
        Me.txtNewBal.TabIndex = 8
        '
        'txtMinPayment
        '
        Me.txtMinPayment.Location = New System.Drawing.Point(100, 137)
        Me.txtMinPayment.Name = "txtMinPayment"
        Me.txtMinPayment.Size = New System.Drawing.Size(129, 20)
        Me.txtMinPayment.TabIndex = 9
        '
        'txtCharges
        '
        Me.txtCharges.Location = New System.Drawing.Point(57, 45)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(56, 20)
        Me.txtCharges.TabIndex = 10
        '
        'txtOldBal
        '
        Me.txtOldBal.Location = New System.Drawing.Point(79, 15)
        Me.txtOldBal.Name = "txtOldBal"
        Me.txtOldBal.Size = New System.Drawing.Size(146, 20)
        Me.txtOldBal.TabIndex = 11
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(176, 45)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(53, 20)
        Me.txtCredits.TabIndex = 12
        '
        'frmCreditCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 200)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.txtOldBal)
        Me.Controls.Add(Me.txtCharges)
        Me.Controls.Add(Me.txtMinPayment)
        Me.Controls.Add(Me.txtNewBal)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmCreditCard"
        Me.Text = "Credit Card"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents txtNewBal As System.Windows.Forms.TextBox
    Friend WithEvents txtMinPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtOldBal As System.Windows.Forms.TextBox
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox

End Class
