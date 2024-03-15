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

    End Sub

    Private Sub fillres()
        Try
            con.Open()
            Dim query As String = "SELECT s.spid, s.name, r.score AS Marks, r.testn AS TestNumber, r.examdate AS EXAMDATE FROM result_u r, student_u s WHERE r.userid = s.user_id AND userid = ?"
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
End Class