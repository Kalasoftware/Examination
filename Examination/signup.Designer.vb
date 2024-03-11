<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userbox = New System.Windows.Forms.TextBox()
        Me.passbox = New System.Windows.Forms.TextBox()
        Me.repassbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.regbtn = New System.Windows.Forms.Button()
        Me.passmatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label1.Location = New System.Drawing.Point(235, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register "
        '
        'userbox
        '
        Me.userbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.userbox.Location = New System.Drawing.Point(227, 101)
        Me.userbox.Name = "userbox"
        Me.userbox.Size = New System.Drawing.Size(100, 20)
        Me.userbox.TabIndex = 1
        '
        'passbox
        '
        Me.passbox.Location = New System.Drawing.Point(227, 140)
        Me.passbox.Name = "passbox"
        Me.passbox.Size = New System.Drawing.Size(100, 20)
        Me.passbox.TabIndex = 2
        '
        'repassbox
        '
        Me.repassbox.Location = New System.Drawing.Point(227, 188)
        Me.repassbox.Name = "repassbox"
        Me.repassbox.Size = New System.Drawing.Size(100, 20)
        Me.repassbox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label2.Location = New System.Drawing.Point(111, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Userid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label3.Location = New System.Drawing.Point(111, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 26)
        Me.Label3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label4.Location = New System.Drawing.Point(30, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "re-enter password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label5.Location = New System.Drawing.Point(111, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "password"
        '
        'regbtn
        '
        Me.regbtn.Location = New System.Drawing.Point(227, 243)
        Me.regbtn.Name = "regbtn"
        Me.regbtn.Size = New System.Drawing.Size(110, 25)
        Me.regbtn.TabIndex = 8
        Me.regbtn.Text = "Register Now"
        Me.regbtn.UseVisualStyleBackColor = True
        '
        'passmatch
        '
        Me.passmatch.AutoSize = True
        Me.passmatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.passmatch.Location = New System.Drawing.Point(342, 188)
        Me.passmatch.Name = "passmatch"
        Me.passmatch.Size = New System.Drawing.Size(0, 26)
        Me.passmatch.TabIndex = 9
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.passmatch)
        Me.Controls.Add(Me.regbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.repassbox)
        Me.Controls.Add(Me.passbox)
        Me.Controls.Add(Me.userbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "signup"
        Me.Text = "signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents userbox As TextBox
    Friend WithEvents passbox As TextBox
    Friend WithEvents repassbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents regbtn As Button
    Friend WithEvents passmatch As Label
End Class
