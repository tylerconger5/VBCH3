Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblTimeToday.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Delcare Variables for the Calculationis.
        Dim decRoomCharges As Decimal 'Room charges
        Dim decAddCharges As Decimal  'Additional charges 
        Dim decSubtotal As Decimal    'Subtotal 
        Dim decTax As Decimal         'Tax
        Dim decTotal As Decimal       'Total of all charges 
        Const decTax_RATE As Decimal = 0.08D ' Tax Rate 
        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
            CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            'Calculate and display the additional charges. 
            decAddCharges = CDec(txtRoomService.Text) *
            CDec(txtTelephone.Text) +
            CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            'Calculate and display the subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            'Calcualte and display the tax
            decTax = decSubtotal * decTax_RATE
            lblTax.Text = decTax.ToString("c")

            'Calcualte and display the total charges.
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")

        Catch ex As Exception
            ' Error Message 
            MessageBox.Show("All input must be valid numeric values.")
        End Try





        



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the rooom info fileds.
        txtNights.Clear()
        txtNightlyCharge.Clear()

        ' Clear the additional charges fields.
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        ' Clear the decToal fields.
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Get today's date from the operating system and display it.
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the operating system and dispaly it. 
        lblTimeToday.Text = Now.ToString("T")

        ' Reset the focus to the first field.
        txtNights.Focus()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()

    End Sub
End Class
