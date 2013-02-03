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
        Me.bevitt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tombszamlalo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.elemkiir = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.bevitel = New System.Windows.Forms.Button
        Me.elore = New System.Windows.Forms.Button
        Me.Vissza = New System.Windows.Forms.Button
        Me.elemek = New System.Windows.Forms.Button
        Me.lista = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.elemekszama = New System.Windows.Forms.TextBox
        Me.rendezettlista = New System.Windows.Forms.TextBox
        Me.rendezes = New System.Windows.Forms.Button
        Me.keresett = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.eredmeny = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'bevitt
        '
        Me.bevitt.Location = New System.Drawing.Point(25, 29)
        Me.bevitt.Name = "bevitt"
        Me.bevitt.Size = New System.Drawing.Size(100, 20)
        Me.bevitt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Írd be, amit beviszel a tömbbe"
        '
        'tombszamlalo
        '
        Me.tombszamlalo.Location = New System.Drawing.Point(25, 70)
        Me.tombszamlalo.Name = "tombszamlalo"
        Me.tombszamlalo.Size = New System.Drawing.Size(100, 20)
        Me.tombszamlalo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tömbszámláló:"
        '
        'elemkiir
        '
        Me.elemkiir.Location = New System.Drawing.Point(147, 70)
        Me.elemkiir.Name = "elemkiir"
        Me.elemkiir.Size = New System.Drawing.Size(100, 20)
        Me.elemkiir.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "a tömb eleme"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "elem"
        '
        'bevitel
        '
        Me.bevitel.Location = New System.Drawing.Point(147, 29)
        Me.bevitel.Name = "bevitel"
        Me.bevitel.Size = New System.Drawing.Size(100, 23)
        Me.bevitel.TabIndex = 8
        Me.bevitel.Text = "Bevitel"
        Me.bevitel.UseVisualStyleBackColor = True
        '
        'elore
        '
        Me.elore.Location = New System.Drawing.Point(25, 97)
        Me.elore.Name = "elore"
        Me.elore.Size = New System.Drawing.Size(46, 23)
        Me.elore.TabIndex = 9
        Me.elore.Text = "Előre"
        Me.elore.UseVisualStyleBackColor = True
        '
        'Vissza
        '
        Me.Vissza.Location = New System.Drawing.Point(77, 97)
        Me.Vissza.Name = "Vissza"
        Me.Vissza.Size = New System.Drawing.Size(47, 23)
        Me.Vissza.TabIndex = 10
        Me.Vissza.Text = "Vissza"
        Me.Vissza.UseVisualStyleBackColor = True
        '
        'elemek
        '
        Me.elemek.Location = New System.Drawing.Point(24, 135)
        Me.elemek.Name = "elemek"
        Me.elemek.Size = New System.Drawing.Size(100, 23)
        Me.elemek.TabIndex = 11
        Me.elemek.Text = "elemek listája"
        Me.elemek.UseVisualStyleBackColor = True
        '
        'lista
        '
        Me.lista.Location = New System.Drawing.Point(25, 164)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(222, 20)
        Me.lista.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Elemek száma"
        '
        'elemekszama
        '
        Me.elemekszama.Location = New System.Drawing.Point(147, 123)
        Me.elemekszama.Name = "elemekszama"
        Me.elemekszama.Size = New System.Drawing.Size(100, 20)
        Me.elemekszama.TabIndex = 14
        '
        'rendezettlista
        '
        Me.rendezettlista.Location = New System.Drawing.Point(24, 219)
        Me.rendezettlista.Name = "rendezettlista"
        Me.rendezettlista.Size = New System.Drawing.Size(223, 20)
        Me.rendezettlista.TabIndex = 15
        '
        'rendezes
        '
        Me.rendezes.Location = New System.Drawing.Point(24, 190)
        Me.rendezes.Name = "rendezes"
        Me.rendezes.Size = New System.Drawing.Size(100, 23)
        Me.rendezes.TabIndex = 16
        Me.rendezes.Text = "rendezve"
        Me.rendezes.UseVisualStyleBackColor = True
        '
        'keresett
        '
        Me.keresett.Location = New System.Drawing.Point(24, 308)
        Me.keresett.Name = "keresett"
        Me.keresett.Size = New System.Drawing.Size(101, 20)
        Me.keresett.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "keresés"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "keresett érték"
        '
        'eredmeny
        '
        Me.eredmeny.Location = New System.Drawing.Point(147, 308)
        Me.eredmeny.Name = "eredmeny"
        Me.eredmeny.Size = New System.Drawing.Size(100, 20)
        Me.eredmeny.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Keresés eredménye"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 340)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.eredmeny)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.keresett)
        Me.Controls.Add(Me.rendezes)
        Me.Controls.Add(Me.rendezettlista)
        Me.Controls.Add(Me.elemekszama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.elemek)
        Me.Controls.Add(Me.Vissza)
        Me.Controls.Add(Me.elore)
        Me.Controls.Add(Me.bevitel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.elemkiir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tombszamlalo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bevitt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bevitt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tombszamlalo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents elemkiir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bevitel As System.Windows.Forms.Button
    Friend WithEvents elore As System.Windows.Forms.Button
    Friend WithEvents Vissza As System.Windows.Forms.Button
    Friend WithEvents elemek As System.Windows.Forms.Button
    Friend WithEvents lista As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents elemekszama As System.Windows.Forms.TextBox
    Friend WithEvents rendezettlista As System.Windows.Forms.TextBox
    Friend WithEvents rendezes As System.Windows.Forms.Button
    Friend WithEvents keresett As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents eredmeny As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
