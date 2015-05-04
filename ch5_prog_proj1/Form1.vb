'Programmer: Samantha Naini
'Exercise: Chapter 5 Programming Project 1
'Date: 4/22/2012
'Program Purpose: To calculate a student's GPA by entering a letter grade and number of credit hours.


Option Strict On
Option Explicit On

Public Class frmGPA

    
    Dim Grade As Double
    Dim CreditHours As Double


    Private Sub btnRecordGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecordGrades.Click

        Dim LetterGrade As String
        Dim CourseHours As Double

        LetterGrade = CStr(txtLetterGrade.Text.ToUpper)
        CourseHours = CDbl(txtCreditHrs.Text)

        If CourseHours = Nothing Then
            MessageBox.Show("Please enter the number of credit hours completed.")
        End If


        Select Case LetterGrade
            Case "A"
                Grade += 4.0 * CourseHours
                CreditHours += CourseHours
            Case "B"
                Grade += 3.0 * CourseHours
                CreditHours += CourseHours
            Case "C"
                Grade += 2.0 * CourseHours
                CreditHours += CourseHours
            Case "D"
                Grade += 1.0 * CourseHours
                CreditHours += CourseHours
            Case "F"
                Grade += 0.0 * CourseHours
                CreditHours += CourseHours
            Case Else
                MessageBox.Show("Please enter a valid letter grade.")
        End Select


        'clears the textboxes each time the grades are recorded
        txtLetterGrade.Clear()
        txtCreditHrs.Clear()
        txtLetterGrade.Focus()

    End Sub

    Function CalculateQualityPoints(ByVal CreditHours As Double, ByVal Grade As Double) As Double
        Dim GPA As Double
        GPA = Grade / CreditHours
        Return CDbl(FormatNumber(GPA, 1))
    End Function

    Private Sub btnCalculateGPA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateGPA.Click
        txtGPA.Text = CStr(CalculateQualityPoints(CreditHours, Grade))
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtLetterGrade.Clear()
        txtCreditHrs.Clear()
        txtGPA.Clear()
        txtLetterGrade.Focus()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click

        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            MsgBox("have a great day! =)")
            Me.Close()
        End If

    End Sub

  
End Class

