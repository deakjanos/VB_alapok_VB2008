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
        Me.szm = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_szm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'szm
        '
        Me.szm.Location = New System.Drawing.Point(36, 60)
        Me.szm.Name = "szm"
        Me.szm.Size = New System.Drawing.Size(173, 20)
        Me.szm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Írj ide igen-t vagy nem-et!"
        '
        'cmd_szm
        '
        Me.cmd_szm.Location = New System.Drawing.Point(36, 105)
        Me.cmd_szm.Name = "cmd_szm"
        Me.cmd_szm.Size = New System.Drawing.Size(173, 23)
        Me.cmd_szm.TabIndex = 2
        Me.cmd_szm.Text = "OK"
        Me.cmd_szm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.cmd_szm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.szm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents szm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_szm As System.Windows.Forms.Button

End Class
