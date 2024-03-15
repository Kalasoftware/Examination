Imports System.Configuration
Imports System.Data.OleDb
Imports globals
Public Class signup

    Dim con As OleDbConnection
    Dim ds As DataSet
    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String = ConfigurationManager.ConnectionStrings("con_str").ConnectionString
        con = New OleDbConnection(constring)

        regbtn.Enabled = False
        fillcourse()
    End Sub

    Private Sub fillcourse()
        ds = New DataSet
        Dim adp As New OleDbDataAdapter("select * from course_u", con)
        adp.Fill(ds, "course_u")
        coursebox.DataSource = ds.Tables("course_u")
        coursebox.ValueMember = "course_id"
        coursebox.DisplayMember = "c_name"

    End Sub

    Private Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        Dim userid As String
        Dim passin As String
        Dim repassin As String
        userid = userbox.Text
        passin = passbox.Text
        repassin = repassbox.Text


        Dim insqry As New String("insert into euser values(?,?)")

        Dim stu As New String("insert into student_u values(?,?,?,?,?)")

        Try
            con.Open()
            Dim cmd As New OleDbCommand(insqry, con)
            cmd.Parameters.AddWithValue("?", userid)
            cmd.Parameters.AddWithValue("?", passin)

            Dim effectrow = cmd.ExecuteNonQuery()

            Dim cmds As New OleDbCommand(stu, con)
            cmds.Parameters.AddWithValue("?", CInt(spidbox.Text))
            spid = CInt(spidbox.Text)
            cmds.Parameters.AddWithValue("?", CInt(rollnobox.Text))
            cmds.Parameters.AddWithValue("?", userid)
            cmds.Parameters.AddWithValue("?", namebox.Text)
            cmds.Parameters.AddWithValue("?", coursebox.SelectedValue)
            Dim sturow = cmds.ExecuteNonQuery()





            If (effectrow >= 1 And sturow >= 1) Then
                MsgBox("Hurrah! Succesfully registered , Login Now")
                userin = userid
                con.Close()
                Form1.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("userid has been already taken")
            MsgBox(ex.Message)
            con.Close()
        End Try


    End Sub

    Private Sub repassbox_TextChanged(sender As Object, e As EventArgs) Handles repassbox.TextChanged, spidbox.TextChanged, namebox.TextChanged, rollnobox.TextChanged
        Dim passin = passbox.Text
        Dim repassin = repassbox.Text
        ' showing the error 
        If passin <> repassin Then
            passmatch.Text = "Password Not Matched"
            passmatch.Visible = True

        Else
            passmatch.Text = "Password Matched"
            passmatch.Visible = True
            If (spidbox.Text IsNot "" And rollnobox.Text IsNot "" And namebox.Text IsNot "") Then
                regbtn.Enabled = True

            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class