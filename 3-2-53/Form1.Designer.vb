<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmAverageScore
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
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Average Score:"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(119, 142)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 2
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(132, 51)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(63, 20)
        Me.txtScore.TabIndex = 3
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(54, 80)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(165, 23)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Record the Score"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(54, 109)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(165, 23)
        Me.btnAverage.TabIndex = 5
        Me.btnAverage.Text = "Calculate the Average Score"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'fmAverageScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 217)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmAverageScore"
        Me.Text = "Average Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnAverage As System.Windows.Forms.Button

End Class
