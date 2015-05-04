'Programmer: Samantha Naini
'Date: 3/5/2012
'Exercise: 4-2-24, pg.126
'Program Purpose: To display the cost of a number of copies when a copy center charges 
'5 cents/copy for the first 100 copies, and 3 cents/copy for each ADDITIONAL copy. 

Option Strict On
Option Explicit On


Public Class frmCopyCenter

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim NumOfCopies, Cost As Double

        NumOfCopies = CDbl(InputBox("Number of copies:"))

        If NumOfCopies < 100 Then
            Cost = 0.05 * NumOfCopies 'copies at 5 cents each

        ElseIf NumOfCopies > 100 Then

            Cost = 0.03 * (NumOfCopies - 100) + 5 'copies at 3 cents each; the 5 is five dollars for 100 copies at 5 cents each


        End If

        txtOutput.Text = "The cost is " & FormatCurrency(Cost) & "."



    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtOutput.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub


End Class
