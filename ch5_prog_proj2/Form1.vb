'Programmer: Samantha Naini
'Exercise: Chapter 5 Programming Project 2
'Date: 4/22/2012
'Program Purpose: Calculating and displaying a restaurant bill.


Option Strict On
Option Explicit On

Public Class frmRestaurantBill

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim PizzaSlices, Fries, SoftDrinks As Double

        If IsNumeric(txtPizza.Text) And IsNumeric(txtFries.Text) And IsNumeric(txtSoftDrinks.Text) Then

            PizzaSlices = CDbl(txtPizza.Text)
            Fries = CDbl(txtFries.Text)
            SoftDrinks = CDbl(txtSoftDrinks.Text)

            Bill(PizzaSlices, Fries, SoftDrinks)


        Else
            MessageBox.Show("The amount of slices, fries, and/or soft drink orders is invalid. Please try again")
        End If
    End Sub

    Private Sub Bill(ByVal PizzaSlices As Double, ByVal Fries As Double, ByVal SoftDrinks As Double)

        Dim CostOfSlices As Double
        Dim CostOfFries As Double
        Dim CostOfSoftDrinks As Double

        CostOfSlices = PizzaSlices * 1.75
        CostOfFries = Fries * 2
        CostOfSoftDrinks = SoftDrinks * 1.25

        'lists the bill in the listbox

        lstOutput.Items.Add("ITEM          QUANTITY          PRICE")
        lstOutput.Items.Add("Pizza slices                    " & PizzaSlices & "              " & FormatCurrency(CostOfSlices) & "")
        lstOutput.Items.Add("Fries                           " & Fries & "              " & FormatCurrency(CostOfFries) & " ")
        lstOutput.Items.Add("Soft Drinks                     " & SoftDrinks & "              " & FormatCurrency(CostOfSoftDrinks) & "")
        lstOutput.Items.Add("TOTAL                        " & FormatCurrency(TotalCost(CostOfSlices, CostOfFries, CostOfSoftDrinks)) & "")

    End Sub

    Function TotalCost(ByVal CostOfSlices As Double, ByVal CostOfFries As Double, ByVal CostOfSoftDrinks As Double) As Double

        Dim Total As Double
        Total = CostOfSlices + CostOfFries + CostOfSoftDrinks
        Return Total
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPizza.Clear()
        txtFries.Clear()
        txtSoftDrinks.Clear()
        lstOutput.Items.Clear()
        txtPizza.Focus()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click

        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            MsgBox("have a great day! =)")
            Me.Close()
        End If
    End Sub


End Class
