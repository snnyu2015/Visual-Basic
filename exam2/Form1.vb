'Programmer: Samantha Naini
'Exercise: Exam 2
'Date: 3/1/2012
'Program purpose: Write a program to calculate Finance Charges and Current Amount Due.


Option Strict On
Option Explicit On


Public Class frmAccounts



    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        Dim Account As String
        Dim PastDue, Payments, Purchases, FinanceCharges, CurrAmtDue As Double

        Account = CStr(txtAccount.Text)
        PastDue = CDbl(txtPastDue.Text)
        Payments = CDbl(txtPayments.Text)
        Purchases = CDbl(txtPurchases.Text)

        FinanceCharges = (PastDue - Payments) * 0.015

        CurrAmtDue = (PastDue - Payments) + Purchases + FinanceCharges

        txtFinCharge.Text = FormatCurrency(FinanceCharges)
        txtCurrAmtDue.Text = FormatCurrency(CurrAmtDue)






    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txtAccount.Clear()
        txtAccount.Focus()

        txtPastDue.Clear()
        txtPayments.Clear()
        txtPurchases.Clear()
        txtFinCharge.Clear()
        txtCurrAmtDue.Clear()

    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click

        Dim prompt, title As String

        prompt = "Have a great day! :)"
        title = "End"

        MessageBox.Show(prompt, title)
        Me.Close()


    End Sub

 
End Class
