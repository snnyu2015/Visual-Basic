<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExercise32
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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnHumor = New System.Windows.Forms.Button()
        Me.btnInsult = New System.Windows.Forms.Button()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number (1-3):"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(291, 13)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(22, 20)
        Me.txtNumber.TabIndex = 1
        '
        'btnHumor
        '
        Me.btnHumor.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHumor.Location = New System.Drawing.Point(130, 41)
        Me.btnHumor.Name = "btnHumor"
        Me.btnHumor.Size = New System.Drawing.Size(111, 39)
        Me.btnHumor.TabIndex = 2
        Me.btnHumor.Text = "Humor!"
        Me.btnHumor.UseVisualStyleBackColor = True
        '
        'btnInsult
        '
        Me.btnInsult.Font = New System.Drawing.Font("Freestyle Script", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsult.Location = New System.Drawing.Point(259, 41)
        Me.btnInsult.Name = "btnInsult"
        Me.btnInsult.Size = New System.Drawing.Size(98, 39)
        Me.btnInsult.TabIndex = 3
        Me.btnInsult.Text = "Insult..."
        Me.btnInsult.UseVisualStyleBackColor = True
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(12, 86)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.ReadOnly = True
        Me.txtSentence.Size = New System.Drawing.Size(469, 20)
        Me.txtSentence.TabIndex = 4
        '
        'frmExercise32
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 119)
        Me.Controls.Add(Me.txtSentence)
        Me.Controls.Add(Me.btnInsult)
        Me.Controls.Add(Me.btnHumor)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmExercise32"
        Me.Text = "4.3 Exercise 32"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnHumor As System.Windows.Forms.Button
    Friend WithEvents btnInsult As System.Windows.Forms.Button
    Friend WithEvents txtSentence As System.Windows.Forms.TextBox

End Class
