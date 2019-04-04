'cell class. Provides a Label representing the cell itself, a Button covering the cell,
'and keeps track of whether or not it has a mine, is flagged, and how many mines are near it

Public Class Cell
    Private _tile As Label
    Private _tileButton As Button
    Private _hasMine As Boolean
    Private _flagged As Boolean
    Private _adjacentMines As Integer

    Private _colors As Color() = {Color.Blue, Color.Green, Color.Red, Color.Purple, Color.Maroon, Color.Turquoise, Color.Black, Color.Gray}

    Public Property Tile As Label
        Get
            Return _tile
        End Get
        Set(value As Label)
            _tile = value
        End Set
    End Property

    Public Property TileButton As Button
        Get
            Return _tileButton
        End Get
        Set(value As Button)
            _tileButton = value
        End Set
    End Property

    Public Property HasMine As Boolean
        Get
            Return _hasMine
        End Get
        Set(value As Boolean)
            _hasMine = value
        End Set
    End Property

    Public Property Flagged As Boolean
        Get
            Return _flagged
        End Get
        Set(value As Boolean)
            _flagged = value
            If _flagged = True Then
                _tileButton.Text = "F"
            Else
                _tileButton.Text = ""
            End If
        End Set
    End Property

    Public Property AdjacentMines As Integer
        Get
            Return _adjacentMines
        End Get
        Set(value As Integer)
            _adjacentMines = value
            If (_hasMine = False) Then
                'show the number of adjacent mines
                _tile.Text = _adjacentMines.ToString()
                _tile.ForeColor = _colors(AdjacentMines - 1)
            Else
                'show M for mine
                _tile.ForeColor = Color.Black
                _tile.Text = "M"
            End If
        End Set
    End Property

    Function toggleFlag() As Integer
        If _flagged = False Then
            _flagged = True
            _tileButton.Text = "F"
            Return -1
        Else
            _flagged = False
            _tileButton.Text = ""
            Return 1
        End If
    End Function

    Public Sub New(x As Integer, y As Integer)
        _tileButton = New Button
        _tileButton.TextAlign = ContentAlignment.MiddleCenter
        _tileButton.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
        _tileButton.Size = New Drawing.Size(cellSize, cellSize)
        _tileButton.Location = New Point(2 + (cellSize + 2) * x, 26 + (cellSize + 2) * y)
        _tileButton.BackColor = Color.White
        _tileButton.ForeColor = Color.Red

        _tile = New Label
        _tile.TextAlign = ContentAlignment.MiddleCenter
        _tile.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
        _tile.Text = ""
        _tile.Size = New Drawing.Size(cellSize, cellSize)
        _tile.Location = New Point(2 + (cellSize + 2) * x, 26 + (cellSize + 2) * y)
        _tile.BorderStyle = BorderStyle.FixedSingle

        _adjacentMines = 0
    End Sub

    Shared Property cellSize As Integer
        'needs to be static/shared so we can get it from gameForm without needing to reference a specific cell
        Get
            Return 38
        End Get
        Set(value As Integer)
        End Set
    End Property
End Class