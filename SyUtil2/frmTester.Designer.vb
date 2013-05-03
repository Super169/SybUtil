<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTester
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
        Me.lvData = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lvData
        '
        Me.lvData.Location = New System.Drawing.Point(12, 12)
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(793, 578)
        Me.lvData.TabIndex = 0
        Me.lvData.UseCompatibleStateImageBehavior = False
        '
        'frmTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 643)
        Me.Controls.Add(Me.lvData)
        Me.Name = "frmTester"
        Me.Text = "frmTester"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvData As System.Windows.Forms.ListView
End Class
