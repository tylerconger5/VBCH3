Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtGallons_TextChanged(sender As Object, e As EventArgs) Handles txtGallons.TextChanged

    End Sub

    Private Sub btnCalcualteMPG_Click(sender As Object, e As EventArgs) Handles btnCalcualteMPG.Click
        Dim dblMPg As Double
        Try
            dblMPg = CDbl(txtMiles.Text) /
                CDbl(txtGallons.Text)
            lblMPG.Text = dblMPg.ToString()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Clear()
        txtMiles.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
