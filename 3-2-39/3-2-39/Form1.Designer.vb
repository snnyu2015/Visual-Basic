<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThunderstorm
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
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.txtNumSeconds = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(12, 20)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(146, 26)
        Me.lblSeconds.TabIndex = 0
        Me.lblSeconds.Text = "Number of seconds between " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lightning and thunder:"
        '
        'txtNumSeconds
        '
        Me.txtNumSeconds.Location = New System.Drawing.Point(169, 26)
        Me.txtNumSeconds.Name = "txtNumSeconds"
        Me.txtNumSeconds.Size = New System.Drawing.Size(75, 20)
        Me.txtNumSeconds.TabIndex = 1
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(58, 61)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(141, 24)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Compute Distance"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtAnswer.Location = New System.Drawing.Point(32, 102)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(198, 20)
        Me.txtAnswer.TabIndex = 3
        '
        'frmThunderstorm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 139)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtNumSeconds)
        Me.Controls.Add(Me.lblSeconds)
        Me.Name = "frmThunderstorm"
        Me.Text = "Thunderstorm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents txtNumSeconds As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox

End Class
