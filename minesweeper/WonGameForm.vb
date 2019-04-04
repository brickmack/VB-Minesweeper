Public Class WonGameForm
    Dim numRows As Integer
    Dim numCols As Integer
    Dim numMines As Integer
    Dim time As Integer

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        gameForm.Close()
    End Sub

    Private Sub playAgainButton_Click(sender As Object, e As EventArgs) Handles playAgainButton.Click
        gameForm.clearField()
        gameForm.generateField()
        Close()
    End Sub

    Public Sub New(_numRows As Integer, _numCols As Integer, _numMines As Integer, _time As Integer, _isTimed As Boolean)
        'this call is required by the designer.
        InitializeComponent()

        'add any initialization after the InitializeComponent() call.
        numRows = _numRows
        numCols = _numCols
        numMines = _numMines
        time = _time

        timeLabel.Text = time.ToString()
        boardSizeLabel.Text = numRows & " x " & numCols & " = " & (numRows * numCols)

        timeLabel.Visible = _isTimed
        timeTextLabel.Visible = _isTimed
    End Sub
End Class