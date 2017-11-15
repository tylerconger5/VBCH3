Public Class txtCelsius

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAnwser.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblFahrenheit As Double
        Try
            dblFahrenheit = CDbl(1.8) * CDbl(txtCel.Text) + CDbl(32)
            lblAnwser.Text = dblFahrenheit.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)


    End Sub
End Class
