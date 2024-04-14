Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged

        If RadioButton1.Checked = True Then
            Try
                PictureBox1.Image = Image.FromFile("Tamaulipas.png")
            Catch ex As Exception
            End Try
            Try
                RichTextBox1.LoadFile("Tamaulipas.rtf")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            AxWindowsMediaPlayer1.URL = "TAMAULIPAS.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        ElseIf RadioButton2.Checked = True Then
            Try
                PictureBox1.Image = Image.FromFile("Oaxaca.jpg")
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            Try
                RichTextBox1.LoadFile("OAXACA.rtf")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            AxWindowsMediaPlayer1.URL = "OAXACA.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        ElseIf RadioButton3.Checked = True Then
            Try
                PictureBox1.Image = Image.FromFile("chiapas.jpg")
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            Try
                RichTextBox1.LoadFile("chiapas.rtf")
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            AxWindowsMediaPlayer1.URL = "CHIAPAS.mp4"
        End If

    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

        Try
            PictureBox1.Image = Image.FromFile("chiapas.jpg")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            RichTextBox1.LoadFile("chiapas.rtf")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        AxWindowsMediaPlayer1.URL = "CHIAPAS.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub


End Class
