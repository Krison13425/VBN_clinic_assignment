Imports System.Data.SqlClient
Public Class SQLControl

    Private DBCon As New SqlConnection("Server=DESKTOP-645HG9U;Database=Clinic;Trusted_Connection=True")
    Private DBCmd As SqlCommand

    'DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    'QUERY PAREMEETERS
    Public Params As New List(Of SqlParameter)

    'QUEREY STATISTIC
    Public Recordcount As Integer
    Public Exception As String

    Public Sub New()
    End Sub

    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    'EXECUTE QUREY SUB
    Public Sub ExecQurey(Qurey As String, Optional ReturnIdentity As Boolean = False)
        'Reset QUERY STATS
        Recordcount = 0
        Exception = ""

        Try
            DBCon.Open()

            'Create DB COMMAND
            DBCmd = New SqlCommand(Qurey, DBCon)

            'LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'CLEAR PARAM LIST
            Params.Clear()

            'EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            Recordcount = DBDA.Fill(DBDT)

            If ReturnIdentity = True Then
                Dim ReturnQurey As String = "SELECT @@IDENTITY As LastID;"
                DBCmd = New SqlCommand(ReturnQurey, DBCon)
                DBDT = New DataTable
                DBDA = New SqlDataAdapter(DBCmd)
                Recordcount = DBDA.Fill(DBDT)


            End If
        Catch ex As Exception
            'CAPTURE ERROR 
            Exception = "ExecQurey Error:" & vbNewLine & ex.Message
        Finally
            'CLOSE CONNECTION'
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try

    End Sub

    'ADD PARAMS 
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    'ERROR CHECKING 
    Public Function HasExecption(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Execption:")
        Return True
    End Function
End Class

