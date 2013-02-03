<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmd_HelloVilag = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmd_HelloVilag
        '
        Me.cmd_HelloVilag.AccessibleDescription = ""
        Me.cmd_HelloVilag.Location = New System.Drawing.Point(154, 155)
        Me.cmd_HelloVilag.Name = "cmd_HelloVilag"
        Me.cmd_HelloVilag.Size = New System.Drawing.Size(75, 23)
        Me.cmd_HelloVilag.TabIndex = 0
        Me.cmd_HelloVilag.Text = "Katt Rám!"
        Me.cmd_HelloVilag.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 266)
        Me.Controls.Add(Me.cmd_HelloVilag)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global._01_HelloVilag.My.MySettings.Default, "foablak", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Name = "Form1"
        Me.Text = Global._01_HelloVilag.My.MySettings.Default.foablak
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_HelloVilag As System.Windows.Forms.Button

End Class
