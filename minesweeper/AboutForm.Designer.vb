<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(317, 261)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(53, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 74)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Minesweeper for Visual Basic"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Left-click to clear a cell, right click to flag it"
        '
        'AboutForm
        '
        Me.AcceptButton = Me.exitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(404, 294)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "AboutForm"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
