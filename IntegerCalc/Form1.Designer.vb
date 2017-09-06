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
        Me.Input1Label = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.Input2Label = New System.Windows.Forms.Label()
        Me.Input1TextBox = New System.Windows.Forms.TextBox()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.Input2TextBox = New System.Windows.Forms.TextBox()
        Me.PlusButton = New System.Windows.Forms.Button()
        Me.MalButton = New System.Windows.Forms.Button()
        Me.DividiertButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.ModuloButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input1Label
        '
        Me.Input1Label.AutoSize = True
        Me.Input1Label.Location = New System.Drawing.Point(33, 45)
        Me.Input1Label.Name = "Input1Label"
        Me.Input1Label.Size = New System.Drawing.Size(40, 13)
        Me.Input1Label.TabIndex = 0
        Me.Input1Label.Text = "Zahl 1:"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(33, 96)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(51, 13)
        Me.OutputLabel.TabIndex = 1
        Me.OutputLabel.Text = "Ergebnis:"
        '
        'Input2Label
        '
        Me.Input2Label.AutoSize = True
        Me.Input2Label.Location = New System.Drawing.Point(33, 70)
        Me.Input2Label.Name = "Input2Label"
        Me.Input2Label.Size = New System.Drawing.Size(40, 13)
        Me.Input2Label.TabIndex = 2
        Me.Input2Label.Text = "Zahl 2:"
        '
        'Input1TextBox
        '
        Me.Input1TextBox.Location = New System.Drawing.Point(95, 42)
        Me.Input1TextBox.Name = "Input1TextBox"
        Me.Input1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Input1TextBox.TabIndex = 3
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Enabled = False
        Me.OutputTextBox.Location = New System.Drawing.Point(95, 93)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OutputTextBox.TabIndex = 4
        '
        'Input2TextBox
        '
        Me.Input2TextBox.Location = New System.Drawing.Point(95, 67)
        Me.Input2TextBox.Name = "Input2TextBox"
        Me.Input2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Input2TextBox.TabIndex = 5
        '
        'PlusButton
        '
        Me.PlusButton.Location = New System.Drawing.Point(244, 42)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(26, 23)
        Me.PlusButton.TabIndex = 6
        Me.PlusButton.Text = "+"
        Me.PlusButton.UseVisualStyleBackColor = True
        '
        'MalButton
        '
        Me.MalButton.Location = New System.Drawing.Point(244, 70)
        Me.MalButton.Name = "MalButton"
        Me.MalButton.Size = New System.Drawing.Size(26, 23)
        Me.MalButton.TabIndex = 7
        Me.MalButton.Text = "*"
        Me.MalButton.UseVisualStyleBackColor = True
        '
        'DividiertButton
        '
        Me.DividiertButton.Location = New System.Drawing.Point(276, 70)
        Me.DividiertButton.Name = "DividiertButton"
        Me.DividiertButton.Size = New System.Drawing.Size(26, 23)
        Me.DividiertButton.TabIndex = 8
        Me.DividiertButton.Text = "/"
        Me.DividiertButton.UseVisualStyleBackColor = True
        '
        'MinusButton
        '
        Me.MinusButton.Location = New System.Drawing.Point(276, 42)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(26, 23)
        Me.MinusButton.TabIndex = 9
        Me.MinusButton.Text = "-"
        Me.MinusButton.UseVisualStyleBackColor = True
        '
        'ModuloButton
        '
        Me.ModuloButton.Location = New System.Drawing.Point(244, 99)
        Me.ModuloButton.Name = "ModuloButton"
        Me.ModuloButton.Size = New System.Drawing.Size(58, 23)
        Me.ModuloButton.TabIndex = 10
        Me.ModuloButton.Text = "Mod"
        Me.ModuloButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 174)
        Me.Controls.Add(Me.ModuloButton)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.DividiertButton)
        Me.Controls.Add(Me.MalButton)
        Me.Controls.Add(Me.PlusButton)
        Me.Controls.Add(Me.Input2TextBox)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.Input1TextBox)
        Me.Controls.Add(Me.Input2Label)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.Input1Label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input1Label As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents Input2Label As Label
    Friend WithEvents Input1TextBox As TextBox
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents Input2TextBox As TextBox
    Friend WithEvents PlusButton As Button
    Friend WithEvents MalButton As Button
    Friend WithEvents DividiertButton As Button
    Friend WithEvents MinusButton As Button
    Friend WithEvents ModuloButton As Button
End Class
