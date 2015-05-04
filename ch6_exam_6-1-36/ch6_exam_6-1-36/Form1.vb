
' name: Samantha Naini
' Date: 4/12/2012
' Exercise: Ch 6 exam (6-1-36)
' Program purpose: Calculating  a savings plan annuity with 3% interest compounded per month.


Option Strict On
Option Explicit On

Public Class frmCh6Exam

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim Deposit, numOfMonths, intRate As Double

        If txtDeposit.Text = Nothing And txtIntRate.Text = Nothing Then
            MessageBox.Show("Monthly deposit and/or interest rate is not valid. please re-enter data.", "6-1-36")
        Else
            If IsNumeric(txtDeposit.Text) And IsNumeric(txtIntRate.Text) Then

                Deposit = CDbl(txtDeposit.Text)
                intRate = CDbl(txtIntRate.Text)

                Do Until Deposit > 3000

                    Deposit = 1.0025 * Deposit + 100
                    numOfMonths += 1
                Loop


                txtAcctBal.Text = FormatCurrency("" & Deposit & "")
                txtNumOfMonths.Text = ("" & numOfMonths & "")
            End If
        End If

    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtDeposit.Clear()
        txtDeposit.Focus()
        txtIntRate.Clear()
        txtNumOfMonths.Clear()
        txtAcctBal.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click

        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            MsgBox("have a nice day!")
            Me.Close()
        End If

    End Sub


End Class
