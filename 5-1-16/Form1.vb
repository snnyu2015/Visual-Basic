'Programmer: Samantha Naini
'Date: 4/18/2012
'Exercise: 5-1-16 pg. 173
'Program Purpose: Computing someone's training heart rate


Option Strict On
Option Explicit On

Public Class frmTrainingHeartRate


    Function FindTrainingHeartRate(ByVal Age As Double, ByVal RHR As Double) As Double
        Dim MaxHR As Double
        MaxHR = 220 - Age
        Return (MaxHR - RHR) * 0.6 + RHR
    End Function

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim Age, RHR, THR As Double

        Age = CDbl(txtAge.Text)
        RHR = CDbl(txtRHR.Text)

        THR = Math.Round(FindTrainingHeartRate(Age, RHR))

        txtTHR.Text = "Your training heart rate is " & THR & "."
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAge.Clear()
        txtAge.Focus()
        txtRHR.Clear()
        txtTHR.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "Quit!") = MsgBoxResult.Yes Then
            MessageBox.Show("Have a great day! =)")
            Me.Close()
        End If
    End Sub
End Class
