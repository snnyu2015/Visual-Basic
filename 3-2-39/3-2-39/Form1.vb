'Exercise 3-2-39 page 82
'Programmer: Samantha Naini
'Date: 2/6/2012
'Program Purpose: Compute the number of seconds between 
'lightning and thunder in a storm when the distance is equivalent to the number of seconds divided by 5.
Option Explicit On
Option Strict On

Public Class frmThunderstorm

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim distance As Double
        distance = CDbl(txtNumSeconds.Text) / 5
        distance = Math.Round(distance, 2)

        txtAnswer.Text = "The distance of the storm is " & distance & " miles."
    End Sub

  End Class
