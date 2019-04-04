'used to get size and number of mines from the user
'Can input both manually or Using standard game modes
'(same as the official Minesweeper modes)

Public Class sizePickerForm
    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        'submits the form and we can move on to the game

        Dim numRows As Integer
        Dim numCols As Integer
        Dim numMines As Integer

        If (Integer.TryParse(rowsField.Text, numRows) And (numRows > 0) And Integer.TryParse(colsField.Text, numCols) And (numCols > 0)) Then
            If (Integer.TryParse(minesField.Text, numMines) And numMines > 0) Then
                If (numMines < numRows * numCols / 2) Then
                    'finally confirmed its valid!

                    gameForm.numRows = numRows
                    gameForm.numCols = numCols
                    gameForm.numMines = numMines
                    gameForm.isTimed = timedCheckbox.Checked 'this one required no validation
                    Close()
                Else
                    MessageBox.Show("Invalid. Number of mines must be at most half the total number of cells")
                End If
            Else
                MessageBox.Show("Invalid. Mines must be a positive integer")
            End If
        Else
            MessageBox.Show("Invalid. Rows and columns must both be a positive integer")
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        'user cancels, nothing else to do so we just quite the program
        End
    End Sub

    Private Sub modeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modeBox.SelectedIndexChanged
        'as usual, here is your darn select case. Oh how I loathe this structure
        Select Case modeBox.SelectedIndex
            Case 0
                rowsField.Text = "9"
                colsField.Text = "9"
                minesField.Text = "10"
            Case 1
                rowsField.Text = "16"
                colsField.Text = "16"
                minesField.Text = "40"
            Case 2
                rowsField.Text = "16"
                colsField.Text = "30"
                minesField.Text = "99"
            Case 3
                rowsField.Text = ""
                colsField.Text = ""
                minesField.Text = ""
        End Select
    End Sub
End Class