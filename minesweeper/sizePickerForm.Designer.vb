<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sizePickerForm
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
        Me.okButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rowsField = New System.Windows.Forms.TextBox()
        Me.colsField = New System.Windows.Forms.TextBox()
        Me.minesField = New System.Windows.Forms.TextBox()
        Me.timedCheckbox = New System.Windows.Forms.CheckBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.modeBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(165, 111)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "&Ok"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rows:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Columns:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mines:"
        '
        'rowsField
        '
        Me.rowsField.Location = New System.Drawing.Point(64, 28)
        Me.rowsField.Name = "rowsField"
        Me.rowsField.Size = New System.Drawing.Size(100, 20)
        Me.rowsField.TabIndex = 4
        Me.rowsField.Text = "10"
        '
        'colsField
        '
        Me.colsField.Location = New System.Drawing.Point(64, 50)
        Me.colsField.Name = "colsField"
        Me.colsField.Size = New System.Drawing.Size(100, 20)
        Me.colsField.TabIndex = 5
        Me.colsField.Text = "10"
        '
        'minesField
        '
        Me.minesField.Location = New System.Drawing.Point(64, 72)
        Me.minesField.Name = "minesField"
        Me.minesField.Size = New System.Drawing.Size(100, 20)
        Me.minesField.TabIndex = 6
        Me.minesField.Text = "10"
        '
        'timedCheckbox
        '
        Me.timedCheckbox.AutoSize = True
        Me.timedCheckbox.Location = New System.Drawing.Point(10, 100)
        Me.timedCheckbox.Name = "timedCheckbox"
        Me.timedCheckbox.Size = New System.Drawing.Size(55, 17)
        Me.timedCheckbox.TabIndex = 7
        Me.timedCheckbox.Text = "Timed"
        Me.timedCheckbox.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelButton.Location = New System.Drawing.Point(246, 111)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 8
        Me.cancelButton.Text = "&Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'modeBox
        '
        Me.modeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.modeBox.FormattingEnabled = True
        Me.modeBox.Items.AddRange(New Object() {"Beginner", "Intermediate", "Expert", "Custom"})
        Me.modeBox.Location = New System.Drawing.Point(200, 12)
        Me.modeBox.Name = "modeBox"
        Me.modeBox.Size = New System.Drawing.Size(121, 21)
        Me.modeBox.TabIndex = 9
        '
        'sizePickerForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 146)
        Me.Controls.Add(Me.modeBox)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.timedCheckbox)
        Me.Controls.Add(Me.minesField)
        Me.Controls.Add(Me.colsField)
        Me.Controls.Add(Me.rowsField)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.okButton)
        Me.Name = "sizePickerForm"
        Me.Text = "Game properties"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents okButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rowsField As TextBox
    Friend WithEvents colsField As TextBox
    Friend WithEvents minesField As TextBox
    Friend WithEvents timedCheckbox As CheckBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents modeBox As ComboBox
End Class
