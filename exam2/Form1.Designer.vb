<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtPastDue = New System.Windows.Forms.TextBox()
        Me.txtPayments = New System.Windows.Forms.TextBox()
        Me.txtPurchases = New System.Windows.Forms.TextBox()
        Me.txtFinCharge = New System.Windows.Forms.TextBox()
        Me.txtCurrAmtDue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Past Due:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Payments:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Purchases:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "finance charges:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "current amount due:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(26, 150)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(180, 23)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display Account Summary"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(9, 258)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(144, 258)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "end"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(96, 33)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(100, 20)
        Me.txtAccount.TabIndex = 9
        '
        'txtPastDue
        '
        Me.txtPastDue.Location = New System.Drawing.Point(96, 59)
        Me.txtPastDue.Name = "txtPastDue"
        Me.txtPastDue.Size = New System.Drawing.Size(100, 20)
        Me.txtPastDue.TabIndex = 10
        '
        'txtPayments
        '
        Me.txtPayments.Location = New System.Drawing.Point(96, 85)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.Size = New System.Drawing.Size(100, 20)
        Me.txtPayments.TabIndex = 11
        '
        'txtPurchases
        '
        Me.txtPurchases.Location = New System.Drawing.Point(96, 111)
        Me.txtPurchases.Name = "txtPurchases"
        Me.txtPurchases.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchases.TabIndex = 12
        '
        'txtFinCharge
        '
        Me.txtFinCharge.Location = New System.Drawing.Point(119, 198)
        Me.txtFinCharge.Name = "txtFinCharge"
        Me.txtFinCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtFinCharge.TabIndex = 13
        '
        'txtCurrAmtDue
        '
        Me.txtCurrAmtDue.Location = New System.Drawing.Point(119, 221)
        Me.txtCurrAmtDue.Name = "txtCurrAmtDue"
        Me.txtCurrAmtDue.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrAmtDue.TabIndex = 14
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 299)
        Me.Controls.Add(Me.txtCurrAmtDue)
        Me.Controls.Add(Me.txtFinCharge)
        Me.Controls.Add(Me.txtPurchases)
        Me.Controls.Add(Me.txtPayments)
        Me.Controls.Add(Me.txtPastDue)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAccounts"
        Me.Text = "Credit Card Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtPastDue As System.Windows.Forms.TextBox
    Friend WithEvents txtPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchases As System.Windows.Forms.TextBox
    Friend WithEvents txtFinCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrAmtDue As System.Windows.Forms.TextBox

End Class
