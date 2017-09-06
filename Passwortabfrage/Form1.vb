Public Class Form1
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        Select Case PasswordBox.Text
            Case "admin"
                OutputTextBox.Text = "Sie sind als Administrator angemeldet."

            Case "user"
                OutputTextBox.Text = "Sie sind als User angemeldet."

            Case Else
                OutputTextBox.Text = "Sie sind als Gast angemeldet."

        End Select

    End Sub
End Class
