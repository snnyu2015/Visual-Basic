<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdealWeights
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
        Me.btnComputeIdealWeights = New System.Windows.Forms.Button()
        Me.lstWeightTable = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnComputeIdealWeights
        '
        Me.btnComputeIdealWeights.Location = New System.Drawing.Point(50, 12)
        Me.btnComputeIdealWeights.Name = "btnComputeIdealWeights"
        Me.btnComputeIdealWeights.Size = New System.Drawing.Size(164, 23)
        Me.btnComputeIdealWeights.TabIndex = 0
        Me.btnComputeIdealWeights.Text = "Display Ideal Weights"
        Me.btnComputeIdealWeights.UseVisualStyleBackColor = True
        '
        'lstWeightTable
        '
        Me.lstWeightTable.FormattingEnabled = True
        Me.lstWeightTable.Location = New System.Drawing.Point(12, 41)
        Me.lstWeightTable.Name = "lstWeightTable"
        Me.lstWeightTable.Size = New System.Drawing.Size(231, 199)
        Me.lstWeightTable.TabIndex = 1
        '
        'frmIdealWeights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 260)
        Me.Controls.Add(Me.lstWeightTable)
        Me.Controls.Add(Me.btnComputeIdealWeights)
        Me.Name = "frmIdealWeights"
        Me.Text = "Ideal Weights"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnComputeIdealWeights As System.Windows.Forms.Button
    Friend WithEvents lstWeightTable As System.Windows.Forms.ListBox

End Class
