# VB-Minesweeper
Minesweeper in Visual Basic. Derived from CS114 course project

## Usage
Gameplay is as standard in Minesweeper. Left-click to clear a mine, right-click to flag it

## Changelog

### V1.1

* Separate "cleared" attribute for Cells, deprecated previous method of simply setting the Button invisible

* Pausing/unpausing should hide the board state from the user (no cheating!)

* New game form now automatically changes mode to custom if any field is clicked

* Game mode text name can no longer be changed, its a pure dropdown list

* Removed some useless code/comments only there from when this was a school project

### V1.0

* Initial release

### Known bugs/problems

* Game crashes due to problem with showAllMines method if player is in expert mode (or custom mode with high number of cells) and loses or pauses a game. Reason unknown.

* Hidden board state when paused still shows flagged mines

* After losing a game, player must manually select file -> new game
