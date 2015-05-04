'Programmer: Samantha Naini
'Date: 3/5/2012
'Exercise: 4-2-26 pg. 127
'Program Purpose: Create a program with the button "Quit" that requests if the person really wants to quit or not by answering yes or no.

Option Strict On
Option Explicit On


Public Class frmQuitter

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click

        Dim AreYouSure As String

        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

            MessageBox.Show("Have a nice Day!", "Quit")
            Me.Close()

        End If


    End Sub
End Class
