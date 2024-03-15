Imports System.Configuration
Imports System.Data.OleDb
Imports globals
Public Class result
    Dim con As OleDbConnection
    Dim ds As DataSet
    Private Sub result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As String = ConfigurationManager.ConnectionStrings("con_str").ConnectionString
        con = New OleDbConnection(conn)
        fillres()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub fillres()
        Try
            con.Open()
            Dim query As String = "SELECT s.spid, s.name, r.score AS Marks, r.testn AS TestNumber, r.examdate AS EXAMDATE,t.testname FROM result_u r, student_u s,test_u t WHERE r.userid = s.user_id AND r.testn=t.testn and userid = ? "
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", CInt(userin))

            ds = New DataSet
            Dim adp As New OleDbDataAdapter(cmd)
            adp.Fill(ds, "result")

            DataGridView1.DataSource = ds.Tables("result")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        dashboard.Show()
    End Sub
End Class