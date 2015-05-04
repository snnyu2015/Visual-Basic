'Programmer: Samantha Naini
'Exercise: 3-3-74 pg.97
'Date: 2/20/2012
'Program purpose: Calculate the amount of a server's tip given the amount of the bill and the percentage tip obtained via input dialog boxes.


Option Strict On
Option Explicit On

Public Class frmServersTip


    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim Meal As Double = 0, percentageTip As Double = 0, amountOfTip As Double = 0

        Meal = CDbl(InputBox("Enter cost of meal", "Cost of Meal"))

        percentageTip = CDbl(InputBox("Enter percentage of tip", "Percentage Tip"))

        amountOfTip = Meal * percentageTip / 100


        txtResults.Text = "A " & FormatPercent(percentageTip / 100, 0) & " tip on " & FormatCurrency(Meal) & " is " & FormatCurrency(amountOfTip) & "."

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtResults.Clear()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class
