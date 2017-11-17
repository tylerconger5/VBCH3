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
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dblResult = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btntimes = New System.Windows.Forms.Button()
        Me.btndivide = New System.Windows.Forms.Button()
        Me.btnExponet = New System.Windows.Forms.Button()
        Me.btnModulus = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number 1"
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Location = New System.Drawing.Point(80, 147)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(53, 13)
        Me.lblOperation.TabIndex = 1
        Me.lblOperation.Text = "Operation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number 2 "
        '
        'dblResult
        '
        Me.dblResult.AutoSize = True
        Me.dblResult.Location = New System.Drawing.Point(84, 281)
        Me.dblResult.Name = "dblResult"
        Me.dblResult.Size = New System.Drawing.Size(40, 13)
        Me.dblResult.TabIndex = 3
        Me.dblResult.Text = "Result "
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(250, 245)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(222, 49)
        Me.lblResult.TabIndex = 4
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(250, 83)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 5
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(250, 209)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 6
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(250, 136)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(36, 24)
        Me.btnPlus.TabIndex = 7
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(321, 136)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(38, 24)
        Me.btnMinus.TabIndex = 8
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btntimes
        '
        Me.btntimes.Location = New System.Drawing.Point(380, 137)
        Me.btntimes.Name = "btntimes"
        Me.btntimes.Size = New System.Drawing.Size(36, 24)
        Me.btntimes.TabIndex = 9
        Me.btntimes.Text = "x"
        Me.btntimes.UseVisualStyleBackColor = True
        '
        'btndivide
        '
        Me.btndivide.Location = New System.Drawing.Point(250, 185)
        Me.btndivide.Name = "btndivide"
        Me.btndivide.Size = New System.Drawing.Size(36, 24)
        Me.btndivide.TabIndex = 10
        Me.btndivide.Text = "/"
        Me.btndivide.UseVisualStyleBackColor = True
        '
        'btnExponet
        '
        Me.btnExponet.Location = New System.Drawing.Point(323, 185)
        Me.btnExponet.Name = "btnExponet"
        Me.btnExponet.Size = New System.Drawing.Size(36, 24)
        Me.btnExponet.TabIndex = 11
        Me.btnExponet.Text = "^"
        Me.btnExponet.UseVisualStyleBackColor = True
        '
        'btnModulus
        '
        Me.btnModulus.Location = New System.Drawing.Point(380, 185)
        Me.btnModulus.Name = "btnModulus"
        Me.btnModulus.Size = New System.Drawing.Size(49, 24)
        Me.btnModulus.TabIndex = 12
        Me.btnModulus.Text = "MOD"
        Me.btnModulus.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(250, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(417, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 395)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnModulus)
        Me.Controls.Add(Me.btnExponet)
        Me.Controls.Add(Me.btndivide)
        Me.Controls.Add(Me.btntimes)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.dblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Simple Calculator "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOperation As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dblResult As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btntimes As System.Windows.Forms.Button
    Friend WithEvents btndivide As System.Windows.Forms.Button
    Friend WithEvents btnExponet As System.Windows.Forms.Button
    Friend WithEvents btnModulus As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
