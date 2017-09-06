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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.BeendenButton = New System.Windows.Forms.Button()
        Me.ZurücksetztenButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(572, 60)
        Me.ProgressBar.TabIndex = 0
        '
        'ProgressLabel
        '
        Me.ProgressLabel.AutoSize = True
        Me.ProgressLabel.Location = New System.Drawing.Point(9, 75)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(52, 13)
        Me.ProgressLabel.TabIndex = 1
        Me.ProgressLabel.Text = "0 Prozent"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 107)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(113, 23)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'BeendenButton
        '
        Me.BeendenButton.Location = New System.Drawing.Point(471, 107)
        Me.BeendenButton.Name = "BeendenButton"
        Me.BeendenButton.Size = New System.Drawing.Size(113, 23)
        Me.BeendenButton.TabIndex = 3
        Me.BeendenButton.Text = "Beenden"
        Me.BeendenButton.UseVisualStyleBackColor = True
        '
        'ZurücksetztenButton
        '
        Me.ZurücksetztenButton.Location = New System.Drawing.Point(232, 107)
        Me.ZurücksetztenButton.Name = "ZurücksetztenButton"
        Me.ZurücksetztenButton.Size = New System.Drawing.Size(113, 23)
        Me.ZurücksetztenButton.TabIndex = 4
        Me.ZurücksetztenButton.Text = "Zurücksetzten"
        Me.ZurücksetztenButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 142)
        Me.Controls.Add(Me.ZurücksetztenButton)
        Me.Controls.Add(Me.BeendenButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ProgressLabel)
        Me.Controls.Add(Me.ProgressBar)
        Me.Name = "Form1"
        Me.Text = "Fortschritsanzeige"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents ProgressLabel As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents BeendenButton As Button
    Friend WithEvents ZurücksetztenButton As Button
End Class
