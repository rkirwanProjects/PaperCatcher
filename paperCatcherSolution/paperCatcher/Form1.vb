Public Class Form1

    'Sends player to game form
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form2.Show()
        Me.Hide()
    End Sub

    'Loads help form
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.Show()
    End Sub

End Class
