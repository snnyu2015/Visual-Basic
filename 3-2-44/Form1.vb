'Exercise 3-2-44 page 83
'Programmer: Samantha Naini
'Date: 2/6/2012
'Program Purpose: Request a company's earnings per share for the year and the price of 
'one share of stock as input, and then display the company's price-to-earnings ratio (which is price/earnings).
Option Explicit On
Option Strict On

Public Class frmEPS

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim ratio, share, earnings As Double


        share = CDbl(txtPriceOfStock.Text)
        earnings = CDbl(txtEarnings.Text)
        ratio = CDbl(txtPriceOfStock.Text) / CDbl(txtEarnings.Text)
        ratio = Math.Round(ratio, 3)

        txtRatio.Text = "The company's earnings-per-share are " & ratio & " ."

    End Sub

    End Class
