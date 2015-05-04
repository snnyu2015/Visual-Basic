<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompareIntRates
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
        Me.txtRate1 = New System.Windows.Forms.TextBox()
        Me.txtPeriod1 = New System.Windows.Forms.TextBox()
        Me.txtRate2 = New System.Windows.Forms.TextBox()
        Me.txtPeriod2 = New System.Windows.Forms.TextBox()
        Me.txtAPY2 = New System.Windows.Forms.TextBox()
        Me.txtBestBank = New System.Windows.Forms.TextBox()
        Me.txtAPY1 = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRate1
        '
        Me.txtRate1.Location = New System.Drawing.Point(166, 18)
        Me.txtRate1.Name = "txtRate1"
        Me.txtRate1.Size = New System.Drawing.Size(46, 20)
        Me.txtRate1.TabIndex = 0
        '
        'txtPeriod1
        '
        Me.txtPeriod1.Location = New System.Drawing.Point(166, 44)
        Me.txtPeriod1.Name = "txtPeriod1"
        Me.txtPeriod1.Size = New System.Drawing.Size(46, 20)
        Me.txtPeriod1.TabIndex = 1
        '
        'txtRate2
        '
        Me.txtRate2.Location = New System.Drawing.Point(218, 18)
        Me.txtRate2.Name = "txtRate2"
        Me.txtRate2.Size = New System.Drawing.Size(48, 20)
        Me.txtRate2.TabIndex = 2
        '
        'txtPeriod2
        '
        Me.txtPeriod2.Location = New System.Drawing.Point(218, 44)
        Me.txtPeriod2.Name = "txtPeriod2"
        Me.txtPeriod2.Size = New System.Drawing.Size(48, 20)
        Me.txtPeriod2.TabIndex = 3
        '
        'txtAPY2
        '
        Me.txtAPY2.Location = New System.Drawing.Point(218, 70)
        Me.txtAPY2.Name = "txtAPY2"
        Me.txtAPY2.Size = New System.Drawing.Size(48, 20)
        Me.txtAPY2.TabIndex = 4
        '
        'txtBestBank
        '
        Me.txtBestBank.Location = New System.Drawing.Point(166, 96)
        Me.txtBestBank.Name = "txtBestBank"
        Me.txtBestBank.Size = New System.Drawing.Size(100, 20)
        Me.txtBestBank.TabIndex = 5
        '
        'txtAPY1
        '
        Me.txtAPY1.Location = New System.Drawing.Point(166, 70)
        Me.txtAPY1.Name = "txtAPY1"
        Me.txtAPY1.Size = New System.Drawing.Size(46, 20)
        Me.txtAPY1.TabIndex = 6
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(283, 28)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(102, 88)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = "Determine Best Bank"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bank 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bank 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Annual Rate of interest:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Number of compounding periods:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "APY:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Best bank:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 129)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(310, 129)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 15
        Me.btnEnd.Text = "end"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmCompareIntRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 164)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtAPY1)
        Me.Controls.Add(Me.txtBestBank)
        Me.Controls.Add(Me.txtAPY2)
        Me.Controls.Add(Me.txtPeriod2)
        Me.Controls.Add(Me.txtRate2)
        Me.Controls.Add(Me.txtPeriod1)
        Me.Controls.Add(Me.txtRate1)
        Me.Name = "frmCompareIntRates"
        Me.Text = "Compare Interest Rates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRate1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriod1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRate2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriod2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAPY2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBestBank As System.Windows.Forms.TextBox
    Friend WithEvents txtAPY1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
