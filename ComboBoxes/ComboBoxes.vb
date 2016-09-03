Public Class ComboBoxes
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Display the combo box selections.
        lblCountry.Text = cboCountry.Text
        lblPlay.Text = cboPlay.Text
        lblArtist.Text = cboArtist.Text
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset the combo boxes.
        cboCountry.SelectedIndex = -1
        cboCountry.Text = String.Empty
        cboPlay.SelectedIndex = -1
        cboPlay.Text = String.Empty
        cboArtist.SelectedIndex = -1
        ' Note: cboArtist.Text is read-only.
        ' Reset the labels.
        lblCountry.Text = String.Empty
        lblPlay.Text = String.Empty
        lblArtist.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

End Class
