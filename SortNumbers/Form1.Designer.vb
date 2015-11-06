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
        Me.lblAns = New System.Windows.Forms.Label()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter first number: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter second number: "
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Location = New System.Drawing.Point(129, 127)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(0, 13)
        Me.lblAns.TabIndex = 2
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(15, 119)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 29)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(132, 19)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(63, 20)
        Me.txtNum1.TabIndex = 4
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(132, 56)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(63, 20)
        Me.txtNum2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 158)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sort Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAns As System.Windows.Forms.Label
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox

End Class
