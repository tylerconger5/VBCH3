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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalculateRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassB)
        Me.GroupBox1.Controls.Add(Me.txtClassC)
        Me.GroupBox1.Controls.Add(Me.txtClassA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 271)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalRevenue)
        Me.GroupBox2.Controls.Add(Me.lblClassC)
        Me.GroupBox2.Controls.Add(Me.lblClassB)
        Me.GroupBox2.Controls.Add(Me.lblClassA)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 271)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Class B:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class C:"
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(70, 37)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(100, 20)
        Me.txtClassA.TabIndex = 3
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(70, 124)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(100, 20)
        Me.txtClassC.TabIndex = 4
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(70, 79)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(100, 20)
        Me.txtClassB.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Class A:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Class B:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Class C:"
        '
        'btnCalculateRevenue
        '
        Me.btnCalculateRevenue.Location = New System.Drawing.Point(45, 349)
        Me.btnCalculateRevenue.Name = "btnCalculateRevenue"
        Me.btnCalculateRevenue.Size = New System.Drawing.Size(112, 23)
        Me.btnCalculateRevenue.TabIndex = 2
        Me.btnCalculateRevenue.Text = "Calclate Revenue"
        Me.btnCalculateRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(242, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(414, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Revenue:"
        '
        'lblClassA
        '
        Me.lblClassA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassA.Location = New System.Drawing.Point(88, 43)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(84, 20)
        Me.lblClassA.TabIndex = 7
        '
        'lblClassB
        '
        Me.lblClassB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassB.Location = New System.Drawing.Point(88, 77)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(84, 22)
        Me.lblClassB.TabIndex = 8
        '
        'lblClassC
        '
        Me.lblClassC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassC.Location = New System.Drawing.Point(88, 111)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(84, 26)
        Me.lblClassC.TabIndex = 9
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenue.Location = New System.Drawing.Point(100, 153)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(72, 26)
        Me.lblTotalRevenue.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 407)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateRevenue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Revenue Generated "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassB As System.Windows.Forms.TextBox
    Friend WithEvents txtClassC As System.Windows.Forms.TextBox
    Friend WithEvents txtClassA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents lblClassC As System.Windows.Forms.Label
    Friend WithEvents lblClassB As System.Windows.Forms.Label
    Friend WithEvents lblClassA As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateRevenue As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
