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
        Me.btnCalcualteMPG = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcualteMPG
        '
        Me.btnCalcualteMPG.Location = New System.Drawing.Point(15, 204)
        Me.btnCalcualteMPG.Name = "btnCalcualteMPG"
        Me.btnCalcualteMPG.Size = New System.Drawing.Size(90, 40)
        Me.btnCalcualteMPG.TabIndex = 0
        Me.btnCalcualteMPG.Text = "Calculate MPG"
        Me.btnCalcualteMPG.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 204)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 40)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear "
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(251, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit "
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gallons of gas the car can hold"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of Miles it can be driven on a full tank "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Miles per Gallon:"
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(241, 35)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 20)
        Me.txtGallons.TabIndex = 6
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(241, 81)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 7
        '
        'lblMPG
        '
        Me.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMPG.Location = New System.Drawing.Point(239, 120)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(100, 23)
        Me.lblMPG.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 309)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcualteMPG)
        Me.Name = "Form1"
        Me.Text = "Miles Per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcualteMPG As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblMPG As System.Windows.Forms.Label

End Class
