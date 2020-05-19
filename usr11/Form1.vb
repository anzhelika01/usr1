Option Explicit On
Imports System.Drawing.Color
Imports System.Math
Public Class Form1
    Dim AxisController As AxisController
    Public WithEvents _dataController As DataController
    Private Sub ButtonStartClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        _dataController = New DataController(Timer1)
        _dataController.IsResistanceIncluded = RadioButton1.Checked
        _dataController.InitData(Val(TextBoxAlpha0.Text), Val(TextBoxV0.Text), Val(TextBoxDt.Text), Val(TextBoxH.Text))
        Timer1.Enabled = True
    End Sub
    Private Sub ButtonInitClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonInit.Click
        AxisController = New AxisController(Axis1)
        AxisController.InitAxis(Val(TextBoxXBase.Text), Val(TextBoxYBase.Text))
        ButtonStart.Enabled = True
    End Sub

    Private Sub ButtonStopClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub OnDataCalculated() Handles _dataController.DataCalculated
        AxisController.DrawTrajectory(_dataController.X, _dataController.Y, GetPixColor())
        AxisController.DrawCore(_dataController.X, _dataController.Y, GetPixColor())
    End Sub

    Private Sub OnTextBoxDataUpdated() Handles _dataController.TextBoxDataUpdated
        UpdateTextBoxText(TextBoxXmax, _dataController.Xmax)
        UpdateTextBoxText(TextBoxYmax, _dataController.Ymax)
        UpdateTextBoxText(TextBoxVmax, _dataController.Vmax)
    End Sub

    Private Sub OnTimeTextBoxDataUpdated() Handles _dataController.TimeTextBoxDataUpdated
        UpdateTextBoxText(TextBoxT, _dataController.T)
    End Sub

    Private Function GetPixColor() As Color
        If RadioButton1.Checked Then
            Return Black
        Else Return Red
        End If
    End Function

    Private Sub UpdateTextBoxText(textBox As TextBox, value As Single)
        textBox.Text = Str(Round(value, 2))
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxAlpha0.Text = ""
        TextBoxV0.Text = ""
        TextBoxDt.Text = ""
        TextBoxH.Text = ""
        TextBoxXmax.Text = ""
        TextBoxYmax.Text = ""
        TextBoxVmax.Text = ""
        TextBoxT.Text = ""
        TextBoxXBase.Text = ""
        TextBoxYBase.Text = ""
    End Sub


End Class
