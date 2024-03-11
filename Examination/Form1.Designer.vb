<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.useridbox = New System.Windows.Forms.TextBox()
        Me.passbox = New System.Windows.Forms.TextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'useridbox
        '
        Me.useridbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.useridbox.Location = New System.Drawing.Point(201, 86)
        Me.useridbox.Name = "useridbox"
        Me.useridbox.Size = New System.Drawing.Size(131, 32)
        Me.useridbox.TabIndex = 0
        '
        'passbox
        '
        Me.passbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.passbox.Location = New System.Drawing.Point(201, 136)
        Me.passbox.Name = "passbox"
        Me.passbox.Size = New System.Drawing.Size(131, 32)
        Me.passbox.TabIndex = 1
        '
        'loginbtn
        '
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.loginbtn.Location = New System.Drawing.Point(201, 184)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(131, 47)
        Me.loginbtn.TabIndex = 2
        Me.loginbtn.Text = "login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.LinkLabel1.Location = New System.Drawing.Point(150, 234)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(232, 31)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "New user Sign Up"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label1.Location = New System.Drawing.Point(104, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User id "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label2.Location = New System.Drawing.Point(104, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.passbox)
        Me.Controls.Add(Me.useridbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents useridbox As TextBox
    Friend WithEvents passbox As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
