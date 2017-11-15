Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcualteAverage_Click(sender As Object, e As EventArgs) Handles btnCalcualteAverage.Click
        Dim dblTotal As Double
        Dim dblAverage As Double
        Try
            dblTotal = CDbl(txtTestScore1.Text) + CDbl(txtTestScore2.Text) + CDbl(txtTestScore3.Text) +
                CDbl(txtTestScore4.Text) + CDbl(txtTestScore5.Text)

            dblAverage = CDbl(dblTotal) /
                CDbl(5)
            lblAverage.Text = dblAverage.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScore1.Clear()
        txtTestScore2.Clear()
        txtTestScore3.Clear()
        txtTestScore4.Clear()
        txtTestScore5.Clear()




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
