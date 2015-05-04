Option Explicit On
Option Strict On


Public Class frmTrainingHeartRate


    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim a, r, Beats As Double

        a = CDbl(txtBoxAge.Text)
        r = CDbl(txtBoxRHR.Text)


        Beats = 0.7 * (220 - a) + 0.3 * r
        Beats = Math.Round(Beats, 2)

        txtBoxTHR.Text = "Your THR is " & Beats & " beats per minute."

    End Sub

End Class
