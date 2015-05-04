<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPA
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
        Me.btnRecordGrades = New System.Windows.Forms.Button()
        Me.btnCalculateGPA = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLetterGrade = New System.Windows.Forms.TextBox()
        Me.txtCreditHrs = New System.Windows.Forms.TextBox()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grade (A, B,...):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit hours:"
        '
        'btnRecordGrades
        '
        Me.btnRecordGrades.Location = New System.Drawing.Point(28, 73)
        Me.btnRecordGrades.Name = "btnRecordGrades"
        Me.btnRecordGrades.Size = New System.Drawing.Size(143, 23)
        Me.btnRecordGrades.TabIndex = 2
        Me.btnRecordGrades.Text = "Record this course"
        Me.btnRecordGrades.UseVisualStyleBackColor = True
        '
        'btnCalculateGPA
        '
        Me.btnCalculateGPA.Location = New System.Drawing.Point(28, 102)
        Me.btnCalculateGPA.Name = "btnCalculateGPA"
        Me.btnCalculateGPA.Size = New System.Drawing.Size(143, 23)
        Me.btnCalculateGPA.TabIndex = 3
        Me.btnCalculateGPA.Text = "Calculate GPA"
        Me.btnCalculateGPA.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "GPA:"
        '
        'txtLetterGrade
        '
        Me.txtLetterGrade.Location = New System.Drawing.Point(130, 18)
        Me.txtLetterGrade.Name = "txtLetterGrade"
        Me.txtLetterGrade.Size = New System.Drawing.Size(24, 20)
        Me.txtLetterGrade.TabIndex = 5
        '
        'txtCreditHrs
        '
        Me.txtCreditHrs.Location = New System.Drawing.Point(130, 42)
        Me.txtCreditHrs.Name = "txtCreditHrs"
        Me.txtCreditHrs.Size = New System.Drawing.Size(24, 20)
        Me.txtCreditHrs.TabIndex = 6
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(46, 138)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(125, 20)
        Me.txtGPA.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(10, 177)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(43, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(130, 177)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(43, 23)
        Me.btnEnd.TabIndex = 9
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmGPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 216)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.txtCreditHrs)
        Me.Controls.Add(Me.txtLetterGrade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalculateGPA)
        Me.Controls.Add(Me.btnRecordGrades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGPA"
        Me.Text = "GPA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRecordGrades As System.Windows.Forms.Button
    Friend WithEvents btnCalculateGPA As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLetterGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtCreditHrs As System.Windows.Forms.TextBox
    Friend WithEvents txtGPA As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
