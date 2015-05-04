'Programmer: Samantha Naini
'Date: 3/15/2012
'Exercise: 4-4-22 pg.152
'Program Purpose: Create a program processing someone's major, year, and languages selected.

Option Strict On
Option Explicit On

Public Class frmQuestionnaire

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        Dim sentence As String = Nothing
        If lstMajors.Text = Nothing Then
            MessageBox.Show("No major was selected.", "4-4-22")
        End If
        If radFreshman.Checked = False And radSophmore.Checked = False And radJunior.Checked = False And radSenior.Checked = False Then
            MessageBox.Show("No year was selected.", "4-4-22")
        End If
        If chkC.Checked Then
            sentence = "C"
        End If
        If chkCobol.Checked Then
            sentence &= "Cobol"
        End If
        If chkCPlus.Checked Then
            sentence &= "C++"
        End If
        If chkCSharp.Checked Then
            sentence &= "C#"
        End If
        If chkJava.Checked Then
            sentence &= "Java"
        End If
        If chkVisBasic.Checked Then
            sentence &= "Visual Basic"
        End If
        If sentence = Nothing Then
            MessageBox.Show("No languages studied.", "4-4-22")
        Else
            MessageBox.Show("The following languages studied: " & sentence & ".", "4-4-22")
        End If
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "Quit") = MsgBoxResult.Yes Then
            MessageBox.Show("Have a nice day!", "Quit")
            Me.Close()
        End If
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstMajors.SelectedItem = Nothing
        radFreshman.Checked = False
        radSophmore.Checked = False
        radJunior.Checked = False
        radSenior.Checked = False
        chkC.Checked = False
        chkCobol.Checked = False
        chkCPlus.Checked = False
        chkCSharp.Checked = False
        chkJava.Checked = False
        chkVisBasic.Checked = False
    End Sub
End Class

