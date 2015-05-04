'Programmer: Samantha Naini
'Date: 3/5/2012
'Exercise: 4-2-28 pg. 127
'Program Purpose: To handle a savings account withdrawal. The program should request the 
'current balance and the amount of the withdrawal as input and then display the new balance.

Option Strict On
Option Explicit On


Public Class frmWithdrawal

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim CurrBal, Withdraw, NewBal As Double

        CurrBal = CDbl(txtCurrBal.Text)
        Withdraw = CDbl(txtWithdraw.Text)

        NewBal = CurrBal - Withdraw

        If Withdraw > CurrBal Then

            txtNewBal.Text = "" & FormatCurrency(NewBal) & ""
            lstStatus.Items.Add("Withdrawal denied.")

        ElseIf NewBal < 150 Then
            txtNewBal.Text = "" & FormatCurrency(NewBal) & ""
            lstStatus.Items.Add("Balance below $150.")

        ElseIf CBool(NewBal) Then

            txtNewBal.Text = "" & FormatCurrency(NewBal) & ""
            lstStatus.Items.Add("Withdrawal complete.")

        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCurrBal.Clear()
        txtCurrBal.Focus()

        txtWithdraw.Clear()
        txtNewBal.Clear()
        lstStatus.Items.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class
