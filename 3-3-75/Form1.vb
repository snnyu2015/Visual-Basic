'Programmer: Samantha Naini
'Exercise: 3-3-75 pg.97
'Date: 2/20/2012
'Program purpose: Compute a balance over a ten-year period by entering in prinicpal and interest Rate.

Option Strict On
Option Explicit On

Public Class frmSavings

    Dim Principal, Rate, Time, Result As Double



    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Principal = CDbl(txtPrincipal.Text)
        Rate = CDbl(txtIntRate.Text)
        Time = 10

        Result = Principal * (1 + Rate) ^ Time
        Result = Math.Round(Result, 2)



        lstResults.Items.Add("When " & FormatCurrency(Principal) & " is")
        lstResults.Items.Add("invested at " & FormatPercent(Rate) & "")
        lstResults.Items.Add("for " & Time & " years, the")
        lstResults.Items.Add("balance is " & FormatCurrency(Result) & ".")

    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPrincipal.Clear()
        txtIntRate.Clear()
        txtPrincipal.Focus()
        txtIntRate.Focus()

        lstResults.Items.Clear()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click

        Dim prompt, title As String

        prompt = "Have a great day!"
        title = "Goodbye"

        MessageBox.Show(prompt, title)
        Me.Close()


    End Sub

End Class
