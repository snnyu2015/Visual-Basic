'Programmer: Samantha Naini
'Date: 3/5/2012
'Exercise: 4-2-37, pg.128
'Program Purpose: To show and hide the name of the programming language by clicking a button.

Option Strict On
Option Explicit On

Public Class frmHideAndSeek

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If lblLanguage.Visible Then
            lblLanguage.Visible = False
            btnDisplay.Text = "Show Name of Language"

        Else
            lblLanguage.Visible = True
            btnDisplay.Text = "Hide Name of Language"

        End If

    End Sub
End Class
