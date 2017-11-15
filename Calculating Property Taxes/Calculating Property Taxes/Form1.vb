Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblVlaue As Double
        Dim dblOut As Double

        Try
            dblVlaue = CDbl(txtPrice.Text) * CDbl(0.6)
            lblValue.Text = dblVlaue.ToString

            dblOut = CDbl(lblValue.Text) / CDbl(100) * CDbl(0.064)
            lblOut.Text = dblOut.tostring

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
