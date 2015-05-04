'Programmer: Samantha Naini
'Date: 3/12/2012
'Exercise: 4-3-27 pg. 141
'Program purpose: Write a program that requests an exam score and assigns a letter grade with a set scale. 


Option Strict On
Option Explicit On

Public Class frmGrades

    Private Sub btnGetGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetGrade.Click

        Dim score As Integer, letterGrade As String
        score = CInt(InputBox("What is the score?"))

        Select Case score

            Case 90 To 100
                letterGrade = "A"
            Case 80 To 89
                letterGrade = "B"
            Case 70 To 79
                letterGrade = "C"
            Case 60 To 69
                letterGrade = "D"
            Case 0 To 59
                letterGrade = "F"
            Case Else
                letterGrade = "Invalid"
        End Select
        txtOutput.Text = "The letter grade is " & letterGrade & "."
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtOutput.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class
