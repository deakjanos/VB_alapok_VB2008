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
        Me.szm_eszam = New System.Windows.Forms.TextBox
        Me.szm_op = New System.Windows.Forms.TextBox
        Me.szm_mszam = New System.Windows.Forms.TextBox
        Me.cmd_vegrehajt = New System.Windows.Forms.Button
        Me.c_e = New System.Windows.Forms.Label
        Me.cmd_oa = New System.Windows.Forms.Button
        Me.cmd_kiv = New System.Windows.Forms.Button
        Me.cmd_szor = New System.Windows.Forms.Button
        Me.cmd_oszt = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'szm_eszam
        '
        Me.szm_eszam.Location = New System.Drawing.Point(29, 31)
        Me.szm_eszam.Name = "szm_eszam"
        Me.szm_eszam.Size = New System.Drawing.Size(44, 20)
        Me.szm_eszam.TabIndex = 0
        '
        'szm_op
        '
        Me.szm_op.Location = New System.Drawing.Point(126, 31)
        Me.szm_op.Name = "szm_op"
        Me.szm_op.Size = New System.Drawing.Size(39, 20)
        Me.szm_op.TabIndex = 1
        '
        'szm_mszam
        '
        Me.szm_mszam.Location = New System.Drawing.Point(216, 31)
        Me.szm_mszam.Name = "szm_mszam"
        Me.szm_mszam.Size = New System.Drawing.Size(44, 20)
        Me.szm_mszam.TabIndex = 2
        '
        'cmd_vegrehajt
        '
        Me.cmd_vegrehajt.Location = New System.Drawing.Point(185, 239)
        Me.cmd_vegrehajt.Name = "cmd_vegrehajt"
        Me.cmd_vegrehajt.Size = New System.Drawing.Size(75, 23)
        Me.cmd_vegrehajt.TabIndex = 3
        Me.cmd_vegrehajt.Text = "Végrehajt"
        Me.cmd_vegrehajt.UseVisualStyleBackColor = True
        '
        'c_e
        '
        Me.c_e.AutoSize = True
        Me.c_e.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.c_e.Location = New System.Drawing.Point(25, 239)
        Me.c_e.Name = "c_e"
        Me.c_e.Size = New System.Drawing.Size(100, 23)
        Me.c_e.TabIndex = 4
        Me.c_e.Text = "Eredmény"
        '
        'cmd_oa
        '
        Me.cmd_oa.Location = New System.Drawing.Point(126, 69)
        Me.cmd_oa.Name = "cmd_oa"
        Me.cmd_oa.Size = New System.Drawing.Size(44, 23)
        Me.cmd_oa.TabIndex = 5
        Me.cmd_oa.Text = "+"
        Me.cmd_oa.UseVisualStyleBackColor = True
        '
        'cmd_kiv
        '
        Me.cmd_kiv.Location = New System.Drawing.Point(126, 109)
        Me.cmd_kiv.Name = "cmd_kiv"
        Me.cmd_kiv.Size = New System.Drawing.Size(44, 23)
        Me.cmd_kiv.TabIndex = 6
        Me.cmd_kiv.Text = "-"
        Me.cmd_kiv.UseVisualStyleBackColor = True
        '
        'cmd_szor
        '
        Me.cmd_szor.Location = New System.Drawing.Point(126, 151)
        Me.cmd_szor.Name = "cmd_szor"
        Me.cmd_szor.Size = New System.Drawing.Size(44, 23)
        Me.cmd_szor.TabIndex = 7
        Me.cmd_szor.Text = "*"
        Me.cmd_szor.UseVisualStyleBackColor = True
        '
        'cmd_oszt
        '
        Me.cmd_oszt.Location = New System.Drawing.Point(126, 191)
        Me.cmd_oszt.Name = "cmd_oszt"
        Me.cmd_oszt.Size = New System.Drawing.Size(44, 23)
        Me.cmd_oszt.TabIndex = 8
        Me.cmd_oszt.Text = "/"
        Me.cmd_oszt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 282)
        Me.Controls.Add(Me.cmd_oszt)
        Me.Controls.Add(Me.cmd_szor)
        Me.Controls.Add(Me.cmd_kiv)
        Me.Controls.Add(Me.cmd_oa)
        Me.Controls.Add(Me.c_e)
        Me.Controls.Add(Me.cmd_vegrehajt)
        Me.Controls.Add(Me.szm_mszam)
        Me.Controls.Add(Me.szm_op)
        Me.Controls.Add(Me.szm_eszam)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents szm_eszam As System.Windows.Forms.TextBox
    Friend WithEvents szm_op As System.Windows.Forms.TextBox
    Friend WithEvents szm_mszam As System.Windows.Forms.TextBox
    Friend WithEvents cmd_vegrehajt As System.Windows.Forms.Button
    Friend WithEvents c_e As System.Windows.Forms.Label
    Friend WithEvents cmd_oa As System.Windows.Forms.Button
    Friend WithEvents cmd_kiv As System.Windows.Forms.Button
    Friend WithEvents cmd_szor As System.Windows.Forms.Button
    Friend WithEvents cmd_oszt As System.Windows.Forms.Button

End Class
