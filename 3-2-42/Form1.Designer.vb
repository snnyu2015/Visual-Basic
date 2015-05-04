<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseball
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
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblGamesWon = New System.Windows.Forms.Label()
        Me.lblGamesLost = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.txtWon = New System.Windows.Forms.TextBox()
        Me.txtLost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(63, 22)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(37, 13)
        Me.lblTeam.TabIndex = 0
        Me.lblTeam.Text = "Team:"
        '
        'lblGamesWon
        '
        Me.lblGamesWon.AutoSize = True
        Me.lblGamesWon.Location = New System.Drawing.Point(9, 58)
        Me.lblGamesWon.Name = "lblGamesWon"
        Me.lblGamesWon.Size = New System.Drawing.Size(66, 13)
        Me.lblGamesWon.TabIndex = 1
        Me.lblGamesWon.Text = "Games won:"
        '
        'lblGamesLost
        '
        Me.lblGamesLost.AutoSize = True
        Me.lblGamesLost.Location = New System.Drawing.Point(152, 61)
        Me.lblGamesLost.Name = "lblGamesLost"
        Me.lblGamesLost.Size = New System.Drawing.Size(62, 13)
        Me.lblGamesLost.TabIndex = 2
        Me.lblGamesLost.Text = "Games lost:"
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCompute.Font = New System.Drawing.Font("Harlow Solid Italic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(46, 94)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(207, 34)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "Compute Percentage"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'txtPercentage
        '
        Me.txtPercentage.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPercentage.Location = New System.Drawing.Point(23, 144)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(262, 20)
        Me.txtPercentage.TabIndex = 4
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(106, 19)
        Me.txtTeam.MaxLength = 30
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam.TabIndex = 5
        '
        'txtWon
        '
        Me.txtWon.Location = New System.Drawing.Point(75, 55)
        Me.txtWon.Name = "txtWon"
        Me.txtWon.Size = New System.Drawing.Size(43, 20)
        Me.txtWon.TabIndex = 6
        '
        'txtLost
        '
        Me.txtLost.Location = New System.Drawing.Point(223, 54)
        Me.txtLost.Name = "txtLost"
        Me.txtLost.Size = New System.Drawing.Size(50, 20)
        Me.txtLost.TabIndex = 7
        '
        'frmBaseball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(309, 185)
        Me.Controls.Add(Me.txtLost)
        Me.Controls.Add(Me.txtWon)
        Me.Controls.Add(Me.txtTeam)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblGamesLost)
        Me.Controls.Add(Me.lblGamesWon)
        Me.Controls.Add(Me.lblTeam)
        Me.Name = "frmBaseball"
        Me.Text = "Baseball"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTeam As System.Windows.Forms.Label
    Friend WithEvents lblGamesWon As System.Windows.Forms.Label
    Friend WithEvents lblGamesLost As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox
    Friend WithEvents txtTeam As System.Windows.Forms.TextBox
    Friend WithEvents txtWon As System.Windows.Forms.TextBox
    Friend WithEvents txtLost As System.Windows.Forms.TextBox

End Class
