<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNutrition
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNameOfFood = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtGramsOfFat = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of food:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calories per serving:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grams per serving:"
        '
        'txtNameOfFood
        '
        Me.txtNameOfFood.Location = New System.Drawing.Point(121, 12)
        Me.txtNameOfFood.Name = "txtNameOfFood"
        Me.txtNameOfFood.Size = New System.Drawing.Size(134, 20)
        Me.txtNameOfFood.TabIndex = 3
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(121, 38)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(134, 20)
        Me.txtCalories.TabIndex = 4
        '
        'txtGramsOfFat
        '
        Me.txtGramsOfFat.Location = New System.Drawing.Point(121, 65)
        Me.txtGramsOfFat.Name = "txtGramsOfFat"
        Me.txtGramsOfFat.Size = New System.Drawing.Size(134, 20)
        Me.txtGramsOfFat.TabIndex = 5
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(15, 91)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(240, 23)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute % of Calories from Fat"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(15, 120)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(240, 56)
        Me.lstOutput.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 182)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(180, 182)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 9
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmNutrition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 214)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtGramsOfFat)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtNameOfFood)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNutrition"
        Me.Text = "Nutrition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNameOfFood As System.Windows.Forms.TextBox
    Friend WithEvents txtCalories As System.Windows.Forms.TextBox
    Friend WithEvents txtGramsOfFat As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
