Imports System.Configuration
Imports System.Data.OleDb

Public Class dashboard
    Dim con As OleDbConnection
    Dim testflag As Integer
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As String = ConfigurationManager.ConnectionStrings("con_str").ConnectionString
        con = New OleDbConnection(connection)
        filllbl()
        displaytestd()
        attbtn.Enabled = False
    End Sub

    Private Sub displaytestd()

        Try
            con.Open()
            Dim query As String = "select * from test_u where testflag = 1"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            If reader.Read() Then
                testnamelbl.Text = reader("testname").ToString
                testnlbl.Text = reader("testn").ToString
                Dim testtime As DateTime = Convert.ToDateTime(reader("testime"))
                MsgBox(testtime.ToString)
                timelbl.Text = reader("testtime").ToString

                testflag = Convert.ToInt32(reader("testflag"))
                If testflag = 1 Then
                    attbtn.Enabled = True
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub filllbl()
        Try
            con.Open()
            Dim userid As String = userin
            Dim query As String = "select * from student_u where user_id=?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", CInt(userin))

            Dim reader As OleDbDataReader = cmd.ExecuteReader
            If reader.Read() Then
                spidlbl.Text = reader("spid").ToString
                rollnolbl.Text = reader("rollno").ToString
                useridlbl.Text = reader("user_id").ToString
                namelbl.Text = reader("name").ToString
                courselbl.Text = reader("course_id").ToString

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class