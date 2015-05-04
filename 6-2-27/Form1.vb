
Option Strict On
Option Explicit On


Public Class frmIdealWeights

    Private Sub btnComputeIdealWeights_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputeIdealWeights.Click
        Dim lower, upper As Integer


        lower = CInt(InputBox("Enter lower bound on height in inches:"))
        upper = CInt(InputBox("Enter upper bound on height in inches:"))

       


        lstWeightTable.Items.Add("HEIGHT|WOMEN'S WEIGHT|MEN'S WEIGHT")
        For height As Integer = lower To upper
            lstWeightTable.Items.Add(height & "   " & FormatNumber(IdealWoman(height), 1) & "  " & FormatNumber(IdealMan(height), 1))
        Next


    End Sub

    Do Until weight = 156
    Function IdealMan(ByVal height As Integer) As Double
        Return 4 * height - 128
    End Function

    Function IdealWoman(ByVal height As Integer) As Double
        Return 3.5 * height - 108
    End Function

    Loop




End Class
