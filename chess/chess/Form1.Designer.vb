<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChessForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.calibrationCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "render"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'calibrationCheckBox
        '
        Me.calibrationCheckBox.AutoSize = True
        Me.calibrationCheckBox.Location = New System.Drawing.Point(223, 247)
        Me.calibrationCheckBox.Name = "calibrationCheckBox"
        Me.calibrationCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.calibrationCheckBox.Size = New System.Drawing.Size(113, 17)
        Me.calibrationCheckBox.TabIndex = 1
        Me.calibrationCheckBox.Text = "Terrible Calibration"
        Me.calibrationCheckBox.UseVisualStyleBackColor = True
        '
        'ChessForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 511)
        Me.Controls.Add(Me.calibrationCheckBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ChessForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Chess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents calibrationCheckBox As CheckBox
End Class
