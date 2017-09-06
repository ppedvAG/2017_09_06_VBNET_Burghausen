Imports System.Threading

Public Class Form1
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartButton.Enabled = False
        ZurücksetztenButton.Enabled = False

        While ProgressBar.Value < ProgressBar.Maximum
            ProgressBar.Value += 1
            ProgressLabel.Text = $"{ProgressBar.Value} Prozent"

            Thread.Sleep(100)
            Application.DoEvents()
        End While

        StartButton.Enabled = True
        ZurücksetztenButton.Enabled = True
    End Sub

    Private Sub ZurücksetztenButton_Click(sender As Object, e As EventArgs) Handles ZurücksetztenButton.Click

        ProgressBar.Value = ProgressBar.Minimum
        ProgressLabel.Text = $"{ProgressBar.Value} Prozent"

    End Sub

    Private Sub BeendenButton_Click(sender As Object, e As EventArgs) Handles BeendenButton.Click

        ProgressBar.Value = ProgressBar.Maximum
        Close()

    End Sub
End Class
