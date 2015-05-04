<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings
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
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.lblIntRate = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtIntRate = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(21, 27)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(50, 13)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Principal:"
        '
        'lblIntRate
        '
        Me.lblIntRate.AutoSize = True
        Me.lblIntRate.Location = New System.Drawing.Point(21, 53)
        Me.lblIntRate.Name = "lblIntRate"
        Me.lblIntRate.Size = New System.Drawing.Size(71, 13)
        Me.lblIntRate.TabIndex = 1
        Me.lblIntRate.Text = "Interest Rate:"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(24, 72)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(178, 23)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Compute Balance"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(24, 101)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(178, 121)
        Me.lstResults.TabIndex = 3
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(102, 20)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipal.TabIndex = 4
        '
        'txtIntRate
        '
        Me.txtIntRate.Location = New System.Drawing.Point(102, 46)
        Me.txtIntRate.Name = "txtIntRate"
        Me.txtIntRate.Size = New System.Drawing.Size(100, 20)
        Me.txtIntRate.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(24, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 22)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(112, 228)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(90, 22)
        Me.btnEnd.TabIndex = 7
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 269)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtIntRate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblIntRate)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Name = "frmSavings"
        Me.Text = "Savings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrincipal As System.Windows.Forms.Label
    Friend WithEvents lblIntRate As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents txtIntRate As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
