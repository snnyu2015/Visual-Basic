'Programmer: Samantha Naini
'Exercise: 4-2-42 (exam)
'Date: 3/29/2012
'Program Purpose: Find best bank by calculating API.

Option Strict On
Option Explicit On



Public Class frmCompareIntRates

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim Rate1, Rate2, NumPeriod1, NumPeriod2, APYOne, APYTwo As Double
        Dim BestBank As String

        Rate1 = CDbl(txtRate1.Text) / 100
        Rate2 = CDbl(txtRate2.Text) / 100

        NumPeriod1 = CDbl(txtPeriod1.Text)
        NumPeriod2 = CDbl(txtPeriod2.Text)

        BestBank = CStr(txtBestBank.Text)


        APYOne = (1 + (Rate1 / NumPeriod1)) ^ NumPeriod1 - 1


        APYTwo = (1 + (Rate2 / NumPeriod2)) ^ NumPeriod2 - 1

        If APYOne > APYTwo Then
            txtBestBank.Text = " Bank 1 "
        Else
            txtBestBank.Text = " Bank 2 "
        End If

        txtAPY1.Text = FormatPercent(APYOne, 3)
        txtAPY2.Text = FormatPercent(APYTwo, 3)
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAPY1.Clear()
        txtAPY2.Clear()
        txtPeriod1.Clear()
        txtPeriod2.Clear()
        txtRate1.Clear()
        txtRate2.Clear()
        txtRate1.Focus()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class
