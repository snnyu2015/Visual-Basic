

'Programmer: Samantha Naini
'Date: 3/5/2012
'Exercise: 4-2-21, pg. 126
'Program Purpose: To determine how much to tip the server at a restaurant.


Option Strict On
Option Explicit On


Public Class frmTip

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click


        Dim cost, tip As Double
        cost = CDbl(InputBox("Enter cost of meal:"))
        tip = cost * 0.15
        If tip < 1 Then
            tip = 1
        End If

        txtOutput.Text = "Leave " & FormatCurrency(tip) & " for the tip."
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtOutput.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

End Class
