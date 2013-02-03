Public Class Form1
    Dim szamok() As Integer 'ha nem tipizáljuk, abc szerint rendez
    Dim n = 0               'tömbmutató
    Dim elemszam            'változó az elemszám rögzítéséhez

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bevitel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bevitel.Click
        n = n + 1

        Array.Resize(szamok, n)

        tombszamlalo.Text = n - 1

        szamok(n - 1) = bevitt.Text
        elemkiir.Text = bevitt.Text

        elemszam = n

        elemekszama.Text = elemszam

        bevitt.Text = ""    ' a bevitel után töröljük a mezőt, jelezve hogy új értéket vehetünk fel

    End Sub

    Private Sub elore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elore.Click
        Dim maxelem

        n = n + 1
        tombszamlalo.Text = n
        elemkiir.Text = szamok(n)
    End Sub

    Private Sub Vissza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vissza.Click
        n = n - 1
        tombszamlalo.Text = n
        elemkiir.Text = szamok(n)
    End Sub

    Private Sub elemek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elemek.Click
        Dim i = 0
        Dim listazas
        For i = 0 To elemszam - 1
            listazas = listazas & ";" & szamok(i)
            lista.Text = listazas
        Next i
    End Sub




    Private Sub rendezes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rendezes.Click
        Dim rendezettek

        Array.Sort(szamok)

        For x = 0 To szamok.GetUpperBound(0)
            rendezettek = rendezettek & ";" & szamok(x)
        Next

        rendezettlista.Text = rendezettek

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim keresett_ertek_indexe
        Dim keresett_adat As Integer
        keresett_adat = keresett.Text
        Array.BinarySearch(szamok, keresett_adat)
        keresett_ertek_indexe = Array.BinarySearch(szamok, keresett_adat)

        If keresett_ertek_indexe < 0 Then
            eredmeny.Text = "Nincs ilyen"
        Else
            eredmeny.Text = " Van ilyen"
        End If

        


    End Sub
End Class
