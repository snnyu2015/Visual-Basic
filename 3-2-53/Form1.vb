
Option Strict On
Option Explicit On

Public Class fmAverageScore

    Dim sum As Double 'sum of the scores entered
    Dim num As Integer 'number of the scores entered

  



    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        num += 1
        sum += CDbl(txtScore.Text)
        txtScore.Clear()
        txtScore.Focus()
    End Sub


    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        txtAverage.Text = CStr(sum / num)
    End Sub
End Class
