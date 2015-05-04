'Programmer: Samantha Naini
'Exercise: 6-1-32 pg. 229
'Date: 4/5/2012
'Program purpose: Calculate when the population will grow to 10 billion.

Option Strict On
Option Explicit On

Public Class frmPopulation

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim pop, year As Double


        pop = 6.83
        year = 2010

        Do While pop < 10

            pop = pop + (0.0112 * pop)

            year = year + 1
        Loop

        txtAnswer.Text = CStr("" & year & "")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAnswer.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
