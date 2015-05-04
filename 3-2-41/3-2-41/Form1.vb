'Exercise 3-2-41 page 83
'Programmer: Samantha Naini
'Date: 2/6/2012
'Program Purpose: Compute the number of pounds lost through entering
'the number of hours spent cycling, running, and swimming in a program
'entitled "Triathlon".
Option Explicit On
Option Strict On



Public Class frmTriathlon

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim cycling, running, swimming, weightloss As Double
        cycling = CDbl(txtBoxCycling.Text) * 200
        running = CDbl(txtBoxRunning.Text) * 475
        swimming = CDbl(txtBoxSwimming.Text) * 275
        weightloss = (cycling + running + swimming) / 3500
        weightloss = Math.Round(weightloss, 1)

        txtBoxWeightLoss.Text = weightloss & " pounds were lost."

    End Sub
End Class
