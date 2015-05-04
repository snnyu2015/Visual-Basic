<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFurnitureSales
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
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtBoxItem = New System.Windows.Forms.TextBox()
        Me.txtBoxPrice = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnCommission = New System.Windows.Forms.Button()
        Me.lstBoxResults = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(26, 36)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(30, 13)
        Me.lblItem.TabIndex = 0
        Me.lblItem.Text = "Item:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(94, 36)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Price:"
        '
        'txtBoxItem
        '
        Me.txtBoxItem.Location = New System.Drawing.Point(53, 33)
        Me.txtBoxItem.Name = "txtBoxItem"
        Me.txtBoxItem.Size = New System.Drawing.Size(35, 20)
        Me.txtBoxItem.TabIndex = 2
        '
        'txtBoxPrice
        '
        Me.txtBoxPrice.Location = New System.Drawing.Point(123, 33)
        Me.txtBoxPrice.Name = "txtBoxPrice"
        Me.txtBoxPrice.Size = New System.Drawing.Size(48, 20)
        Me.txtBoxPrice.TabIndex = 3
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(26, 69)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(145, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Item and Price"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnCommission
        '
        Me.btnCommission.Location = New System.Drawing.Point(26, 98)
        Me.btnCommission.Name = "btnCommission"
        Me.btnCommission.Size = New System.Drawing.Size(145, 23)
        Me.btnCommission.TabIndex = 5
        Me.btnCommission.Text = "Show Total Commission"
        Me.btnCommission.UseVisualStyleBackColor = True
        '
        'lstBoxResults
        '
        Me.lstBoxResults.FormattingEnabled = True
        Me.lstBoxResults.Location = New System.Drawing.Point(26, 128)
        Me.lstBoxResults.Name = "lstBoxResults"
        Me.lstBoxResults.Size = New System.Drawing.Size(145, 95)
        Me.lstBoxResults.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(26, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(74, 22)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Start Over"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(129, 228)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(42, 23)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmFurnitureSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 272)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstBoxResults)
        Me.Controls.Add(Me.btnCommission)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtBoxPrice)
        Me.Controls.Add(Me.txtBoxItem)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblItem)
        Me.Name = "frmFurnitureSales"
        Me.Text = "Furniture Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtBoxItem As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnCommission As System.Windows.Forms.Button
    Friend WithEvents lstBoxResults As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
