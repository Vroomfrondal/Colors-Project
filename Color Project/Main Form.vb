' Name:         Color Project
' Purpose:      Displays an item's color.
' Programmer:   Christopher DeLeon on 4.10.2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'Required Variables 
        Dim strItemNum As String
        Dim strColor As String = String.Empty
        strItemNum = txtItem.Text.Trim

        'If numbers are 5, select appropriate color-case
        If strItemNum.Length = 5 Then
            Select Case strItemNum.Substring(2, 1)
                Case "B", "b"
                    strColor = "Blue"
                Case "G", "g"
                    strColor = "Green"
                Case "R", "r"
                    strColor = "Red"
                Case "W", "w"
                    strColor = "White"
                Case Else
                    MessageBox.Show("Invalid 3rd Character", "Item Number",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

            'If Numbers are not 5
        Else MessageBox.Show("Invalid Length", "Item Number", MessageBoxButtons.OK,
                             MessageBoxIcon.Information)
        End If

        'Focus txtItem Color step
        lblColor.Text = strColor
        txtItem.Focus()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtItem_Enter(sender As Object, e As EventArgs) Handles txtItem.Enter
        txtItem.SelectAll()
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        lblColor.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
