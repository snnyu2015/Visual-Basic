'Programmer: Samantha Naini
'Date: 3/15/2012
'Exercise: 4-2-21 pg.152
'Program Purpose: Create a program processing someone's major, year, and languages selected.



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
        Me.lstMajors = New System.Windows.Forms.ListBox()
        Me.chkVisBasic = New System.Windows.Forms.CheckBox()
        Me.chkJava = New System.Windows.Forms.CheckBox()
        Me.chkCplus = New System.Windows.Forms.CheckBox()
        Me.chkC = New System.Windows.Forms.CheckBox()
        Me.chkCSharp = New System.Windows.Forms.CheckBox()
        Me.chkCobol = New System.Windows.Forms.CheckBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radJunior = New System.Windows.Forms.RadioButton()
        Me.radSophmore = New System.Windows.Forms.RadioButton()
        Me.radFreshman = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lstMajors
        '
        Me.lstMajors.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lstMajors.FormattingEnabled = True
        Me.lstMajors.Items.AddRange(New Object() {"Biological Science", "Business", "Computer Science", "Education", "English", "Fine Arts", "History", "Humanities", "Mathematics", "Physical Sciences", "Social Sciences"})
        Me.lstMajors.Location = New System.Drawing.Point(12, 35)
        Me.lstMajors.Name = "lstMajors"
        Me.lstMajors.Size = New System.Drawing.Size(120, 147)
        Me.lstMajors.TabIndex = 0
        '
        'chkVisBasic
        '
        Me.chkVisBasic.AutoSize = True
        Me.chkVisBasic.Location = New System.Drawing.Point(248, 36)
        Me.chkVisBasic.Name = "chkVisBasic"
        Me.chkVisBasic.Size = New System.Drawing.Size(82, 17)
        Me.chkVisBasic.TabIndex = 5
        Me.chkVisBasic.Text = "Visual basic"
        Me.chkVisBasic.UseVisualStyleBackColor = True
        '
        'chkJava
        '
        Me.chkJava.AutoSize = True
        Me.chkJava.Location = New System.Drawing.Point(248, 59)
        Me.chkJava.Name = "chkJava"
        Me.chkJava.Size = New System.Drawing.Size(49, 17)
        Me.chkJava.TabIndex = 6
        Me.chkJava.Text = "Java"
        Me.chkJava.UseVisualStyleBackColor = True
        '
        'chkCplus
        '
        Me.chkCplus.AutoSize = True
        Me.chkCplus.Location = New System.Drawing.Point(248, 82)
        Me.chkCplus.Name = "chkCplus"
        Me.chkCplus.Size = New System.Drawing.Size(45, 17)
        Me.chkCplus.TabIndex = 7
        Me.chkCplus.Text = "C++"
        Me.chkCplus.UseVisualStyleBackColor = True
        '
        'chkC
        '
        Me.chkC.AutoSize = True
        Me.chkC.Location = New System.Drawing.Point(248, 105)
        Me.chkC.Name = "chkC"
        Me.chkC.Size = New System.Drawing.Size(33, 17)
        Me.chkC.TabIndex = 8
        Me.chkC.Text = "C"
        Me.chkC.UseVisualStyleBackColor = True
        '
        'chkCSharp
        '
        Me.chkCSharp.AutoSize = True
        Me.chkCSharp.Location = New System.Drawing.Point(248, 128)
        Me.chkCSharp.Name = "chkCSharp"
        Me.chkCSharp.Size = New System.Drawing.Size(40, 17)
        Me.chkCSharp.TabIndex = 9
        Me.chkCSharp.Text = "C#"
        Me.chkCSharp.UseVisualStyleBackColor = True
        '
        'chkCobol
        '
        Me.chkCobol.AutoSize = True
        Me.chkCobol.Location = New System.Drawing.Point(248, 151)
        Me.chkCobol.Name = "chkCobol"
        Me.chkCobol.Size = New System.Drawing.Size(53, 17)
        Me.chkCobol.TabIndex = 10
        Me.chkCobol.Text = "Cobol"
        Me.chkCobol.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(138, 161)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(88, 23)
        Me.btnRecord.TabIndex = 11
        Me.btnRecord.Text = "Record Data"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Major"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Languages studied"
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(136, 136)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(55, 17)
        Me.radSenior.TabIndex = 4
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "Senior"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radJunior
        '
        Me.radJunior.AutoSize = True
        Me.radJunior.Location = New System.Drawing.Point(136, 102)
        Me.radJunior.Name = "radJunior"
        Me.radJunior.Size = New System.Drawing.Size(53, 17)
        Me.radJunior.TabIndex = 3
        Me.radJunior.TabStop = True
        Me.radJunior.Text = "Junior"
        Me.radJunior.UseVisualStyleBackColor = True
        '
        'radSophmore
        '
        Me.radSophmore.AutoSize = True
        Me.radSophmore.Location = New System.Drawing.Point(136, 69)
        Me.radSophmore.Name = "radSophmore"
        Me.radSophmore.Size = New System.Drawing.Size(73, 17)
        Me.radSophmore.TabIndex = 2
        Me.radSophmore.TabStop = True
        Me.radSophmore.Text = "Sophmore"
        Me.radSophmore.UseVisualStyleBackColor = True
        '
        'radFreshman
        '
        Me.radFreshman.AutoSize = True
        Me.radFreshman.Location = New System.Drawing.Point(136, 35)
        Me.radFreshman.Name = "radFreshman"
        Me.radFreshman.Size = New System.Drawing.Size(71, 17)
        Me.radFreshman.TabIndex = 1
        Me.radFreshman.TabStop = True
        Me.radFreshman.Text = "Freshman"
        Me.radFreshman.UseVisualStyleBackColor = True
        '
        'frmQuestionnaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(369, 196)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.chkCobol)
        Me.Controls.Add(Me.chkCSharp)
        Me.Controls.Add(Me.chkC)
        Me.Controls.Add(Me.chkCplus)
        Me.Controls.Add(Me.chkJava)
        Me.Controls.Add(Me.chkVisBasic)
        Me.Controls.Add(Me.radSenior)
        Me.Controls.Add(Me.radJunior)
        Me.Controls.Add(Me.radSophmore)
        Me.Controls.Add(Me.radFreshman)
        Me.Controls.Add(Me.lstMajors)
        Me.Name = "frmQuestionnaire"
        Me.Text = "Questionnaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMajors As System.Windows.Forms.ListBox
    Friend WithEvents chkVisBasic As System.Windows.Forms.CheckBox
    Friend WithEvents chkJava As System.Windows.Forms.CheckBox
    Friend WithEvents chkCplus As System.Windows.Forms.CheckBox
    Friend WithEvents chkC As System.Windows.Forms.CheckBox
    Friend WithEvents chkCSharp As System.Windows.Forms.CheckBox
    Friend WithEvents chkCobol As System.Windows.Forms.CheckBox
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radSenior As System.Windows.Forms.RadioButton
    Friend WithEvents radJunior As System.Windows.Forms.RadioButton
    Friend WithEvents radSophmore As System.Windows.Forms.RadioButton
    Friend WithEvents radFreshman As System.Windows.Forms.RadioButton

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click

        Dim majorSelected As Boolean
        Dim yearSelected As Boolean

        If lstMajors.Text = "" Then
            majorSelected = False
        Else
            majorSelected = True
        End If

        If (radFreshman.Checked Or radSophmore.Checked Or radJunior.Checked Or radSenior.Checked) Then

            yearSelected = True
        Else
            yearSelected = False

        End If

        If majorSelected And yearSelected Then
            MessageBox.Show("Your information has been processed.")

        ElseIf Not majorSelected Then
            If Not yearSelected Then
                MessageBox.Show("Please select a major and year.")
            Else
                MessageBox.Show("Please select a major.")
            End If
        Else
            MessageBox.Show("Please select a year.")
        End If

        Dim sentence As String = Nothing
If 1stMajor.Text= Nothing Then
            MessageBox.Show("No major was selected.", "4-4-22")
        End If
        If radFreshman.Checked = False And radSophomore.Checked = False Then
radJunior.Checked= False And radSenior.Checked= False Then
            MessageBox.Show("No year was selected.", "4-4-22")
        End If
        If chkC.Checked Then
            sentence = "C "
        End If
        If chkCobol.Checked Then
            sentence &= "COBOL "
        End If
        If chkCPlusPlus.Checked Then
            sentence &= "C++ "

        End If
        If chkCSharp.Checked Then
            sentence &= "C# "
        End If
        If chkJava.Checked Then
            sentence &= "Java "
        End If
        If chkVB.Checked Then
            sentence &= "Visual Basic "
        End If


"The following languages studied: " & sentence & ".", "4-4-22"
    End Sub
End Class
