Imports System.Configuration
Imports System.Data.OleDb

Public Class signup
    Dim con As OleDbConnection
    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String = ConfigurationManager.ConnectionStrings("con_str").ConnectionString
        con = New OleDbConnection(constring)


    End Sub

    Private Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        Dim userin = userbox.Text
        Dim passin = passbox.Text
        Dim repassin = repassbox.Text

        Dim insqry As New String("insert into euser values(?,?)")

        Try
            Dim cmd As New OleDbCommand(insqry, con)
            cmd.Parameters.AddWithValue("?", userin)
            cmd.Parameters.AddWithValue("?", passin)
            con.Open()
            Dim effectrow = cmd.ExecuteNonQuery
            If (effectrow >= 1) Then
                MsgBox("Hurrah! Succesfully registered , Login Now")
                con.Close()
                Form1.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("userid has been already taken")
            con.Close()
        End Try


    End Sub

    Private Sub repassbox_TextChanged(sender As Object, e As EventArgs) Handles repassbox.TextChanged
        Dim passin = passbox.Text
        Dim repassin = repassbox.Text
        ' showing the error 
        If passin <> repassin Then
            passmatch.Text = "Password Not Matched"
            passmatch.Visible = True
            regbtn.Enabled = False
        Else
            passmatch.Text = "Password Matched"
            passmatch.Visible = True
            regbtn.Enabled = True
        End If
    End Sub
End Class