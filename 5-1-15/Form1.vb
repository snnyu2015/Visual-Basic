'Programmer: Samantha Naini
'Exercise: 5-1-15
'Date: 4/16/2012
'Program purpose: To calculate a person's BMI via weight and height inputs.

Option Strict On
Option Explicit On

Public Class frmBMI

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim Weight As Double = CDbl(txtWeight.Text)
        Dim Height As Double = CDbl(txtHeight.Text)
        txtOutput.Text = CStr(BMI(Weight, Height))

        If CDbl(txtOutput.Text) > 19 And CDbl(txtOutput.Text) < 25 Then
            txtStatus.Text = "You are at a healthy weight."
        ElseIf CDbl(txtOutput.Text) < 19 Then
            txtStatus.Text = "You are underweight."
        Else
            txtStatus.Text = "You are overweight."
        End If


    End Sub

    Function BMI(ByVal w As Double, ByVal h As Double) As Double
        Return Math.Round((703 * w) / (h ^ 2))
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtWeight.Clear()
        txtWeight.Focus()
        txtHeight.Clear()
        txtOutput.Clear()
        txtStatus.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            MsgBox("have a great day! =)")
            Me.Close()
        End If
    End Sub
End Class



