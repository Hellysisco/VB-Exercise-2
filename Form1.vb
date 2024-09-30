Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Get use input and convert it to a number
        Dim enterNumber As Double

        'Check if the input is a valid number
        If Double.TryParse(txtEnterNumber.Text, enterNumber) Then
            'Conditional statements to check if the number is positive, negative, or zero
            If enterNumber > 0 Then
                lblResult.Text = "Positive Number"
            ElseIf enterNumber < 0 Then
                lblResult.Text = "Negative Number"
            Else
                lblResult.Text = "Zero"
            End If
        Else
            'Handle invalid iput
            lblResult.Text = "Please enter a valid number."
        End If
    End Sub
End Class
