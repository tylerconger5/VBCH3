<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFullDate = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnPercentFormat = New System.Windows.Forms.Button()
        Me.btnCurrencyFormat = New System.Windows.Forms.Button()
        Me.btnExponential = New System.Windows.Forms.Button()
        Me.btnFixedPointFormat = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtUserEntry = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number or date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Formatted"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFullDate)
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Controls.Add(Me.btnShowDate)
        Me.GroupBox1.Controls.Add(Me.btnPercentFormat)
        Me.GroupBox1.Controls.Add(Me.btnCurrencyFormat)
        Me.GroupBox1.Controls.Add(Me.btnExponential)
        Me.GroupBox1.Controls.Add(Me.btnFixedPointFormat)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 231)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format "
        '
        'btnFullDate
        '
        Me.btnFullDate.Location = New System.Drawing.Point(151, 152)
        Me.btnFullDate.Name = "btnFullDate"
        Me.btnFullDate.Size = New System.Drawing.Size(111, 23)
        Me.btnFullDate.TabIndex = 9
        Me.btnFullDate.Text = "Full Date/ Time (F)"
        Me.btnFullDate.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(151, 123)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(108, 23)
        Me.btnLongTime.TabIndex = 8
        Me.btnLongTime.Text = "Long Time (T)"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(151, 94)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(108, 23)
        Me.btnShortTime.TabIndex = 7
        Me.btnShortTime.Text = "Short Time (t) "
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(154, 65)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(105, 23)
        Me.btnLongDate.TabIndex = 6
        Me.btnLongDate.Text = "Long Date (D)"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(151, 36)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(108, 23)
        Me.btnShowDate.TabIndex = 5
        Me.btnShowDate.Text = "Short Date (d)"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnPercentFormat
        '
        Me.btnPercentFormat.Location = New System.Drawing.Point(6, 152)
        Me.btnPercentFormat.Name = "btnPercentFormat"
        Me.btnPercentFormat.Size = New System.Drawing.Size(129, 23)
        Me.btnPercentFormat.TabIndex = 4
        Me.btnPercentFormat.Text = "Percent Fomrat (p)"
        Me.btnPercentFormat.UseVisualStyleBackColor = True
        '
        'btnCurrencyFormat
        '
        Me.btnCurrencyFormat.Location = New System.Drawing.Point(6, 123)
        Me.btnCurrencyFormat.Name = "btnCurrencyFormat"
        Me.btnCurrencyFormat.Size = New System.Drawing.Size(129, 23)
        Me.btnCurrencyFormat.TabIndex = 3
        Me.btnCurrencyFormat.Text = "Currency Format (c)"
        Me.btnCurrencyFormat.UseVisualStyleBackColor = True
        '
        'btnExponential
        '
        Me.btnExponential.Location = New System.Drawing.Point(6, 94)
        Me.btnExponential.Name = "btnExponential"
        Me.btnExponential.Size = New System.Drawing.Size(126, 23)
        Me.btnExponential.TabIndex = 2
        Me.btnExponential.Text = "Exponential Fomrat (e)"
        Me.btnExponential.UseVisualStyleBackColor = True
        '
        'btnFixedPointFormat
        '
        Me.btnFixedPointFormat.Location = New System.Drawing.Point(3, 65)
        Me.btnFixedPointFormat.Name = "btnFixedPointFormat"
        Me.btnFixedPointFormat.Size = New System.Drawing.Size(123, 23)
        Me.btnFixedPointFormat.TabIndex = 1
        Me.btnFixedPointFormat.Text = "Fixed-point Format (f)"
        Me.btnFixedPointFormat.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(6, 36)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(120, 23)
        Me.btnNumberFormat.TabIndex = 0
        Me.btnNumberFormat.Text = "Number Format (n)"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(147, 85)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(212, 28)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Label3"
        '
        'txtUserEntry
        '
        Me.txtUserEntry.Location = New System.Drawing.Point(150, 28)
        Me.txtUserEntry.Name = "txtUserEntry"
        Me.txtUserEntry.Size = New System.Drawing.Size(100, 20)
        Me.txtUserEntry.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 398)
        Me.Controls.Add(Me.txtUserEntry)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Format Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtUserEntry As System.Windows.Forms.TextBox
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShowDate As System.Windows.Forms.Button
    Friend WithEvents btnPercentFormat As System.Windows.Forms.Button
    Friend WithEvents btnCurrencyFormat As System.Windows.Forms.Button
    Friend WithEvents btnExponential As System.Windows.Forms.Button
    Friend WithEvents btnFixedPointFormat As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents btnFullDate As System.Windows.Forms.Button

End Class
