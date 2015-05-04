'Exercise 3-2-42 page 83
'Programmer: Samantha Naini
'Date: 2/6/2012
'Program Purpose: Compute the percentage of the baseball games won for a particular MLB team.

Option Explicit On
Option Strict On

Public Class frmBaseball

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim gameswon, gameslost, percentage As Double
        Dim team As String


        gameswon = CDbl(txtWon.Text)
        gameslost = CDbl(txtLost.Text)
        team = CStr(txtTeam.Text)



        percentage = gameswon / (gameswon + gameslost) * 100
        percentage = Math.Round(percentage, 3)

        txtPercentage.Text = "The  " & team & "  won " & percentage & " percent of their games. "


    End Sub


End Class


