Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPercentFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String
        dblAnswer = CDbl(txtUserEntry.Text)
        strResult = dblAnswer.ToString("p")
        lblResult.Text = strResult
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnFullDate.Click
        Dim Answer As Date
        Dim strResult As String
        Answer = CDate(txtUserEntry.Text)
        strResult = Answer.ToString("F")
        lblResult.Text = strResult
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNumberFormat_Click(sender As Object, e As EventArgs) Handles btnNumberFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String
        dblAnswer = CDbl(txtUserEntry.Text)
        strResult = dblAnswer.ToString("n")
        lblResult.Text = strResult
    End Sub

    Private Sub btnFixedPointFormat_Click(sender As Object, e As EventArgs) Handles btnFixedPointFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String
        dblAnswer = CDbl(txtUserEntry.Text)
        strResult = dblAnswer.ToString("f")
        lblResult.Text = strResult
    End Sub

    Private Sub btnExponential_Click(sender As Object, e As EventArgs) Handles btnExponential.Click
        Dim dblAnswer As Double
        Dim strResult As String
        dblAnswer = CDbl(txtUserEntry.Text)
        strResult = dblAnswer.ToString("e")
        lblResult.Text = strResult
    End Sub

    Private Sub btnCurrencyFormat_Click(sender As Object, e As EventArgs) Handles btnCurrencyFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String
        dblAnswer = CDbl(txtUserEntry.Text)
        strResult = dblAnswer.ToString("c")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        Dim Answer As Date
        Dim strResult As String
        Answer = CDate(txtUserEntry.Text)
        strResult = Answer.ToString("d")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongDate_Click(sender As Object, e As EventArgs) Handles btnLongDate.Click
        Dim Answer As Date
        Dim strResult As String
        Answer = CDate(txtUserEntry.Text)
        strResult = Answer.ToString("D")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShortTime_Click(sender As Object, e As EventArgs) Handles btnShortTime.Click
        Dim Answer As Date
        Dim strResult As String
        Answer = CDate(txtUserEntry.Text)
        strResult = Answer.ToString("t")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongTime_Click(sender As Object, e As EventArgs) Handles btnLongTime.Click
        Dim Answer As Date
        Dim strResult As String
        Answer = CDate(txtUserEntry.Text)
        strResult = Answer.ToString("T")
        lblResult.Text = strResult
    End Sub
End Class
