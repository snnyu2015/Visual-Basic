<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestionnaire
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
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lstMajors = New System.Windows.Forms.ListBox()
        Me.radFreshman = New System.Windows.Forms.RadioButton()
        Me.radSophmore = New System.Windows.Forms.RadioButton()
        Me.radJunior = New System.Windows.Forms.RadioButton()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.chkVisBasic = New System.Windows.Forms.CheckBox()
        Me.chkJava = New System.Windows.Forms.CheckBox()
        Me.chkCPlus = New System.Windows.Forms.CheckBox()
        Me.chkC = New System.Windows.Forms.CheckBox()
        Me.chkCSharp = New System.Windows.Forms.CheckBox()
        Me.chkCobol = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(148, 189)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(119, 23)
        Me.btnRecord.TabIndex = 0
        Me.btnRecord.Text = "Record data"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(31, 218)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(287, 218)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "end"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lstMajors
        '
        Me.lstMajors.FormattingEnabled = True
        Me.lstMajors.Items.AddRange(New Object() {"Biological Science", "Business", "Computer Science", "Education", "English", "Fine Arts", "History", "Humanities", "Mathematics", "Physical Sciences", "Social Sciences"})
        Me.lstMajors.Location = New System.Drawing.Point(12, 39)
        Me.lstMajors.Name = "lstMajors"
        Me.lstMajors.Size = New System.Drawing.Size(120, 147)
        Me.lstMajors.TabIndex = 3
        '
        'radFreshman
        '
        Me.radFreshman.AutoSize = True
        Me.radFreshman.Location = New System.Drawing.Point(158, 38)
        Me.radFreshman.Name = "radFreshman"
        Me.radFreshman.Size = New System.Drawing.Size(71, 17)
        Me.radFreshman.TabIndex = 4
        Me.radFreshman.TabStop = True
        Me.radFreshman.Text = "Freshman"
        Me.radFreshman.UseVisualStyleBackColor = True
        '
        'radSophmore
        '
        Me.radSophmore.AutoSize = True
        Me.radSophmore.Location = New System.Drawing.Point(158, 61)
        Me.radSophmore.Name = "radSophmore"
        Me.radSophmore.Size = New System.Drawing.Size(73, 17)
        Me.radSophmore.TabIndex = 5
        Me.radSophmore.TabStop = True
        Me.radSophmore.Text = "Sophmore"
        Me.radSophmore.UseVisualStyleBackColor = True
        '
        'radJunior
        '
        Me.radJunior.AutoSize = True
        Me.radJunior.Location = New System.Drawing.Point(158, 84)
        Me.radJunior.Name = "radJunior"
        Me.radJunior.Size = New System.Drawing.Size(53, 17)
        Me.radJunior.TabIndex = 6
        Me.radJunior.TabStop = True
        Me.radJunior.Text = "Junior"
        Me.radJunior.UseVisualStyleBackColor = True
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(158, 107)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(55, 17)
        Me.radSenior.TabIndex = 7
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "Senior"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'chkVisBasic
        '
        Me.chkVisBasic.AutoSize = True
        Me.chkVisBasic.Location = New System.Drawing.Point(281, 40)
        Me.chkVisBasic.Name = "chkVisBasic"
        Me.chkVisBasic.Size = New System.Drawing.Size(83, 17)
        Me.chkVisBasic.TabIndex = 8
        Me.chkVisBasic.Text = "Visual Basic"
        Me.chkVisBasic.UseVisualStyleBackColor = True
        '
        'chkJava
        '
        Me.chkJava.AutoSize = True
        Me.chkJava.Location = New System.Drawing.Point(281, 63)
        Me.chkJava.Name = "chkJava"
        Me.chkJava.Size = New System.Drawing.Size(49, 17)
        Me.chkJava.TabIndex = 9
        Me.chkJava.Text = "Java"
        Me.chkJava.UseVisualStyleBackColor = True
        '
        'chkCPlus
        '
        Me.chkCPlus.AutoSize = True
        Me.chkCPlus.Location = New System.Drawing.Point(281, 87)
        Me.chkCPlus.Name = "chkCPlus"
        Me.chkCPlus.Size = New System.Drawing.Size(45, 17)
        Me.chkCPlus.TabIndex = 10
        Me.chkCPlus.Text = "C++"
        Me.chkCPlus.UseVisualStyleBackColor = True
        '
        'chkC
        '
        Me.chkC.AutoSize = True
        Me.chkC.Location = New System.Drawing.Point(281, 111)
        Me.chkC.Name = "chkC"
        Me.chkC.Size = New System.Drawing.Size(33, 17)
        Me.chkC.TabIndex = 11
        Me.chkC.Text = "C"
        Me.chkC.UseVisualStyleBackColor = True
        '
        'chkCSharp
        '
        Me.chkCSharp.AutoSize = True
        Me.chkCSharp.Location = New System.Drawing.Point(281, 135)
        Me.chkCSharp.Name = "chkCSharp"
        Me.chkCSharp.Size = New System.Drawing.Size(40, 17)
        Me.chkCSharp.TabIndex = 12
        Me.chkCSharp.Text = "C#"
        Me.chkCSharp.UseVisualStyleBackColor = True
        '
        'chkCobol
        '
        Me.chkCobol.AutoSize = True
        Me.chkCobol.Location = New System.Drawing.Point(281, 159)
        Me.chkCobol.Name = "chkCobol"
        Me.chkCobol.Size = New System.Drawing.Size(62, 17)
        Me.chkCobol.TabIndex = 13
        Me.chkCobol.Text = "COBOL"
        Me.chkCobol.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Major"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Languages Studied"
        '
        'frmQuestionnaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 249)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkCobol)
        Me.Controls.Add(Me.chkCSharp)
        Me.Controls.Add(Me.chkC)
        Me.Controls.Add(Me.chkCPlus)
        Me.Controls.Add(Me.chkJava)
        Me.Controls.Add(Me.chkVisBasic)
        Me.Controls.Add(Me.radSenior)
        Me.Controls.Add(Me.radJunior)
        Me.Controls.Add(Me.radSophmore)
        Me.Controls.Add(Me.radFreshman)
        Me.Controls.Add(Me.lstMajors)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRecord)
        Me.Name = "frmQuestionnaire"
        Me.Text = "4-4-22 Questionnaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents lstMajors As System.Windows.Forms.ListBox
    Friend WithEvents radFreshman As System.Windows.Forms.RadioButton
    Friend WithEvents radSophmore As System.Windows.Forms.RadioButton
    Friend WithEvents radJunior As System.Windows.Forms.RadioButton
    Friend WithEvents radSenior As System.Windows.Forms.RadioButton
    Friend WithEvents chkVisBasic As System.Windows.Forms.CheckBox
    Friend WithEvents chkJava As System.Windows.Forms.CheckBox
    Friend WithEvents chkCPlus As System.Windows.Forms.CheckBox
    Friend WithEvents chkC As System.Windows.Forms.CheckBox
    Friend WithEvents chkCSharp As System.Windows.Forms.CheckBox
    Friend WithEvents chkCobol As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
