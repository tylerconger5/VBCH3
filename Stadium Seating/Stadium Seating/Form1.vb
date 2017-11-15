Public Class Form1

    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        Dim dblRevOne As Double
        Dim dblRevTwo As Double
        Dim dblRevThree As Double
        Dim dblTotal As Double
        Try
            dblRevOne = CDbl(12) *
                CDbl(txtClassA.Text)
            lblClassA.Text = dblRevOne.ToString()

            dblRevTwo = CDbl(10) *
                CDbl(txtClassB.Text)
            lblClassB.Text = dblRevTwo.ToString()

            dblRevThree = CDbl(8) *
                CDbl(txtClassC.Text)
            lblClassC.Text = dblRevThree.ToString()

            dblTotal = CDbl(dblRevOne) + CDbl(dblRevTwo) + CDbl(dblRevThree)
            lblTotalRevenue.Text = dblTotal.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()



    End Sub
End Class
