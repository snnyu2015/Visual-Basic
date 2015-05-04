<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEPS
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
        Me.lblPriceOfStock = New System.Windows.Forms.Label()
        Me.lblEarnings = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtPriceOfStock = New System.Windows.Forms.TextBox()
        Me.txtEarnings = New System.Windows.Forms.TextBox()
        Me.txtRatio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPriceOfStock
        '
        Me.lblPriceOfStock.AutoSize = True
        Me.lblPriceOfStock.Location = New System.Drawing.Point(83, 19)
        Me.lblPriceOfStock.Name = "lblPriceOfStock"
        Me.lblPriceOfStock.Size = New System.Drawing.Size(77, 13)
        Me.lblPriceOfStock.TabIndex = 0
        Me.lblPriceOfStock.Text = "Price of Stock:"
        '
        'lblEarnings
        '
        Me.lblEarnings.AutoSize = True
        Me.lblEarnings.Location = New System.Drawing.Point(109, 49)
        Me.lblEarnings.Name = "lblEarnings"
        Me.lblEarnings.Size = New System.Drawing.Size(51, 13)
        Me.lblEarnings.TabIndex = 1
        Me.lblEarnings.Text = "Earnings:"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(77, 83)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(197, 27)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Compute Price-To-Earnings Ratio"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtPriceOfStock
        '
        Me.txtPriceOfStock.Location = New System.Drawing.Point(185, 16)
        Me.txtPriceOfStock.Name = "txtPriceOfStock"
        Me.txtPriceOfStock.Size = New System.Drawing.Size(58, 20)
        Me.txtPriceOfStock.TabIndex = 4
        '
        'txtEarnings
        '
        Me.txtEarnings.Location = New System.Drawing.Point(185, 42)
        Me.txtEarnings.Name = "txtEarnings"
        Me.txtEarnings.Size = New System.Drawing.Size(58, 20)
        Me.txtEarnings.TabIndex = 5
        '
        'txtRatio
        '
        Me.txtRatio.Location = New System.Drawing.Point(49, 129)
        Me.txtRatio.Name = "txtRatio"
        Me.txtRatio.Size = New System.Drawing.Size(255, 20)
        Me.txtRatio.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "$"
        '
        'frmEPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 184)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRatio)
        Me.Controls.Add(Me.txtEarnings)
        Me.Controls.Add(Me.txtPriceOfStock)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblEarnings)
        Me.Controls.Add(Me.lblPriceOfStock)
        Me.Name = "frmEPS"
        Me.Text = "Calculating Earnings Per Share"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPriceOfStock As System.Windows.Forms.Label
    Friend WithEvents lblEarnings As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtPriceOfStock As System.Windows.Forms.TextBox
    Friend WithEvents txtEarnings As System.Windows.Forms.TextBox
    Friend WithEvents txtRatio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
