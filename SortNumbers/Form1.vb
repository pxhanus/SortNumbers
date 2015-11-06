'Patricia Hanus
'151106
'Sort Numbers
'__________________________________________________________________
Public Class Form1

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim firstNum As Integer = Val(Me.txtNum1.Text)
        Dim secondNum As Integer = Val(Me.txtNum2.Text)


        Call LowestToHighest(firstNum, secondNum)

        Me.lblAns.Text = firstNum & ", " & secondNum
    End Sub
    Sub LowestToHighest(ByRef lowest As Integer, ByRef highest As Integer)
        Dim temp As Integer
        If lowest > highest Then        'Swap values
            temp = lowest
            lowest = highest
            highest = temp
        End If
    End Sub

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged
        Me.lblAns.Text = Nothing
    End Sub

    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged
        Me.lblAns.Text = Nothing
    End Sub
End Class
