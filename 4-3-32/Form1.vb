'Programmer: Samantha Naini
'Date: 3/12/2012
'Exercise 4-3-32 pg. 142
'Program purpose: Write a program that allows to to pick a number from 1-3 and receive either an insult or a humorous quote.

Option Strict On
Option Explicit On

Public Class frmExercise32

    Private Sub btnHumor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHumor.Click
        Dim num As Integer

        num = CInt(txtNumber.Text)

        Select Case num
            Case 1 To 1
                txtSentence.Text = "'I cook with wine. Sometimes, I even add it to the food.' - W. C. Fields"
            Case 2 To 2
                txtSentence.Text = "'He taught me housekeeping; when I divorce I keep the house.' - Zsa Zsa Gabor"
            Case 3 To 3
                txtSentence.Text = "'Parrots make great pets. They have more personality than goldfish.' - Chevy Chase"
            Case Else
                txtSentence.Clear()
                txtNumber.Clear()
                txtNumber.Focus()
        End Select

    End Sub


    Private Sub btnInsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsult.Click
        Dim num As Integer

        num = CInt(txtNumber.Text)

        Select Case num
            Case 1 To 1
                txtSentence.Text = "Is your name Laryngitis? You're a pain in the neck!"
            Case 2 To 2
                txtSentence.Text = "I bet your brain feels as good as new, seeing that you've never used it."
            Case 3 To 3
                txtSentence.Text = "You have an inferiority complex -- and it's fully justified."
            Case Else
                txtSentence.Clear()
                txtNumber.Clear()
                txtNumber.Focus()
        End Select

    End Sub

End Class
