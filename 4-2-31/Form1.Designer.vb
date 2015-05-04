<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrossPay
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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# of hours worked:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "wage per hour:              $"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(27, 79)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(226, 23)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "calculate salary"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(153, 43)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(100, 20)
        Me.txtWage.TabIndex = 3
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(153, 18)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "gross pay:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossPay.Location = New System.Drawing.Point(86, 118)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(167, 20)
        Me.txtGrossPay.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(27, 153)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(178, 153)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "end"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmGrossPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(284, 189)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtWage)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGrossPay"
        Me.Text = "Gross Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
