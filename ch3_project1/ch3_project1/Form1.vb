'Programmer: Samantha Naini
'Exercise: Programming Project 1, pg.100
'Date: 2/23/2012
'Program Purpose: Add, subtract, or multiply any two numbers entered by clicking on the corresponding buttons.

Option Strict On
Option Explicit On

Public Class frmCalculator



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Addition, a, b As Double

        a = CDbl(txt1stNum.Text)
        b = CDbl(txt2ndNum.Text)
        Addition = a + b

        txtResults.Text = "" & a & " + " & b & " = " & Addition & ""
        txt1stNum.Clear()
        txt2ndNum.Clear()
        txt1stNum.Focus()

    End Sub


    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        Dim Subtraction, c, d As Double

        c = CDbl(txt1stNum.Text)
        d = CDbl(txt2ndNum.Text)
        Subtraction = c - d

        txtResults.Text = "" & c & " - " & d & " = " & Subtraction & ""
        txt1stNum.Clear()
        txt2ndNum.Clear()
        txt1stNum.Focus()

    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click

        Dim Multiplication, f, g As Double

        f = CDbl(txt1stNum.Text)
        g = CDbl(txt2ndNum.Text)
        Multiplication = f * g

        txtResults.Text = "" & f & " x " & g & " = " & Multiplication & ""
        txt1stNum.Clear()
        txt2ndNum.Clear()
        txt1stNum.Focus()

    End Sub



    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txt1stNum.Clear()
        txt2ndNum.Clear()
        txt1stNum.Focus()
        txtResults.Clear()

    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Dim prompt, title As String

        prompt = "Enjoy the rest of your day!"
        title = "Bye bye"

        MessageBox.Show(prompt, title)
        Me.Close()

    End Sub
End Class
