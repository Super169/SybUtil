<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateProfile))
        Me.fctbProfile = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCheckProfile = New System.Windows.Forms.Button()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.fctbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fctbProfile
        '
        Me.fctbProfile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fctbProfile.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.fctbProfile.AutoScrollMinSize = New System.Drawing.Size(200, 16)
        Me.fctbProfile.BackBrush = Nothing
        Me.fctbProfile.BackColor = System.Drawing.SystemColors.Control
        Me.fctbProfile.CharHeight = 16
        Me.fctbProfile.CharWidth = 9
        Me.fctbProfile.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fctbProfile.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.fctbProfile.Font = New System.Drawing.Font("Courier New", 11.25!)
        Me.fctbProfile.IsReplaceMode = False
        Me.fctbProfile.Location = New System.Drawing.Point(12, 12)
        Me.fctbProfile.Name = "fctbProfile"
        Me.fctbProfile.Paddings = New System.Windows.Forms.Padding(0)
        Me.fctbProfile.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fctbProfile.ServiceColors = CType(resources.GetObject("fctbProfile.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.fctbProfile.Size = New System.Drawing.Size(920, 452)
        Me.fctbProfile.TabIndex = 0
        Me.fctbProfile.Text = "FastColoredTextBox1"
        Me.fctbProfile.Zoom = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 477)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Profile Format:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(148, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(517, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "<name>,<env>,<server>,<host>,<port>,<db>,<login>,<password>,<charset>"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(815, 513)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 37)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(668, 513)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 37)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCheckProfile
        '
        Me.btnCheckProfile.Location = New System.Drawing.Point(514, 513)
        Me.btnCheckProfile.Name = "btnCheckProfile"
        Me.btnCheckProfile.Size = New System.Drawing.Size(117, 37)
        Me.btnCheckProfile.TabIndex = 6
        Me.btnCheckProfile.Text = "Check Profile"
        Me.btnCheckProfile.UseVisualStyleBackColor = True
        Me.btnCheckProfile.Visible = False
        '
        'bgWorker
        '
        '
        'frmUpdateProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(944, 562)
        Me.Controls.Add(Me.btnCheckProfile)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fctbProfile)
        Me.Name = "frmUpdateProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SybUtil2 Profile Update"
        CType(Me.fctbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fctbProfile As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCheckProfile As System.Windows.Forms.Button
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
End Class
