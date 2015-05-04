'Programmer: Samantha Naini
'Date: 4/18/2012
'Exercise: 5-2-36 (pg. 188)
'Program Purpose: To display someone's letter grade by calculating the average of three numeric grades.


Option Strict On
Option Explicit On

Public Class frmSemesterGrades

    Function CalculatedGrade(ByVal FirstGrade As Double, ByVal SecondGrade As Double, ByVal ThirdGrade As Double) As String

        Dim LowestGrade As Double, NumericGrade As Double
        Dim GradeLetter As String = Nothing

        LowestGrade = GetLowest(FirstGrade, SecondGrade, ThirdGrade)
        NumericGrade = (FirstGrade + SecondGrade + ThirdGrade - LowestGrade) / 2

        Select Case Math.Round(NumericGrade)
            Case 90 To 100
                GradeLetter = "A"
            Case 80 To 89
                GradeLetter = "B"
            Case 70 - 79
                GradeLetter = "C"
            Case 60 To 69
                GradeLetter = "D"
            Case 0 To 59
                GradeLetter = "F"
            Case Else
                GradeLetter = "Invalid"
        End Select

        Return GradeLetter
    End Function

    Function GetLowest(ByVal FirstGrade As Double, ByVal SecondGrade As Double, ByVal ThirdGrade As Double) As Double
        Dim LowestGrade As Double
        LowestGrade = FirstGrade

        If SecondGrade < LowestGrade Then
            LowestGrade = SecondGrade
        End If
        If ThirdGrade < LowestGrade Then

            LowestGrade = ThirdGrade
        End If

        Return LowestGrade
    End Function



    Private Sub DisplayGrade(ByVal Name As String, ByVal FirstGrade As Double, ByVal SecondGrade As Double, ByVal ThirdGrade As Double)

        Dim GradeLetter As String

        GradeLetter = CalculatedGrade(FirstGrade, SecondGrade, ThirdGrade)
        txtOutput.Text = "" & Name & ": " & GradeLetter & ""
    End Sub



    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim Name As String
        Dim FirstGrade, SecondGrade, ThirdGrade As Double

        Name = CStr(txtName.Text)
        If IsNumeric(txtFirstGrade.Text) And IsNumeric(txtSecondGrade.Text) And IsNumeric(txtThirdGrade.Text) Then

            FirstGrade = CDbl(txtFirstGrade.Text)
            SecondGrade = CDbl(txtSecondGrade.Text)
            ThirdGrade = CDbl(txtThirdGrade.Text)
        End If

        DisplayGrade(Name, FirstGrade, SecondGrade, ThirdGrade)
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtName.Focus()
        txtFirstGrade.Clear()
        txtSecondGrade.Clear()
        txtThirdGrade.Clear()
        txtOutput.Clear()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "Quit!") = MsgBoxResult.Yes Then
            MessageBox.Show("Have a great day! =)")
            Me.Close()
        End If
    End Sub

End Class
