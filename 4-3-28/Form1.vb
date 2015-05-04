'Programmer: Samantha Naini
'Date: 3/12/2012
'Exercise: 4-3-28 pg. 141
'Program Purpose: Write a program that displays state facts.

Option Strict On
Option Explicit On

Public Class frmStateFacts

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        Dim Category, State, Answer As String

        State = txtState.Text.ToUpper()
        Category = txtCat.Text.ToUpper.Substring(0, 1)



        Select Case State & Category

            Case "CALIFORNIAF"
                Answer = "The California state flower is the Golden Poppy."

            Case "CALIFORNIAN"
                Answer = "California's nickname is the Golden State."

            Case "CALIFORNIAM"
                Answer = "California's motto is 'Eureka'."

            Case "INDIANAF"
                Answer = "Indiana's flower is the Peony."

            Case "INDIANAN"
                Answer = "Indiana's nickname is the Hoosier State."

            Case "INDIANAM"
                Answer = "Indiana's motto is 'the crossroads of America'."

            Case "MISSISSIPPIF"
                Answer = "Mississippi's flower is the Magnolia."

            Case "MISSISSIPPIN"
                Answer = "Mississippi's nickname is 'the Magnolia State'."

            Case "MISSISSIPPIM"
                Answer = "Mississippi's motto is  'by valor and arms'."

            Case "NEW YORKF"
                Answer = "New York's flower is the Rose."

            Case "NEW YORKN"
                Answer = "New York's nickname is the Empire State."

            Case "NEW YORKM"
                Answer = "New York's motto is 'Ever upward'."
            Case Else
                Answer = "invalid"

        End Select

        txtFact.Text = Answer

    End Sub




    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFact.Clear()
        txtState.Clear()
        txtState.Focus()
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

   
End Class
