'Programmer: Samantha Naini
'Exercise: Chapter 4 Programming Project 1
'Date: 3/26/2012
'Program purpose: Eddie's Equipment Rental & Bill


Option Strict On
Option Explicit On

Public Class frmEquipRental


    Dim dblRugCleanerH As Double = 16
    Dim dblRugCleanerF As Double = 24
    Dim dblLawnMowerH As Double = 12
    Dim dblLawnMowerF As Double = 18
    Dim dblPaintSprayerH As Double = 20
    Dim dblPaintSprayerF As Double = 30
    Dim dblDeposit As Double = 30


    Private Sub btnDisplayRentals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRentals.Click


        Dim fmtStr As String = "{0, -20} {1,-13:C} {2,-13:C}"
        With lstPrices.Items.Clear()
            .Add(String.Format(fmtStr, "Price of Equipment", "Half-day", "Full-day"))
            .Add(String.Format(fmtStr, "1. Rug cleaner", dblRugCleanerH, dblRugCleanerF))
            .Add(String.Format(fmtStr, "2. Lawn mower", dblLawnMowerH, dblLawnMowerF))
            .Add(String.Format(fmtStr, "3. Paint sprayer", dblPaintSprayerH, dblPaintSprayerF))
        End With
    End Sub

    Private Sub btnDisplayBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBill.Click
        Dim strItem, strDuration, strItemSelected, strMessage, fmtStr As String
        Dim dblItemPrice As Double


        'Textbox inputs:
        strItem = txtItem.Text
        strDuration = txtDuration.Text.ToUpper.Substring(0, 1)


        Select Case strItem & strDuration

            Case "1H"
                strItemSelected = "Rug cleaner"
                dblItemPrice = dblRugCleanerH
            Case "1F"
                strItemSelected = "Rug cleaner"
                dblItemPrice = dblRugCleanerF
            Case "2H"
                strItemSelected = "Lawn mower"
                dblItemPrice = dblLawnMowerH
            Case "2F"
                strItemSelected = "Lawn mower"
                dblItemPrice = dblLawnMowerF
            Case "3H"
                strItemSelected = "Paint sprayer"
                dblItemPrice = dblPaintSprayerH
            Case "3F"
                strItemSelected = "Paint sprayer"
                dblItemPrice = dblPaintSprayerF
            Case Else
                MessageBox.Show("I'm sorry, but the values you entered are invalid. Please try again.", "Try again")
                txtDuration.Clear()
                txtItem.Clear()
        End Select

        If strDuration = "H" Then
            strMessage = "(Half-day rental)"
        Else
            strMessage = "(Full-day rental)"
        End If
        With lstBill.Items.Clear()
            .Add(String.Format(fmtStr, "Receipt from Eddie's Equipment Rental", "", ""))
            .Add(String.Format(fmtStr, strItemSelected, dblItemPrice, strMessage))
            .Add(String.Format(fmtStr, "Deposit", dblDeposit, ""))
            .Add("")
            .Add(String.Format(fmtStr, "Total", dblItemPrice + dblDeposit, ""))

        End With

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstPrices.Items.Clear()
        lstBill.Items.Clear()
        txtItem.Clear()
        txtDuration.Clear()
        txtItem.Focus()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class
