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
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text3 = New System.Windows.Forms.TextBox
        Me.Text4 = New System.Windows.Forms.TextBox
        Me.szamol = New System.Windows.Forms.Button
        Me.kiir = New System.Windows.Forms.Button
        Me.olvas = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(13, 13)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(100, 20)
        Me.Text1.TabIndex = 0
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(13, 54)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(100, 20)
        Me.Text2.TabIndex = 1
        '
        'Text3
        '
        Me.Text3.Location = New System.Drawing.Point(13, 94)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(100, 20)
        Me.Text3.TabIndex = 2
        '
        'Text4
        '
        Me.Text4.Location = New System.Drawing.Point(218, 12)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(100, 20)
        Me.Text4.TabIndex = 3
        '
        'szamol
        '
        Me.szamol.Location = New System.Drawing.Point(218, 54)
        Me.szamol.Name = "szamol"
        Me.szamol.Size = New System.Drawing.Size(75, 23)
        Me.szamol.TabIndex = 4
        Me.szamol.Text = "Számol"
        Me.szamol.UseVisualStyleBackColor = True
        '
        'kiir
        '
        Me.kiir.Location = New System.Drawing.Point(13, 166)
        Me.kiir.Name = "kiir"
        Me.kiir.Size = New System.Drawing.Size(75, 23)
        Me.kiir.TabIndex = 5
        Me.kiir.Text = "Kiír"
        Me.kiir.UseVisualStyleBackColor = True
        '
        'olvas
        '
        Me.olvas.Location = New System.Drawing.Point(118, 166)
        Me.olvas.Name = "olvas"
        Me.olvas.Size = New System.Drawing.Size(75, 23)
        Me.olvas.TabIndex = 6
        Me.olvas.Text = "Olvas"
        Me.olvas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 232)
        Me.Controls.Add(Me.olvas)
        Me.Controls.Add(Me.kiir)
        Me.Controls.Add(Me.szamol)
        Me.Controls.Add(Me.Text4)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents Text3 As System.Windows.Forms.TextBox
    Friend WithEvents Text4 As System.Windows.Forms.TextBox
    Friend WithEvents szamol As System.Windows.Forms.Button
    Friend WithEvents kiir As System.Windows.Forms.Button
    Friend WithEvents olvas As System.Windows.Forms.Button

End Class
