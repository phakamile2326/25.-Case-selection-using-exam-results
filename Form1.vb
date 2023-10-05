Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Grade As String
        Grade = ComboBox1.Text

        Select Case Grade
            Case "A"
                TextBox2.Text = "High Distinction"
            Case "A-"
                TextBox2.Text = "Distinction"
            Case "B"
                TextBox2.Text = "Credit"
            Case "C"
                TextBox2.Text = "Pass"
            Case Else
                TextBox2.Text = "Fail"
        End Select


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
