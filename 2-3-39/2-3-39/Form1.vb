Public Class frmDemo

    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click

        txtFirst.ForeColor = Color.Red

    End Sub

    Private Sub txtFirst_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirst.Leave

        txtFirst.ForeColor = Color.Black

    End Sub


    Private Sub txtFirst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirst.TextChanged
        txtFirst.ForeColor = Color.Blue
    End Sub

    
End Class
