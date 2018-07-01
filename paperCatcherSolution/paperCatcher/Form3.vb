Imports System.Data.OleDb

Public Class Form3
    Dim Access2010string As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ..\..\Resources\HighScoresNET.accdb"
    Dim dbConnection As New OleDbConnection(Access2010string)
    Dim dbAdapter As New OleDbDataAdapter
    Dim HighScoresDS As New DataSet

    'Show plaer score and highscores
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFinalScore.Text = Score
        LoadData()
    End Sub

    'Show highscores
    Sub LoadData()

        HighScoresDS.Clear()
        Dim SQLquery As String = "SELECT PlayerName, Date, Score FROM tblHighScores ORDER BY Score DESC"
        dbAdapter = New OleDbDataAdapter(SQLquery, Access2010string)

        'Dim dbCMdBuild As New OleDbCommandBuilder(dbAdapter)
        dbAdapter.FillSchema(HighScoresDS, SchemaType.Source, "tblHighScores")
        dbAdapter.Fill(HighScoresDS, "tblHighScores")
        dgvDisplay.DataSource = HighScoresDS
        dgvDisplay.DataMember = "tblHighScores"

    End Sub

    'Submit plaer score
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim PlayerName As String = txtPlayerName.Text
        Dim HighScore As Integer = Score

        Dim SQLinsert As String = "INSERT INTO tblHighScores( PlayerName, Score) " _
            & "VALUES ('" & PlayerName & "', " & HighScore & ")"

        Dim dbConnection As New OleDbConnection(Access2010string)
        dbConnection.Open()
        Dim dbCommand As New OleDbCommand(SQLinsert, dbConnection)
        dbCommand.ExecuteNonQuery()
        SQLinsert = Nothing
        dbConnection.Close()
        LoadData()
    End Sub

    'Reload highscores
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub

End Class