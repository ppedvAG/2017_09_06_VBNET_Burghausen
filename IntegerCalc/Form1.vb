Option Strict On

Public Class Form1
    Private Sub PlusButton_Click(sender As Object, e As EventArgs) Handles PlusButton.Click
        Dim zahl1 = CInt(Input1TextBox.Text)
        Dim zahl2 = CInt(Input2TextBox.Text)

        Dim ergebnis = zahl1 + zahl2

        OutputTextBox.Text = ergebnis.ToString()
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        OutputTextBox.Text = (CInt(Input1TextBox.Text) - CInt(Input2TextBox.Text)).ToString()
    End Sub

    Private Sub MalButton_Click(sender As Object, e As EventArgs) Handles MalButton.Click
        OutputTextBox.Text = (CInt(Input1TextBox.Text) * CInt(Input2TextBox.Text)).ToString()
    End Sub

    Private Sub DividiertButton_Click(sender As Object, e As EventArgs) Handles DividiertButton.Click
        OutputTextBox.Text = (CInt(Input1TextBox.Text) \ CInt(Input2TextBox.Text)).ToString()
    End Sub

    Private Sub ModuloButton_Click(sender As Object, e As EventArgs) Handles ModuloButton.Click
        OutputTextBox.Text = (CInt(Input1TextBox.Text) Mod CInt(Input2TextBox.Text)).ToString()
    End Sub
End Class
