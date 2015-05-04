'Programmer: Samantha Naini
'Exercise: 6-1-30 pg. 238
'Date: 4/5/2012
'Program purpose: Illustrate the growth of money in a savings account.


Option Strict On
Option Explicit On


Public Class frmInterest

    Private Sub btnDetermine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetermine.Click
        Dim IntRate, Amount, TwiceAmount, numYears As Double

        Amount = CDbl(txtAmount.Text)
        IntRate = CDbl(txtRate.Text) / 100


        TwiceAmount = Amount * 2


        Do While Amount < TwiceAmount

            Amount = (1 + IntRate) * Amount

            numYears += 1
        Loop

        txtDouble.Text = CStr("" & numYears & "")

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        txtAmount.Focus()
        txtRate.Clear()
        txtDouble.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click

        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
