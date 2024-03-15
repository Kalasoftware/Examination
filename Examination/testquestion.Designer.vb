<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class testquestion
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
        Me.components = New System.ComponentModel.Container()
        Me.queslbl = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timelbl = New System.Windows.Forms.Label()
        Me.shwotimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'queslbl
        '
        Me.queslbl.AutoSize = True
        Me.queslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.queslbl.Location = New System.Drawing.Point(326, 43)
        Me.queslbl.Name = "queslbl"
        Me.queslbl.Size = New System.Drawing.Size(115, 31)
        Me.queslbl.TabIndex = 0
        Me.queslbl.Text = "Quesoin"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.RadioButton1.Location = New System.Drawing.Point(64, 150)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(197, 35)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.RadioButton2.Location = New System.Drawing.Point(64, 220)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(197, 35)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.RadioButton3.Location = New System.Drawing.Point(513, 150)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(197, 35)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.RadioButton4.Location = New System.Drawing.Point(513, 220)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(197, 35)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(273, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "1"
        '
        'timelbl
        '
        Me.timelbl.AutoSize = True
        Me.timelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.timelbl.Location = New System.Drawing.Point(58, 43)
        Me.timelbl.Name = "timelbl"
        Me.timelbl.Size = New System.Drawing.Size(82, 31)
        Me.timelbl.TabIndex = 6
        Me.timelbl.Text = "00:30"
        '
        'shwotimer
        '
        Me.shwotimer.Interval = 1000
        '
        'testquestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.timelbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.queslbl)
        Me.Name = "testquestion"
        Me.Text = "testquestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents queslbl As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents timelbl As Label
    Friend WithEvents shwotimer As Timer
End Class
