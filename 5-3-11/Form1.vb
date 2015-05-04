'Programmer: Samantha Naini
'Exercise: 5-3-11
'Date:4/23/2012
'Program Purpose: Calculating pay raises by entering an original salary.

Option Strict On
Option Explicit On

Public Class frmPayRaise

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim firstName As String = ""
        Dim lastName As String = ""
        Dim salary, newSalary As Double

        InputData(firstName, lastName, salary)
        newSalary = RaisedSalary(salary)
        DisplayOutput(firstName, lastName, newSalary)
    End Sub


    Sub InputData(ByRef firstName As String, ByRef lastName As String, ByRef salary As Double)
        firstName = txtFirstname.Text
        lastName = txtLastName.Text

        If IsNumeric(txtCurrSalary.Text) Then
            salary = CDbl(txtCurrSalary.Text)
        End If


        If salary = Nothing Then
            MessageBox.Show("Please enter a valid number.")
            txtOutput.Text = " "
        End If

        If firstName = Nothing And lastName = Nothing Then
            MessageBox.Show("Please enter a name.")
            txtOutput.Text = " "
        End If
    End Sub


    Function RaisedSalary(ByVal salary As Double) As Double
        If salary <= 40000 Then
            Return 1.05 * salary
        Else
            Return salary + 2000 + 0.02 * (salary - 40000)

        End If
    End Function


    Sub DisplayOutput(ByVal firstName As String, ByVal lastName As String, ByVal newSalary As Double)
        If firstName = Nothing And lastName = Nothing And newSalary = Nothing Then
            txtOutput.Text = ""
        Else
            txtOutput.Text = "New salary for " & firstName & " " & lastName & " is: " & FormatCurrency(newSalary) & "."
        End If
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFirstname.Clear()
        txtFirstname.Focus()
        txtLastName.Clear()
        txtCurrSalary.Clear()
        txtOutput.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            MsgBox("have a great day! =)")
            Me.Close()
        End If
    End Sub

End Class
