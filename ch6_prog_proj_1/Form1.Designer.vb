<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaffeine
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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt65mg = New System.Windows.Forms.TextBox()
        Me.txtOneCup24h = New System.Windows.Forms.TextBox()
        Me.txtHrlyCup24h = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(61, 22)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(122, 23)
        Me.btnCompute.TabIndex = 0
        Me.btnCompute.Text = "Calculate Values"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "One cup: When will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "65mg remain?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "One cup: Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after 24 hours:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hourly cups: Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after 24 hours:"
        '
        'txt65mg
        '
        Me.txt65mg.Location = New System.Drawing.Point(126, 65)
        Me.txt65mg.Name = "txt65mg"
        Me.txt65mg.Size = New System.Drawing.Size(100, 20)
        Me.txt65mg.TabIndex = 4
        '
        'txtOneCup24h
        '
        Me.txtOneCup24h.Location = New System.Drawing.Point(126, 103)
        Me.txtOneCup24h.Name = "txtOneCup24h"
        Me.txtOneCup24h.Size = New System.Drawing.Size(100, 20)
        Me.txtOneCup24h.TabIndex = 5
        '
        'txtHrlyCup24h
        '
        Me.txtHrlyCup24h.Location = New System.Drawing.Point(126, 139)
        Me.txtHrlyCup24h.Name = "txtHrlyCup24h"
        Me.txtHrlyCup24h.Size = New System.Drawing.Size(100, 20)
        Me.txtHrlyCup24h.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 188)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(151, 188)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmCaffeine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 232)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtHrlyCup24h)
        Me.Controls.Add(Me.txtOneCup24h)
        Me.Controls.Add(Me.txt65mg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompute)
        Me.Name = "frmCaffeine"
        Me.Text = "Caffeine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt65mg As System.Windows.Forms.TextBox
    Friend WithEvents txtOneCup24h As System.Windows.Forms.TextBox
    Friend WithEvents txtHrlyCup24h As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
