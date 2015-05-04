<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriathlon
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
        Me.lblCycling = New System.Windows.Forms.Label()
        Me.lblRunning = New System.Windows.Forms.Label()
        Me.lblSwimming = New System.Windows.Forms.Label()
        Me.txtBoxCycling = New System.Windows.Forms.TextBox()
        Me.txtBoxRunning = New System.Windows.Forms.TextBox()
        Me.txtBoxSwimming = New System.Windows.Forms.TextBox()
        Me.txtBoxWeightLoss = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCycling
        '
        Me.lblCycling.AutoSize = True
        Me.lblCycling.Location = New System.Drawing.Point(49, 39)
        Me.lblCycling.Name = "lblCycling"
        Me.lblCycling.Size = New System.Drawing.Size(124, 13)
        Me.lblCycling.TabIndex = 0
        Me.lblCycling.Text = "Number of hours cycling:"
        '
        'lblRunning
        '
        Me.lblRunning.AutoSize = True
        Me.lblRunning.Location = New System.Drawing.Point(49, 66)
        Me.lblRunning.Name = "lblRunning"
        Me.lblRunning.Size = New System.Drawing.Size(126, 13)
        Me.lblRunning.TabIndex = 1
        Me.lblRunning.Text = "Number of hours running:"
        '
        'lblSwimming
        '
        Me.lblSwimming.AutoSize = True
        Me.lblSwimming.Location = New System.Drawing.Point(49, 92)
        Me.lblSwimming.Name = "lblSwimming"
        Me.lblSwimming.Size = New System.Drawing.Size(136, 13)
        Me.lblSwimming.TabIndex = 2
        Me.lblSwimming.Text = "Number of hours swimming:"
        '
        'txtBoxCycling
        '
        Me.txtBoxCycling.Location = New System.Drawing.Point(191, 32)
        Me.txtBoxCycling.Name = "txtBoxCycling"
        Me.txtBoxCycling.Size = New System.Drawing.Size(31, 20)
        Me.txtBoxCycling.TabIndex = 3
        '
        'txtBoxRunning
        '
        Me.txtBoxRunning.Location = New System.Drawing.Point(191, 59)
        Me.txtBoxRunning.Name = "txtBoxRunning"
        Me.txtBoxRunning.Size = New System.Drawing.Size(31, 20)
        Me.txtBoxRunning.TabIndex = 4
        '
        'txtBoxSwimming
        '
        Me.txtBoxSwimming.Location = New System.Drawing.Point(191, 89)
        Me.txtBoxSwimming.Name = "txtBoxSwimming"
        Me.txtBoxSwimming.Size = New System.Drawing.Size(31, 20)
        Me.txtBoxSwimming.TabIndex = 5
        '
        'txtBoxWeightLoss
        '
        Me.txtBoxWeightLoss.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBoxWeightLoss.Location = New System.Drawing.Point(52, 164)
        Me.txtBoxWeightLoss.Name = "txtBoxWeightLoss"
        Me.txtBoxWeightLoss.Size = New System.Drawing.Size(170, 20)
        Me.txtBoxWeightLoss.TabIndex = 6
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(69, 124)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(137, 23)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = "Compute Weight Loss"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'frmTriathlon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 215)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtBoxWeightLoss)
        Me.Controls.Add(Me.txtBoxSwimming)
        Me.Controls.Add(Me.txtBoxRunning)
        Me.Controls.Add(Me.txtBoxCycling)
        Me.Controls.Add(Me.lblSwimming)
        Me.Controls.Add(Me.lblRunning)
        Me.Controls.Add(Me.lblCycling)
        Me.Name = "frmTriathlon"
        Me.Text = "Triathlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCycling As System.Windows.Forms.Label
    Friend WithEvents lblRunning As System.Windows.Forms.Label
    Friend WithEvents lblSwimming As System.Windows.Forms.Label
    Friend WithEvents txtBoxCycling As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxRunning As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxSwimming As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxWeightLoss As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button

End Class
