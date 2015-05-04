'Programmer: Samantha Naini
'exercise: 5-3-12
'Date: 4/23/2012
'Program Purpose: Calculating new balance and minimum payment on a credit card.



Public Class frmCreditCard

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim OldBal As Double
        Dim Charges As Double
        Dim Credits As Double
        Dim NewBal As Double
        Dim MinPayment As Double

        OldBal = CDbl(txtOldBal.Text)
        Charges = CDbl(txtCharges.Text)
        Credits = CDbl(txtCredits.Text)



        'calls the function and sub procedures:

        'sub InputData
        InputData(OldBal, Charges, Credits)

        'function CalculateNewValues
        CalculateNewValues(OldBal, Charges, Credits, NewBal, MinPayment)

        'sub DisplayData
        DisplayData(NewBal, MinPayment)

    End Sub


    Sub InputData(ByRef OldBal As Double, ByRef Charges As Double, ByRef Credits As Double)
        OldBal = CDbl(txtOldBal.Text)
        Charges = CDbl(txtCharges.Text)
        Credits = CDbl(txtCredits.Text)

    End Sub

    Function CalculateNewValues(ByRef OldBal As Double, ByRef Charges As Double, ByRef Credits As Double, ByRef NewBal As Double, ByRef MinPayment As Double)



        NewBal = OldBal - Credits + Charges + (OldBal * 0.015)

        MinPayment = 0.015 * OldBal

        If NewBal <= 20 Then
            MinPayment = NewBal
        Else
            MinPayment = 20 + (0.1 * (NewBal - 20))
        End If



    End Function

    Sub DisplayData(ByRef NewBal As Double, ByRef MinPayment As Double)

        Dim OldBal, Charges, Credits As Double

        OldBal = CDbl(txtOldBal.Text)
        Charges = CDbl(txtCharges.Text)
        Credits = CDbl(txtCredits.Text)

        txtNewBal.Text = "" & FormatCurrency(NewBal) & ""
        txtMinPayment.Text = " " & FormatCurrency(MinPayment) & " "
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtOldBal.Clear()
        txtOldBal.Focus()
        txtCharges.Clear()
        txtCredits.Clear()
        txtNewBal.Clear()
        txtMinPayment.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            MsgBox("have a nice day!")
            Me.Close()
        End If
    End Sub
End Class
