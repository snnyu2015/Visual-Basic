'Programmer: Samantha Naini
'Date: 3/5/2012
'Exercise: 4-2-31 pg. 127
'Program Purpose: Write a program that requests as 
'input the number of hours a person works in a given week and his hourly wage, then displays his gross pay.

Option Strict On
Option Explicit On

Public Class frmGrossPay

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click


        Dim hours, wage, gross As Double

        hours = CDbl(txtHours.Text)
        wage = CDbl(txtWage.Text)


        If hours > 40 Then
            gross = (40 * wage) + (1.5 * wage * (hours - 40))
            txtGrossPay.Text = "" & FormatCurrency(gross) & ""

        ElseIf hours <= 40 Then

            gross = (hours * wage)
            txtGrossPay.Text = "" & FormatCurrency(gross) & ""

        End If

    End Sub

   
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtHours.Clear()
        txtHours.Focus()
        txtWage.Clear()
        txtGrossPay.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class
