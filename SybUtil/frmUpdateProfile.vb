Public Class frmUpdateProfile

    Private Sub frmUpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim profileStr As String = ""
        Dim idx As Integer
        For idx = 0 To My.Settings.ProfileList.Count - 1
            profileStr &= My.Settings.ProfileList.Item(idx) & vbCrLf
        Next
        fctbProfile.Text = profileStr
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnCheckProfile_Click(sender As Object, e As EventArgs) Handles btnCheckProfile.Click

    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        btnCheckProfile.Text = "Stop"
        btnSave.Enabled = False
        btnCancel.Enabled = False
        Dim profileCnt As Integer = fctbProfile.LinesCount

    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        btnCheckProfile.Text = "Check Profile"
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim profileStr As String
        Dim idx As Integer
        My.Settings.ProfileList.Clear()
        For idx = 0 To fctbProfile.LinesCount - 1
            profileStr = fctbProfile.Lines(idx).Trim
            If (profileStr <> "") Then
                My.Settings.ProfileList.Add(profileStr)
            End If
        Next
        My.Settings.Save()
        MyApp.ReadProfileList()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class