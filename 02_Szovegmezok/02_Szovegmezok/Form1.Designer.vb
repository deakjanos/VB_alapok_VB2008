<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foablak
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
        Me.felirat = New System.Windows.Forms.Label
        Me.cmd_szm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'szm
        '
        Me.szm.Location = New System.Drawing.Point(119, 12)
        Me.szm.Name = "szm"
        Me.szm.Size = New System.Drawing.Size(161, 20)
        Me.szm.TabIndex = 0
        '
        'felirat
        '
        Me.felirat.AutoSize = True
        Me.felirat.Location = New System.Drawing.Point(12, 9)
        Me.felirat.Name = "felirat"
        Me.felirat.Size = New System.Drawing.Size(101, 13)
        Me.felirat.TabIndex = 1
        Me.felirat.Text = "Írj ide egy szöveget!"
        '
        'cmd_szm
        '
        Me.cmd_szm.Location = New System.Drawing.Point(119, 65)
        Me.cmd_szm.Name = "cmd_szm"
        Me.cmd_szm.Size = New System.Drawing.Size(75, 23)
        Me.cmd_szm.TabIndex = 2
        Me.cmd_szm.Text = "OK"
        Me.cmd_szm.UseVisualStyleBackColor = True
        '
        'foablak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 124)
        Me.Controls.Add(Me.cmd_szm)
        Me.Controls.Add(Me.felirat)
        Me.Controls.Add(Me.szm)
        Me.Name = "foablak"
        Me.Text = "2. rész / Szövegmezők"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents szm As System.Windows.Forms.TextBox
    Friend WithEvents felirat As System.Windows.Forms.Label
    Friend WithEvents cmd_szm As System.Windows.Forms.Button

End Class
