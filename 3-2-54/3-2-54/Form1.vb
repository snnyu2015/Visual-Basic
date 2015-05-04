'Programmer: Samantha Naini
'Date: 2/20/2012
'Exercise 3-2-54 pg.84
'Program purpose: list furniture, price and commission.


Option Strict On
Option Explicit On

Public Class frmFurnitureSales

    Dim sumPrice As Double = 0.0

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        lstBoxResults.Items.Add(txtBoxItem.Text & ": " & txtBoxPrice.Text)

        sumPrice += CDbl(txtBoxPrice.Text)
        txtBoxItem.Clear()
        txtBoxPrice.Clear()
        txtBoxItem.Focus()


    End Sub


    Private Sub btnCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommission.Click

        Dim totalCommission As Double

        totalCommission = sumPrice * 0.06
        lstBoxResults.Items.Add("Total commission = " & totalCommission & "")
        sumPrice = 0.0
        txtBoxItem.Focus()
    End Sub




    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txtBoxItem.Clear()
        txtBoxPrice.Clear()
        lstBoxResults.Items.Clear()
        sumPrice = 0.0
        txtBoxItem.Focus()

    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close() 'this button ends the program
    End Sub

End Class
