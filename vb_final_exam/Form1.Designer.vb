<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVBFinalExam
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.btnDisplayEmpRecord = New System.Windows.Forms.Button()
        Me.btnDisplayFinalTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee:"
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Items.AddRange(New Object() {"Payroll Report For Week ending 12/01/2011", "", "Employee         Hourly Rate         Hours Worked         Gross Pay"})
        Me.lstOutput.Location = New System.Drawing.Point(15, 101)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(488, 172)
        Me.lstOutput.TabIndex = 1
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(74, 26)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployee.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hourly Rate:"
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(276, 26)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(51, 20)
        Me.txtPayRate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hours Worked:"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(431, 26)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(63, 20)
        Me.txtHoursWorked.TabIndex = 6
        '
        'btnDisplayEmpRecord
        '
        Me.btnDisplayEmpRecord.Location = New System.Drawing.Point(15, 61)
        Me.btnDisplayEmpRecord.Name = "btnDisplayEmpRecord"
        Me.btnDisplayEmpRecord.Size = New System.Drawing.Size(142, 23)
        Me.btnDisplayEmpRecord.TabIndex = 7
        Me.btnDisplayEmpRecord.Text = "Display Employee Record"
        Me.btnDisplayEmpRecord.UseVisualStyleBackColor = True
        '
        'btnDisplayFinalTotal
        '
        Me.btnDisplayFinalTotal.Location = New System.Drawing.Point(342, 61)
        Me.btnDisplayFinalTotal.Name = "btnDisplayFinalTotal"
        Me.btnDisplayFinalTotal.Size = New System.Drawing.Size(161, 23)
        Me.btnDisplayFinalTotal.TabIndex = 8
        Me.btnDisplayFinalTotal.Text = "Display Final Total"
        Me.btnDisplayFinalTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(15, 284)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(428, 284)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 10
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(224, 284)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAll.TabIndex = 11
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'frmVBFinalExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 321)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayFinalTotal)
        Me.Controls.Add(Me.btnDisplayEmpRecord)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVBFinalExam"
        Me.Text = "6-PP-1M"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents txtEmployee As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayEmpRecord As System.Windows.Forms.Button
    Friend WithEvents btnDisplayFinalTotal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button

End Class
