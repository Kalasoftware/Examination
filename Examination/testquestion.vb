Imports System.Configuration
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports globals

Public Class testquestion
    Dim conn As OleDbConnection
    Dim questionIndex As Integer = 1
    Dim timerInterval As Integer = 3
    Dim timeshow As Integer = 3 ' time of timer to be shown for attempting the question 
    Dim qcount As Integer = 0
    Dim rid As Integer = 0
    Private Sub testquestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalMarks = 0
        Dim con As String = ConfigurationManager.ConnectionStrings("con_str").ConnectionString
        conn = New OleDbConnection(con)

        ' getting the question loaded 
        Timer1.Interval = timerInterval * 1000
        Timer1.Start()
        shwotimer.Start()
        loadquesion()



    End Sub

    Private Sub loadquesion()
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim query = "SELECT * FROM question_u where qid=?"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", questionIndex)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                queslbl.Text = reader("quetxt").ToString()
                Label1.Text = questionIndex
                ' Populate the options
                Dim options As String() = {reader("op1").ToString(), reader("op2").ToString(), reader("op3").ToString(), reader("op4").ToString()}
                RadioButton1.Text = options(0)
                RadioButton2.Text = options(1)
                RadioButton3.Text = options(2)
                RadioButton4.Text = options(3)
                qcount += 1
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        movetonext()
        calmarks()
        'time to give answer show here 

        If qcount = 10 Then
            MsgBox(DateTime.Today)
            MsgBox(totalMarks)
            Me.Hide()
            submitmarks()
            result.Show()
            Timer1.Stop()
            qcount = 0
        End If
    End Sub

    Private Sub submitmarks()
        'sending the results to the result table '
        Dim insquery As String = "insert into result_u values(?,?,?,?,?,?)"
        Dim cmd As New OleDbCommand(insquery, conn)
        rid = CInt(userin) * 1000
        conn.Open()
        Try
            cmd.Parameters.AddWithValue("?", CInt(rid))
            cmd.Parameters.AddWithValue("?", spid)
            cmd.Parameters.AddWithValue("?", Convert.ToString(DateTime.Today))
            cmd.Parameters.AddWithValue("?", CInt(totalMarks))
            cmd.Parameters.AddWithValue("?", CInt(testnum))
            cmd.Parameters.AddWithValue("?", CInt(userin))
            Dim insrow = cmd.ExecuteNonQuery()
            If (insrow >= 1) Then
                Me.Hide()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub calmarks()
        Try
            ' Open the connection
            conn.Open()

            ' Fetch the correct option number from the database
            Dim query As String = "SELECT copt FROM question_u where qid=?"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", questionIndex)
            Dim correctOption As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Check if any radio button is selected
            If RadioButton1.Checked AndAlso correctOption = 1 Then
                totalMarks += 1
            ElseIf RadioButton2.Checked AndAlso correctOption = 2 Then
                totalMarks += 1
            ElseIf RadioButton3.Checked AndAlso correctOption = 3 Then
                totalMarks += 1
            ElseIf RadioButton4.Checked AndAlso correctOption = 4 Then
                totalMarks += 1
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub movetonext()
        questionIndex += 1


        loadquesion()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub shwotimer_Tick(sender As Object, e As EventArgs) Handles shwotimer.Tick
        timeshow -= 1
        If timeshow = 0 Then
            timeshow = 3
        End If
        timelbl.Text = timeshow

    End Sub
End Class