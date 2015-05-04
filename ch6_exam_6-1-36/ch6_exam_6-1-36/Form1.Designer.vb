<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCh6Exam
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtIntRate = New System.Windows.Forms.TextBox()
        Me.txtNumOfMonths = New System.Windows.Forms.TextBox()
        Me.txtAcctBal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "monthly deposit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interest rate:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(nn.nn%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. of months for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "more than $3000:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Account balance:"
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(157, 218)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 218)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(56, 189)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(129, 23)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Calculate"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(123, 24)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposit.TabIndex = 7
        '
        'txtIntRate
        '
        Me.txtIntRate.Location = New System.Drawing.Point(123, 66)
        Me.txtIntRate.Name = "txtIntRate"
        Me.txtIntRate.Size = New System.Drawing.Size(100, 20)
        Me.txtIntRate.TabIndex = 8
        '
        'txtNumOfMonths
        '
        Me.txtNumOfMonths.Location = New System.Drawing.Point(123, 109)
        Me.txtNumOfMonths.Name = "txtNumOfMonths"
        Me.txtNumOfMonths.Size = New System.Drawing.Size(100, 20)
        Me.txtNumOfMonths.TabIndex = 9
        '
        'txtAcctBal
        '
        Me.txtAcctBal.Location = New System.Drawing.Point(123, 150)
        Me.txtAcctBal.Name = "txtAcctBal"
        Me.txtAcctBal.Size = New System.Drawing.Size(100, 20)
        Me.txtAcctBal.TabIndex = 10
        '
        'frmCh6Exam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 258)
        Me.Controls.Add(Me.txtAcctBal)
        Me.Controls.Add(Me.txtNumOfMonths)
        Me.Controls.Add(Me.txtIntRate)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCh6Exam"
        Me.Text = "6-1-36"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents txtIntRate As System.Windows.Forms.TextBox
    Friend WithEvents txtNumOfMonths As System.Windows.Forms.TextBox
    Friend WithEvents txtAcctBal As System.Windows.Forms.TextBox

End Class
