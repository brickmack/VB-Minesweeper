'main window the game is played in

Public Class gameForm
    Public numRows As Integer
    Public numCols As Integer
    Public numMines As Integer
    Public isTimed As Boolean

    Public remainingCells As Integer
    Public remainingMines As Integer

    Private time As Integer
    Private timerLabel As Label
    Private remainingMinesLabel As Label

    Private paused As Boolean

    Public cells(,) As Cell

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()

        generateField()
    End Sub

    Public Sub clearField()
        'we have to clean up the existing field first
        For y As Integer = 0 To numRows - 1
            For x As Integer = 0 To numCols - 1
                Me.Controls.Remove(cells(x, y).Tile)
                Me.Controls.Remove(cells(x, y).TileButton)
            Next
        Next

        If isTimed = True Then
            Me.Controls.Remove(timerLabel)
        End If

        Me.Controls.Remove(remainingMinesLabel)
    End Sub

    Public Sub positionMines(clickedX As Integer, clickedY As Integer)
        'randomly set mine locations
        For i As Integer = 0 To numMines - 1
            Dim x As Integer = CInt(Math.Ceiling(Rnd() * (numCols - 1)))
            Dim y As Integer = CInt(Math.Ceiling(Rnd() * (numRows - 1)))

            If (cells(x, y).HasMine = False) And Not ((x = clickedX) Or (y = clickedY)) Then
                cells(x, y).HasMine = True
                cells(x, y).Tile.Text = "M"

                'increment adjacent count for each nearby mine
                For xA As Integer = x - 1 To x + 1
                    For yA As Integer = y - 1 To y + 1
                        If (xA > -1 And xA < numCols And yA > -1 And yA < numRows) Then
                            If Not (xA = x And yA = y) Then
                                cells(xA, yA).AdjacentMines = cells(xA, yA).AdjacentMines + 1
                            End If
                        End If
                    Next
                Next
            Else
                i = i - 1 'not very pretty, but eh
            End If
        Next
    End Sub

    Public Sub generateField()
        'get game properties from the user
        Dim sizePicker As New sizePickerForm()
        sizePicker.ShowDialog()

        remainingCells = numRows * numCols
        remainingMines = numMines

        'instantiate 2d array for cells
        Dim newCells(numCols, numRows) As Cell
        cells = newCells

        'set size
        Me.Size = New Size(70 + (Cell.cellSize + 2) * numCols, 110 + (Cell.cellSize + 2) * numRows)

        'fill in all the cells
        For y As Integer = 0 To numRows - 1
            For x As Integer = 0 To numCols - 1
                cells(x, y) = New Cell(x, y)

                AddHandler cells(x, y).TileButton.MouseUp, AddressOf cell_MouseUp

                Me.Controls.Add(cells(x, y).TileButton)
                Me.Controls.Add(cells(x, y).Tile)
            Next
        Next

        'positionMines()

        paused = False 'make sure this is true at the start of every new game

        If isTimed = True Then
            'create label for timer
            timerLabel = New Label
            timerLabel.Text = "0"
            timerLabel.Size = New Drawing.Size(10, 10)
            timerLabel.AutoSize = True
            timerLabel.Location = New Point(10, 50 + (Cell.cellSize + 2) * numRows)
            Me.Controls.Add(timerLabel)

            PauseUnpauseToolStripMenuItem.Visible = True 'hidden unless timer is on

            'reset timer
            time = 0
            timerLabel.Text = "00:00"
        End If

        'create remaining mines label
        remainingMinesLabel = New Label
        remainingMinesLabel.Text = remainingMines.ToString()
        remainingMinesLabel.Location = New Point(50, 50 + (Cell.cellSize + 2) * numRows)
        Me.Controls.Add(remainingMinesLabel)
    End Sub

    Private Sub cell_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If paused = False Then 'we don't allow anything to be done while the game is paused
            Dim clickedButton As Button = DirectCast(sender, Button)

            Dim clickedCell As Cell = cells(0, 0) 'the set value does nothing, just to shut up the error checking. Just need an empty variable
            'loop through the 2d array of cells to find which cell this button belongs to
            Dim cellX As Integer = 0
            Dim cellY As Integer = 0
            For y As Integer = 0 To numRows - 1
                For x As Integer = 0 To numCols - 1
                    If cells(x, y).TileButton Is clickedButton Then
                        clickedCell = cells(x, y)
                        cellX = x
                        cellY = y
                    End If
                Next
            Next

            If e.Button = MouseButtons.Right Then
                'toggle flag
                remainingMines = remainingMines + clickedCell.toggleFlag()
                remainingMinesLabel.Text = remainingMines.ToString()
                'toggleFlag returns either 1 or -1, indicating whether remainingMines
                'should be incremented or decremented. Flagging decrements, de-flagging increments
            ElseIf e.Button = MouseButtons.Left Then
                'Check if button is flagged or not. We ignore flagged ones, can't trigger a mine there
                If clickedCell.Flagged = False Then
                    clickedButton.Visible = False

                    'check if this is the first cell clicked. If it is, we generate the minefield
                    If remainingCells = numRows * numCols Then
                        'first cell clicked, position the mines
                        positionMines(cellX, cellY)
                        'calculate which adjacent cells should be automatically cleared
                        calculateCleared(cellX, cellY)

                        'start timer, if applicable
                        If (isTimed = True) Then
                            Timer1.Enabled = True
                        End If
                    Else
                        If clickedCell.HasMine() Then
                            'oops. end game
                            Timer1.Enabled = False
                            showAllMines()
                            MessageBox.Show("Hit a mine! Game over!")
                        Else
                            'calculate which adjacent cells should be automatically cleared
                            calculateCleared(cellX, cellY)
                        End If
                    End If
                End If
            End If

            'check if the field is cleared
            If checkIfCleared() = True Then
                Timer1.Enabled = False

                Dim winScreen As New WonGameForm(numRows, numCols, numMines, time, isTimed)
                winScreen.Show()
            End If
        End If
    End Sub

    Private Function checkIfCleared() As Boolean
        If remainingMines = 0 And remainingCells = numMines Then
            Return True
        End If
        Return False
    End Function

    Private Sub calculateCleared(x As Integer, y As Integer)
        'recursively clears adjacent cells which themselves are not adjacent to any mines

        'make sure the cell isn't flagged
        If cells(x, y).Flagged = False Then
            'clear this cell
            cells(x, y).TileButton.Visible = False
            remainingCells = remainingCells - 1

            'check the neighbors
            For xA As Integer = x - 1 To x + 1
                If (xA > -1 And xA < numCols) Then
                    For yA As Integer = y - 1 To y + 1
                        If (yA > -1 And yA < numRows) Then
                            If cells(x, y).AdjacentMines = 0 And cells(xA, yA).HasMine = False And cells(xA, yA).TileButton.Visible = True Then
                                calculateCleared(xA, yA)
                            End If
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub showAllMines()
        'for some reason this breaks on expert mode. not sure why
        For y As Integer = 0 To numCols - 1
            For x As Integer = 0 To numRows - 1
                cells(x, y).TileButton.Visible = False
            Next
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time + 1
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(time)
        timerLabel.Text = iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c)
    End Sub

    Private Sub PauseUnpauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseUnpauseToolStripMenuItem.Click
        If paused = False Then
            PauseUnpauseToolStripMenuItem.Text = "Unpause"
        Else
            PauseUnpauseToolStripMenuItem.Text = "Pause"
        End If

        Timer1.Enabled = paused 'confusing
        paused = Not paused 'flip state
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        clearField()
        generateField()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New AboutForm()
        about.ShowDialog()
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class