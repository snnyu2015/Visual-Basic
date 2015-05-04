<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStateFacts
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
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtFact = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter State:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(97, 12)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(143, 20)
        Me.txtState.TabIndex = 1
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 109)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fact:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(93, 109)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(174, 109)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(63, 23)
        Me.btnEnd.TabIndex = 6
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(12, 40)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(80, 13)
        Me.lblCat.TabIndex = 8
        Me.lblCat.Text = "Enter Category:"
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(97, 37)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(143, 20)
        Me.txtCat.TabIndex = 9
        '
        'txtFact
        '
        Me.txtFact.Location = New System.Drawing.Point(15, 83)
        Me.txtFact.Name = "txtFact"
        Me.txtFact.ReadOnly = True
        Me.txtFact.Size = New System.Drawing.Size(222, 20)
        Me.txtFact.TabIndex = 10
        '
        'frmStateFacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 145)
        Me.Controls.Add(Me.txtFact)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStateFacts"
        Me.Text = "U.S. State Facts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents txtFact As System.Windows.Forms.TextBox

End Class
