Imports System.Data.OleDb
Imports Sybase.Data.AseClient


Public Class frmSQLExecute
    Inherits frmBase
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PanTop As System.Windows.Forms.Panel
    Friend WithEvents SpForm As System.Windows.Forms.Splitter
    Friend WithEvents tcResult As System.Windows.Forms.TabControl
    Friend WithEvents TPOutput As System.Windows.Forms.TabPage
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents PabBottom As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents fcTxtSQL As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents btnSaveExcel As System.Windows.Forms.Button
    Friend WithEvents btnSavePage As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbxOpenExcel As System.Windows.Forms.CheckBox
    Friend WithEvents cbxShowDatagrid As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSQLExecute))
        Me.PanTop = New System.Windows.Forms.Panel()
        Me.fcTxtSQL = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.cbxShowDatagrid = New System.Windows.Forms.CheckBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.SpForm = New System.Windows.Forms.Splitter()
        Me.tcResult = New System.Windows.Forms.TabControl()
        Me.TPOutput = New System.Windows.Forms.TabPage()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.PabBottom = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbxOpenExcel = New System.Windows.Forms.CheckBox()
        Me.btnSavePage = New System.Windows.Forms.Button()
        Me.btnSaveExcel = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.PanTop.SuspendLayout()
        CType(Me.fcTxtSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcResult.SuspendLayout()
        Me.TPOutput.SuspendLayout()
        Me.PabBottom.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanTop
        '
        Me.PanTop.Controls.Add(Me.fcTxtSQL)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 0)
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(1064, 319)
        Me.PanTop.TabIndex = 0
        '
        'fcTxtSQL
        '
        Me.fcTxtSQL.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.fcTxtSQL.BackBrush = Nothing
        Me.fcTxtSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fcTxtSQL.CharHeight = 14
        Me.fcTxtSQL.CharWidth = 8
        Me.fcTxtSQL.CommentPrefix = "--"
        Me.fcTxtSQL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fcTxtSQL.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.fcTxtSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fcTxtSQL.IsReplaceMode = False
        Me.fcTxtSQL.Language = FastColoredTextBoxNS.Language.SQL
        Me.fcTxtSQL.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.fcTxtSQL.Location = New System.Drawing.Point(0, 0)
        Me.fcTxtSQL.Name = "fcTxtSQL"
        Me.fcTxtSQL.Paddings = New System.Windows.Forms.Padding(0)
        Me.fcTxtSQL.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.fcTxtSQL.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fcTxtSQL.Size = New System.Drawing.Size(1064, 319)
        Me.fcTxtSQL.TabIndex = 1
        Me.fcTxtSQL.Zoom = 100
        '
        'cbxShowDatagrid
        '
        Me.cbxShowDatagrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxShowDatagrid.ForeColor = System.Drawing.Color.Navy
        Me.cbxShowDatagrid.Location = New System.Drawing.Point(3, 6)
        Me.cbxShowDatagrid.Name = "cbxShowDatagrid"
        Me.cbxShowDatagrid.Size = New System.Drawing.Size(200, 18)
        Me.cbxShowDatagrid.TabIndex = 12
        Me.cbxShowDatagrid.Text = "Show Result in &DataGrid"
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExecute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecute.Location = New System.Drawing.Point(200, 1)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(118, 28)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.Text = "&Execute"
        '
        'SpForm
        '
        Me.SpForm.BackColor = System.Drawing.Color.Silver
        Me.SpForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.SpForm.Location = New System.Drawing.Point(0, 319)
        Me.SpForm.Name = "SpForm"
        Me.SpForm.Size = New System.Drawing.Size(1064, 5)
        Me.SpForm.TabIndex = 1
        Me.SpForm.TabStop = False
        '
        'tcResult
        '
        Me.tcResult.Controls.Add(Me.TPOutput)
        Me.tcResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcResult.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcResult.Location = New System.Drawing.Point(0, 31)
        Me.tcResult.Name = "tcResult"
        Me.tcResult.SelectedIndex = 0
        Me.tcResult.Size = New System.Drawing.Size(1064, 267)
        Me.tcResult.TabIndex = 11
        Me.tcResult.Tag = ""
        '
        'TPOutput
        '
        Me.TPOutput.Controls.Add(Me.txtResult)
        Me.TPOutput.Location = New System.Drawing.Point(4, 25)
        Me.TPOutput.Name = "TPOutput"
        Me.TPOutput.Size = New System.Drawing.Size(1056, 238)
        Me.TPOutput.TabIndex = 0
        Me.TPOutput.Text = "Output"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResult.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.ForeColor = System.Drawing.Color.Navy
        Me.txtResult.Location = New System.Drawing.Point(0, 0)
        Me.txtResult.MaxLength = 0
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResult.Size = New System.Drawing.Size(1056, 238)
        Me.txtResult.TabIndex = 0
        Me.txtResult.WordWrap = False
        '
        'PabBottom
        '
        Me.PabBottom.Controls.Add(Me.tcResult)
        Me.PabBottom.Controls.Add(Me.Panel2)
        Me.PabBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PabBottom.Location = New System.Drawing.Point(0, 324)
        Me.PabBottom.Name = "PabBottom"
        Me.PabBottom.Size = New System.Drawing.Size(1064, 298)
        Me.PabBottom.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbxOpenExcel)
        Me.Panel2.Controls.Add(Me.btnSavePage)
        Me.Panel2.Controls.Add(Me.btnSaveExcel)
        Me.Panel2.Controls.Add(Me.btnExecute)
        Me.Panel2.Controls.Add(Me.cbxShowDatagrid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1064, 31)
        Me.Panel2.TabIndex = 0
        '
        'cbxOpenExcel
        '
        Me.cbxOpenExcel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cbxOpenExcel.AutoSize = True
        Me.cbxOpenExcel.Checked = True
        Me.cbxOpenExcel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxOpenExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOpenExcel.Location = New System.Drawing.Point(637, 7)
        Me.cbxOpenExcel.Name = "cbxOpenExcel"
        Me.cbxOpenExcel.Size = New System.Drawing.Size(179, 20)
        Me.cbxOpenExcel.TabIndex = 15
        Me.cbxOpenExcel.Text = "Open Excel after save"
        Me.cbxOpenExcel.UseVisualStyleBackColor = True
        '
        'btnSavePage
        '
        Me.btnSavePage.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSavePage.Enabled = False
        Me.btnSavePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePage.Location = New System.Drawing.Point(822, 2)
        Me.btnSavePage.Name = "btnSavePage"
        Me.btnSavePage.Size = New System.Drawing.Size(118, 27)
        Me.btnSavePage.TabIndex = 14
        Me.btnSavePage.Text = "Save This &Page"
        Me.btnSavePage.UseVisualStyleBackColor = True
        '
        'btnSaveExcel
        '
        Me.btnSaveExcel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSaveExcel.Enabled = False
        Me.btnSaveExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveExcel.Location = New System.Drawing.Point(943, 2)
        Me.btnSaveExcel.Name = "btnSaveExcel"
        Me.btnSaveExcel.Size = New System.Drawing.Size(118, 27)
        Me.btnSaveExcel.TabIndex = 13
        Me.btnSaveExcel.Text = "&Save All Results"
        Me.btnSaveExcel.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'frmSQLExecute
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1064, 622)
        Me.Controls.Add(Me.PabBottom)
        Me.Controls.Add(Me.SpForm)
        Me.Controls.Add(Me.PanTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSQLExecute"
        Me.Text = "Interactive SQL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanTop.ResumeLayout(False)
        CType(Me.fcTxtSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcResult.ResumeLayout(False)
        Me.TPOutput.ResumeLayout(False)
        Me.TPOutput.PerformLayout()
        Me.PabBottom.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _TPCount As Int16 = 0
    Dim _TPage() As Windows.Forms.TabPage
    Dim _dgOutput() As Windows.Forms.DataGrid
    Dim _dtResult() As System.Data.DataTable


    Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click

        Dim sSQL As String
        Dim dsSQL As DataSet

        Parent.Cursor = Cursors.WaitCursor
        Try
            txtResult.Text = Now().ToString & ": " & oServer.ExecuteToString("SELECT @@version") & Chr(13) & Chr(10) & Chr(13) & Chr(10)

            Do While RemoveTPage()
            Loop

            If _dtResult IsNot Nothing Then
                Dim obj As System.Data.DataTable
                For Each obj In _dtResult
                    obj.Clear()
                    obj.Dispose()
                    obj = Nothing
                Next
                _dtResult = Nothing
            End If

            btnSaveExcel.Enabled = False
            btnSavePage.Enabled = False

            If (fcTxtSQL.SelectedText > "") Then
                sSQL = fcTxtSQL.SelectedText
            Else
                sSQL = fcTxtSQL.Text
            End If


            If sSQL > "" Then

                Dim tempSQL As String = sSQL
                Dim execSQL As String
                Do While tempSQL > ""
                    execSQL = getSQL(tempSQL)

                    dsSQL = New DataSet

                    If oServer.ExecuteToDataset(execSQL, dsSQL) Then

                        Dim i, j, k, Idx As Integer
                        Dim strL1, strL2, strL3 As String
                        Dim sOutput As String

                        For i = 1 To dsSQL.Tables.Count
                            sOutput = ""
                            strL1 = ""
                            strL2 = ""
                            strL3 = ""

                            For k = 1 To dsSQL.Tables(i - 1).Columns.Count

                                strL1 &= dsSQL.Tables(i - 1).Columns(k - 1).ColumnName + vbTab
                                strL2 &= Replace(Space(Len(dsSQL.Tables(i - 1).Columns(k - 1).ColumnName)), " ", "-") + vbTab

                                '                            strL3 &= dsSQL.Tables(i - 1).Columns(k - 1).DataType.ToString + vbTab


                            Next
                            sOutput = strL1 & Chr(13) & Chr(10) & strL2 & Chr(13) & Chr(10)

                            '                        sOutput &= strL3 & Chr(13) & Chr(10)

                            For j = 1 To dsSQL.Tables(i - 1).Rows.Count
                                strL1 = ""
                                For k = 1 To dsSQL.Tables(i - 1).Columns.Count
                                    strL1 &= dsSQL.Tables(i - 1).Rows(j - 1).Item(k - 1).ToString() & vbTab
                                Next
                                sOutput &= strL1 & Chr(13) & Chr(10)
                            Next

                            txtResult.Text &= sOutput & Chr(13) & Chr(10) & Chr(13) & Chr(10)

                            If cbxShowDatagrid.Checked Then
                                Idx = AddTPage()
                                Me.SetDefaultDataGridDisplay(_dgOutput(Idx), dsSQL, i - 1)
                            End If

                            SaveDT(dsSQL, i - 1)

                        Next

                    End If


                Loop
                btnSaveExcel.Enabled = (_dtResult IsNot Nothing)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Parent.Cursor = Cursors.Arrow

    End Sub

    Private Function AddTPage() As Int16
        Dim Idx As Int16
        Idx = _TPCount
        _TPCount += 1
        ReDim Preserve _TPage(_TPCount)
        ReDim Preserve _dgOutput(_TPCount)
        _TPage(Idx) = New TabPage
        tcResult.Controls.Add(_TPage(Idx))
        _TPage(Idx).Location = New System.Drawing.Point(2, 21)
        _TPage(Idx).Name = "TP2"
        _TPage(Idx).TabIndex = 0
        _TPage(Idx).Text = "Result - " & CType(_TPCount, String)
        _dgOutput(Idx) = New DataGrid
        _TPage(Idx).Controls.Add(_dgOutput(Idx))
        _dgOutput(Idx).ReadOnly = True
        _dgOutput(Idx).CaptionVisible = False
        _dgOutput(Idx).CausesValidation = False
        _dgOutput(Idx).Dock = DockStyle.Fill
        _dgOutput(Idx).Location = New System.Drawing.Point(0, 0)
        Return Idx
    End Function

    Private Function RemoveTPage() As Boolean
        Dim Idx As Int16
        If _TPCount < 1 Then Return False
        Idx = _TPCount - 1
        _TPage(Idx).Controls.Remove(_dgOutput(Idx))
        _dgOutput(Idx).Dispose()
        _tcResult.Controls.Remove(_TPage(Idx))
        _TPage(Idx).Dispose()
        _TPCount -= 1
        ReDim Preserve _TPage(_TPCount)
        Return True
    End Function


    Private Sub frmSQLExecute_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        oApplication.CloseWindow("SQLExecute")
    End Sub


    Private Sub SetDefaultDataGridDisplay(ByRef dgDisplay As DataGrid, ByVal dsData As DataSet, ByVal iTableIdx As Int16)
        Dim k As Int16
        Dim dgTS As DataGridTableStyle
        Dim dgTBC As DataGridTextBoxColumn

        dgDisplay.SuspendLayout()
        dgDisplay.DataSource = dsData.Tables(iTableIdx)
        dgDisplay.Refresh()
        dgDisplay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


        dgDisplay.ReadOnly = True

        dgTS = New DataGridTableStyle
        dgTS.MappingName = dsData.Tables(iTableIdx).TableName
        dgTS.AlternatingBackColor = System.Drawing.Color.Lavender
        dgTS.BackColor = System.Drawing.Color.WhiteSmoke
        dgTS.ForeColor = System.Drawing.Color.MidnightBlue
        dgTS.GridLineColor = System.Drawing.Color.Gainsboro
        dgTS.HeaderBackColor = System.Drawing.Color.MidnightBlue
        dgTS.HeaderForeColor = System.Drawing.Color.WhiteSmoke

        For k = 1 To dsData.Tables(iTableIdx).Columns.Count
            dgTBC = New DataGridTextBoxColumn
            dgTBC.MappingName = dsData.Tables(iTableIdx).Columns(k - 1).ColumnName
            dgTBC.HeaderText = dsData.Tables(iTableIdx).Columns(k - 1).ColumnName
            Select Case dsData.Tables(iTableIdx).Columns(k - 1).DataType.ToString.ToLower
                Case "system.datetime"
                    dgTBC.Format = "yyyy-MM-dd hh:mm:ss"
                    dgTBC.Width = 140
                    dgTBC.Alignment = HorizontalAlignment.Right
                Case "system.int", "system.int16", "system.int32", "system.int64"
                    dgTBC.Width = 50
                    dgTBC.Alignment = HorizontalAlignment.Right
                Case "system.char"
                    dgTBC.Width = 50
                    dgTBC.Alignment = HorizontalAlignment.Left
                Case Else
                    dgTBC.Width = 100
                    dgTBC.Alignment = HorizontalAlignment.Left
            End Select

            dgTS.GridColumnStyles.Add(dgTBC)
        Next

        dgDisplay.TableStyles.Clear()
        dgDisplay.TableStyles.Add(dgTS)

        dgDisplay.ResumeLayout()

    End Sub

    Private Sub SaveDT(ByRef dsData As System.Data.DataSet, ByVal iTableIdx As Integer)
        If _dtResult Is Nothing Then
            ReDim _dtResult(0)
        Else
            ReDim Preserve _dtResult(_dtResult.Length)
        End If
        _dtResult(_dtResult.Length - 1) = dsData.Tables(iTableIdx)
    End Sub

    Private Function getSQL(ByRef sSQL As String) As String
        Dim sReturn As String = ""
        Dim sTemp As String = ""
        Dim nPos As Integer
        If sSQL = "" Then Return ""
        Do While True
            nPos = sSQL.IndexOf(vbCrLf)
            If nPos < 0 Then
                If (sSQL.Trim.ToLower <> "go") Then
                    sReturn = sReturn + sSQL
                End If
                sSQL = ""
                Exit Do
            End If
            If (nPos > 0) Then
                sTemp = Mid(sSQL, 1, nPos)
                sSQL = Mid(sSQL, nPos + 2)
                If sTemp.Trim.ToLower = "go" Then
                    Exit Do
                Else
                    sReturn = sReturn & sTemp & vbCrLf
                End If
            Else
                sReturn = sReturn & vbCrLf
                sSQL = Mid(sSQL, 2)
            End If
        Loop
        Return sReturn
    End Function

    Private Sub btnSaveExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveExcel.Click
        saveExcel(False)
    End Sub

    Private Sub tcResult_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tcResult.SelectedIndexChanged
        btnSavePage.Enabled = (tcResult.SelectedIndex > 0)
    End Sub

    Private Sub btnSavePage_Click(sender As System.Object, e As System.EventArgs) Handles btnSavePage.Click
        saveExcel(True)
    End Sub


    Private Sub saveExcel(ByVal singlePage As Boolean)

        If (singlePage And (tcResult.SelectedIndex < 1)) Then Return

        Dim fname As String = getExcelName()
        If (fname = "") Then Return

        Dim iStart, iEnd As Integer
        If singlePage Then
            iStart = tcResult.SelectedIndex - 1
            iEnd = tcResult.SelectedIndex - 1
        Else
            iStart = 0
            iEnd = _dtResult.Length - 1
        End If

        ' reference: http://www.codeproject.com/Articles/19840/Export-to-Excel-using-VB-Net

        Dim excel As New Microsoft.Office.Interop.Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        If wBook.Sheets.Count > 1 Then
            While wBook.Sheets.Count > 1
                excel.Worksheets(1).delete()
            End While
        End If
        wSheet = wBook.ActiveSheet()

        Dim idx As Integer
        Dim firstSheet As Boolean = True
        For idx = iStart To iEnd

            If firstSheet Then
                firstSheet = False
            Else
                wSheet = wBook.Sheets.Add(, wSheet)
            End If

            wSheet.Name = "Result - " & (idx + 1)

            Dim dt As System.Data.DataTable = _dtResult(idx)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow

            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0


            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    Try
                        excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Catch ex As Exception
                        excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName).ToString
                    End Try

                Next
            Next

            wSheet.Columns.AutoFit()

        Next

        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(fname)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(fname) Then
            System.IO.File.Delete(fname)
        End If

        wBook.SaveAs(fname)

        If cbxOpenExcel.Checked Then
            excel.Workbooks.Open(fname)
            excel.Visible = True
        End If

    End Sub


    Public Function getExcelName() As String
        sfd.Filter = "*.xlsx | Excel Workbook"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return sfd.FileName
        End If
        Return ""
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxOpenExcel.CheckedChanged

    End Sub
End Class
