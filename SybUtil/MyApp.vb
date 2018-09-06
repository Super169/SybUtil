Imports Sybase.Data.AseClient

Public Class MyApp
    Public Enum ePL
        profile = 0
        env = 1
        server = 2
        host = 3
        port = 4
        db = 5
        login = 6
        password = 7
        charset = 8
    End Enum

    Public Const APP_NAME As String = "SybUtil2"
    Public Const PROFILE_SIZE As Integer = 9
    Public Shared profileList()() As String
    Public Shared profileCnt As Integer
    Public Shared envList As New List(Of String)

    Public Shared Function AppName() As String
        Return APP_NAME & " (v" & My.Application.Info.Version.ToString() & ")"
    End Function

    Public Shared Sub Init()
        ReadProfileList()
    End Sub

    Public Shared Sub ReadProfileList()
        Dim profileItem() As String
        Dim idx, sidx As Integer
        profileCnt = My.Settings.ProfileList.Count
        If (profileCnt > 0) Then
            ReDim profileList(profileCnt - 1)
            For idx = 0 To profileCnt - 1
                profileItem = My.Settings.ProfileList.Item(idx).Split(",")
                If (profileItem.Length < PROFILE_SIZE) Then
                    ReDim Preserve profileItem(PROFILE_SIZE - 1)
                End If
                profileList(idx) = profileItem
                For sidx = 0 To profileList(idx).Length - 1
                    If (IsNothing(profileList(idx)(sidx))) Then
                        profileList(idx)(sidx) = ""
                    Else
                        profileList(idx)(sidx) = profileList(idx)(sidx).Trim
                    End If
                Next
            Next
        End If
        UpdateEnvList()
    End Sub

    Public Shared Sub AddProfile()
        UpdateEnvList()
    End Sub

    Public Shared Sub RemoveProfile(ByVal idx As Integer)
        If (idx < profileCnt) Then
            If (idx < profileCnt - 1) Then System.Array.Copy(profileList, idx + 1, profileList, idx, profileCnt - idx - 1)
            profileCnt -= 1
            ReDim Preserve profileList(profileCnt - 1)
        End If
        UpdateEnvList()
    End Sub
    Public Shared Sub UpdateProfileList()
        Dim profileStr As String
        Dim idx, sidx As Integer
        My.Settings.ProfileList.Clear()
        For idx = 0 To profileCnt - 1
            profileStr = profileList(idx)(0)
            For sidx = 1 To profileList(idx).Length - 1
                profileStr &= "," & profileList(idx)(sidx)
            Next
            If (profileList(idx).Length < PROFILE_SIZE) Then
                profileStr &= Left(",,,,,,,,", PROFILE_SIZE - profileList(idx).Length)
            End If
            My.Settings.ProfileList.Add(profileStr)
        Next
    End Sub

    Public Shared Sub UpdateEnvList()
        Dim idx As Integer
        envList.Clear()
        For idx = 0 To profileCnt - 1
            If Not envList.Contains(profileList(idx)(ePL.env)) Then
                envList.Add(profileList(idx)(ePL.env))
            End If
        Next
    End Sub

    Public Shared Function CheckAseConnection(ByVal host As String, ByVal port As String, ByVal db As String, ByVal login As String, ByVal password As String, ByVal charset As String) As String
        Dim connErr As String = ""
        Dim connStr As String
        connStr = GetAseConnectionString(host, port, db, login, password, charset, False)

        Dim conn As New AseConnection(connStr)

        Try
            conn.Open()

        Catch ex As Exception

            connErr = ex.Message

        Finally
            If Not (conn Is Nothing) AndAlso (conn.State <> ConnectionState.Closed) Then
                conn.Close()
            End If
        End Try

        Return connErr
    End Function

    Public Shared Function GetAseConnectionString(ByVal host As String, ByVal port As String, ByVal db As String, ByVal login As String, ByVal password As String, ByVal charset As String, Optional ByVal usePool As Boolean = False) As String
        Dim connStr As String
        connStr = "Data Source='" & host.Trim & "';Port=" & port.Trim & _
                  ";UID='" & login.Trim & "';PWD='" & password.Trim & _
                  "';Database='" & db.Trim & "';"

        If (charset.Trim > "") Then connStr &= "CharSet='" & charset.Trim & "';"
        If usePool Then connStr &= "Max Pool Size=50; Min Pool Size=5;"
        Return connStr
    End Function

End Class
