<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainingHeartRate
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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblRestHeartRate = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtBoxAge = New System.Windows.Forms.TextBox()
        Me.txtBoxRHR = New System.Windows.Forms.TextBox()
        Me.txtBoxTHR = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(75, 20)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age:"
        '
        'lblRestHeartRate
        '
        Me.lblRestHeartRate.AutoSize = True
        Me.lblRestHeartRate.Location = New System.Drawing.Point(12, 50)
        Me.lblRestHeartRate.Name = "lblRestHeartRate"
        Me.lblRestHeartRate.Size = New System.Drawing.Size(94, 13)
        Me.lblRestHeartRate.TabIndex = 1
        Me.lblRestHeartRate.Text = "Resting heart rate:"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(78, 86)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(113, 23)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Compute THR"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtBoxAge
        '
        Me.txtBoxAge.Location = New System.Drawing.Point(122, 20)
        Me.txtBoxAge.Name = "txtBoxAge"
        Me.txtBoxAge.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxAge.TabIndex = 3
        '
        'txtBoxRHR
        '
        Me.txtBoxRHR.Location = New System.Drawing.Point(122, 50)
        Me.txtBoxRHR.Name = "txtBoxRHR"
        Me.txtBoxRHR.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxRHR.TabIndex = 4
        '
        'txtBoxTHR
        '
        Me.txtBoxTHR.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtBoxTHR.Location = New System.Drawing.Point(15, 129)
        Me.txtBoxTHR.Name = "txtBoxTHR"
        Me.txtBoxTHR.Size = New System.Drawing.Size(225, 20)
        Me.txtBoxTHR.TabIndex = 5
        '
        'frmTrainingHeartRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 174)
        Me.Controls.Add(Me.txtBoxTHR)
        Me.Controls.Add(Me.txtBoxRHR)
        Me.Controls.Add(Me.txtBoxAge)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblRestHeartRate)
        Me.Controls.Add(Me.lblAge)
        Me.Name = "frmTrainingHeartRate"
        Me.Text = "Training heart Rate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblRestHeartRate As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtBoxAge As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxRHR As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTHR As System.Windows.Forms.TextBox

End Class
