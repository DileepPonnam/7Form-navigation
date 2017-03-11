<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.wrongLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'scoreLabel
        '
        Me.scoreLabel.Location = New System.Drawing.Point(29, 54)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(229, 18)
        Me.scoreLabel.TabIndex = 1
        Me.scoreLabel.Text = "Label1"
        '
        'wrongLabel
        '
        Me.wrongLabel.Location = New System.Drawing.Point(29, 85)
        Me.wrongLabel.Name = "wrongLabel"
        Me.wrongLabel.Size = New System.Drawing.Size(229, 91)
        Me.wrongLabel.TabIndex = 2
        Me.wrongLabel.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(47, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start Over"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(164, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.Location = New System.Drawing.Point(29, 23)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(229, 18)
        Me.nameLabel.TabIndex = 5
        Me.nameLabel.Text = "Label3"
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.wrongLabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.Name = "Results"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scoreLabel As System.Windows.Forms.Label
    Friend WithEvents wrongLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents nameLabel As System.Windows.Forms.Label
End Class
