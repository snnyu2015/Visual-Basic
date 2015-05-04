'Programmer: Samantha Naini
'Exercise: Chapter 6 Programming Project 1
'Date: 4/15/2012
'Program Purpose: To calculate the amount of caffeine left in a person's body after coffee consumption.


Option Strict On
Option Explicit On

Public Class frmCaffeine



    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim Milligrams As Double = 130
        Dim Hours As Double
        Dim HourlyMilligrams As Double


        'sub procedure to find out how many hours until 65mg remains:
        SixtyFiveMgRemains(Hours, Milligrams)

        'sub procedure to find out remaining quantity of mg after 24 hours (for one cup only):
        OneCup24Hours(Hours, Milligrams)

        'sub procedure to find out the mg left in system after 24 hours while consuming one whole cup per hour:
        HourlyCups(Hours, HourlyMilligrams)

    End Sub

    Sub SixtyFiveMgRemains(ByRef Hours As Double, ByRef Milligrams As Double)

        Do Until Milligrams <= 65
            Milligrams = Milligrams - (Milligrams * 0.13)
            Hours = Hours + 1
        Loop


        txt65mg.Text = CStr("" & Hours & " hours")
    End Sub

    Sub OneCup24Hours(ByRef Hours As Double, ByRef Milligrams As Double)

        Do Until Hours = 24
            Milligrams = Math.Round(Milligrams - (Milligrams * 0.13), 2)
            Hours = Hours + 1
        Loop

        txtOneCup24h.Text = CStr("" & Milligrams & " mg")
    End Sub


    '*****I am having trouble with this last procedure; my result always amounts to 0mg*****

    Sub HourlyCups(ByRef Hours As Double, ByRef HourlyMilligrams As Double)

        Do Until Hours <= 24
            HourlyMilligrams = HourlyMilligrams + (HourlyMilligrams - (HourlyMilligrams * 0.13))
            Hours += 1
        Loop

        txtHrlyCup24h.Text = CStr("" & HourlyMilligrams & " mg")
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txt65mg.Clear()
        txt65mg.Focus()
        txtOneCup24h.Clear()
        txtHrlyCup24h.Clear()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            MsgBox("Have a nice day!")
            Me.Close()
        End If
    End Sub
End Class

