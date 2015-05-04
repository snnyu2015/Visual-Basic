'Programmer: Samantha naini
'Exercise: VB Final Exam
'Program Purpose: Display gross pay and final total
'Date: 4/30/2012


Option Strict On
Option Explicit On

Public Class frmVBFinalExam
    Dim GrossPay As Double

    Private Sub btnDisplayEmpRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayEmpRecord.Click

        Dim Name As String
        Dim HoursWorked As Double
        Dim HourlyRate As Double
        Dim GetGrossPay As Double


        Name = CStr(txtEmployee.Text)

        If IsNumeric(txtHoursWorked.Text) Then
            HoursWorked = CDbl(txtHoursWorked.Text)
        End If

        If IsNumeric(txtPayRate.Text) Then
            HourlyRate = CDbl(txtPayRate.Text)
        End If

        InputData(Name, HoursWorked, HourlyRate, GetGrossPay)



    End Sub

    'Sub procedure for the input data

    Sub InputData(ByRef Name As String, ByRef HoursWorked As Double, ByRef HourlyRate As Double, ByRef GetGrossPay As Double)


        GetGrossPay = CDbl(CalcGrossPay(GrossPay, HourlyRate, HoursWorked))

        lstOutput.Items.Add("" & Name & "            " & FormatCurrency(HourlyRate) & "           " & HoursWorked & "             " & FormatCurrency(GetGrossPay) & "")

    End Sub

    'Function procedure to calculate Gross Pay

    Function CalcGrossPay(ByVal GrossPay As Double, ByVal HourlyRate As Double, ByVal HoursWorked As Double) As Double


        If HoursWorked <= 40 Then

            GrossPay = HoursWorked * HourlyRate

        ElseIf HoursWorked > 40 Then

            GrossPay = (40 * HourlyRate) + ((HoursWorked - 40) * ((HourlyRate * 0.5) + HourlyRate))

        End If

        If HourlyRate = Nothing Then
            MessageBox.Show("Invalid value for hourly rate")

        ElseIf HoursWorked = Nothing Then
            MessageBox.Show("Invalid Value for Hours worked")
        End If

        Return GrossPay


    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtEmployee.Clear()
        txtEmployee.Focus()
        txtHoursWorked.Clear()
        txtPayRate.Clear()
    End Sub


    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click

        txtEmployee.Clear()
        txtEmployee.Focus()
        txtHoursWorked.Clear()
        txtPayRate.Clear()
        lstOutput.Items.Clear()


    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MsgBox("Do you really want to quit?", MsgBoxStyle.YesNoCancel, "End Program") = MsgBoxResult.Yes Then
            MsgBox("Have a nice day!")
            Me.Close()
        End If
    End Sub

    Private Sub btnDisplayFinalTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayFinalTotal.Click
        Dim FinalTotal As Double
        Dim GetGrossPay As Double
        Dim HourlyRate As Double
        Dim HoursWorked As Double


        FinalTotal += GetGrossPay

        GetGrossPay = CDbl(CalcGrossPay(GrossPay, HourlyRate, HoursWorked))



        lstOutput.Items.Add("")
        lstOutput.Items.Add("Final Total: " & FormatCurrency(FinalTotal) & "")

    End Sub
End Class
