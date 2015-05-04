'Programmer: Samantha Naini
'Exercise: Chapter 4 Programming Project 2
'Date: 3/15/2012
'Program purpose: To calculate a food item's percent calories from fat.

Option Strict On
Option Explicit On


Public Class frmNutrition

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim strNameOfFood, strLimit As String
        Dim dblCalories, dblGramsOfFat, dblPctOfCalories As Double

        If txtNameOfFood.Text = Nothing Or txtCalories.Text = Nothing Or txtGramsOfFat.Text = Nothing Then

            MsgBox("One or more of the data input is blank. please try again!")
        Else
            strNameOfFood = txtNameOfFood.Text
            dblCalories = CDbl(txtCalories.Text)
            dblGramsOfFat = CDbl(txtGramsOfFat.Text)

            dblPctOfCalories = dblGramsOfFat * 9 / dblCalories

            If dblPctOfCalories > 0.3 Then

                strLimit = " exceeds "
            Else
                strLimit = " does not exceed "
            End If
            With lstOutput.Items.Add("" & strNameOfFood & " contains " & Format(FormatPercent(dblPctOfCalories, 2)) & " from fat.")
                lstOutput.Items.Add("" & strNameOfFood & "" & strLimit & " the AHA recommendation.")
            End With
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNameOfFood.Clear()
        txtNameOfFood.Focus()
        txtCalories.Clear()
        txtGramsOfFat.Clear()
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "Quit") = MsgBoxResult.Yes Then
            MessageBox.Show("Have a nice day!", "Quit")
            Me.Close()
        End If
    End Sub
End Class
