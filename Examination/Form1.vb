Imports System.Configuration
Imports System.Data.OleDb

Public Class Form1
    Dim con As OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cons As String = ConfigurationManager.ConnectionStrings("con_str").ConnectionString
        con = New OleDbConnection(cons)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim userid = useridbox.Text
        Dim pass = passbox.Text
        Try
            Dim qry As New String("select count(*) from euser where userid=? and password=?")
            Dim cmd As New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("?", userid)
            cmd.Parameters.AddWithValue("?", pass)
            con.Open()
            Dim countres = Convert.ToInt32(cmd.ExecuteScalar())
            If (countres > 0) Then
                MsgBox("succes")
                con.Close()
                dashboard.Show()
                Me.Hide()


            Else
                MsgBox("wrong credentials")
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        signup.Show()
        Me.Hide()
    End Sub
End Class
