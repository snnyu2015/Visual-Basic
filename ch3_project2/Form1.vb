'Programmer: Samantha Naini
'Exercise: Programming Project 2, pg. 100
'Date: 2/23/2012
'Program Purpose: Display a simple auto repair bill showing the number of hours times 35 dollars, plus a 5% sales tax on supplies/parts cost.

Option Strict On
Option Explicit On


Public Class frmA1AutoRepair

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        Dim hourslabor, partssupplies, sum As Double
        Dim customer As String

        customer = CStr(txtCustomer.Text)

        hourslabor = CDbl(txtLabor.Text) * 35
        hourslabor = Math.Round(hourslabor, 2)

        partssupplies = CDbl(txtSupplies.Text) * 1.05
        partssupplies = Math.Round(partssupplies, 2)

        sum = partssupplies + hourslabor
        sum = Math.Round(sum, 2)

        lstResults.Items.Add("Customer:   " & customer & "")
        lstResults.Items.Add("Labor cost:   " & FormatCurrency(hourslabor) & "")
        lstResults.Items.Add("Parts cost:   " & FormatCurrency(partssupplies) & "")
        lstResults.Items.Add("Total cost:   " & FormatCurrency(sum) & "")

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCustomer.Clear()
        txtCustomer.Focus()
        txtLabor.Clear()
        txtSupplies.Clear()
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
