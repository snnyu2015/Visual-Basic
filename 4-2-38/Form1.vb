'Programmer: Samantha Naini
'Date: 3/8/2012
'Exercise: 4-2-38 pg.128
'Program Purpose: Create a program displaying the tax on an income depending on the amount the person makes.


Option Strict On
Option Explicit On


Public Class frmIncomeTax

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim Income, Tax As Double
        Dim Output As String

        Income = CDbl(txtIncome.Text)
        Output = CStr(txtOutput.Text)

        If Income <= 20000 Then

            Tax = 0.02 * Income
            txtOutput.Text = "" & FormatCurrency(Tax) & ""

        ElseIf Income <= 50000 Then

            Tax = 400 + 0.025 * (Income - 20000)
            txtOutput.Text = "" & FormatCurrency(Tax) & ""
        Else

            Tax = 1150 + 0.025 * (Income - 50000)
            txtOutput.Text = "" & FormatCurrency(Tax) & ""

        End If


    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtIncome.Clear()
        txtIncome.Focus()
        txtOutput.Clear()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

End Class
