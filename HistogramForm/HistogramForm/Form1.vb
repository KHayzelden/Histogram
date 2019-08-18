Public Class Form1

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        Students.Text += 1
  
        If (Grade.Text = 100) Then
            Perfects.Text += 1
        End If

        If (Grade.Text >= 70) Then
            First.Text += 1
        ElseIf (Grade.Text >= 40) Then
            HighSecond.Text += 1
        ElseIf (Grade.Text >= 30) Then
            LowSecond.Text += 1
        Else
            Third.Text += 1
        End If

        UpdateHistogram_Click(sender, e)

    End Sub

    Private Sub UpdateHistogram_Click(sender As Object, e As EventArgs) Handles UpdateHistogram.Click


        PictureBox1.Size = New Size((Third.Text * 5), PictureBox1.Size.Height)

        PictureBox2.Size = New Size((LowSecond.Text * 5), PictureBox2.Size.Height)

        PictureBox3.Size = New Size((HighSecond.Text * 5), PictureBox3.Size.Height)

        PictureBox4.Size = New Size((First.Text * 5), PictureBox4.Size.Height)

    End Sub
End Class

