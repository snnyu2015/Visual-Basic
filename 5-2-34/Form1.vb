'Programmer: Samantha Naini
'Date: 4/18/2012
'Exercise: 5-2-34 (pg.188)
'Program Purpose: To compute a person's tip based on their occupation, amount of the bill, and percentage of the tip.


Option Strict On
Option Explicit On

Public Class frmGratuities

    Function GetTip(ByVal Bill As Double, ByVal Tip As Double) As Double
        Return Bill * (Tip / 100)
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim Occupation As String
        Dim Bill, Tip, Result As Double

        Occupation = CStr(txtOccupation.Text)
        Bill = CDbl(txtBill.Text)
        Tip = CDbl(txtPercentTip.Text)

        Result = Math.Round(GetTip(Bill, Tip))

        txtOutput.Text = "You should tip the " & Occupation & " " & FormatCurrency(Result) & "."
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtOccupation.Clear()
        txtBill.Clear()
        txtOccupation.Focus()
        txtPercentTip.Clear()
        txtOutput.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "Quit!") = MsgBoxResult.Yes Then
            MessageBox.Show("Have a great day! =)")
            Me.Close()
        End If
    End Sub

End Class
