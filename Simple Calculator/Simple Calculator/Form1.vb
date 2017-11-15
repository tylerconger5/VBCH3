Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        'This event handler performs addition
        'Declare a variabel to hold the result
        Dim dlbResult As Double
        lblOperation.Text = "+"

        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)

        lblResult = CStr(lblResult)

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        'This event handler performs subtraction

        Dim dlbResult As Double
        lblOperation.Text = "-"

        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)

        lblResult = CStr(lblResult)
    End Sub
End Class
