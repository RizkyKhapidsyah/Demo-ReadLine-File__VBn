Imports System.IO

Public Class Form1

    Private Sub tombolBaca_Click(sender As Object, e As EventArgs) Handles tombolBaca.Click
        'konstanta untuk banyak teman
        Const intBANYAK_TEMAN As Integer = 3

        'variabel-variabel lokal
        Dim fileTeman As StreamReader   'variabel objek
        Dim strNamafile As String       'nama file
        Dim strTeman As String          'nama teman
        Dim strTelp As String           'memuat nomor telepon
        Dim intHitung As Integer        'pencacah loop

        'membaca nama file dari user
        strNamafile = InputBox("Masukkan nama file.")

        Try
            'membuka file
            fileTeman = File.OpenText(strNamafile)

            'membaca data
            For intHitung = 1 To intBANYAK_TEMAN
                'membaca nama dan nomor telepon dari file
                strTeman = fileTeman.ReadLine()
                strTelp = fileTeman.ReadLine()

                'menampilkan data pada kotak list
                listTeman.Items.Add("Nomor Teman " & intHitung.ToString())
                listTeman.Items.Add("Nama: " & strTeman)
                listTeman.Items.Add("Telepon: " & strTelp)
                listTeman.Items.Add("")   'menambahkan baris kosong
            Next

            'menutup file
            fileTeman.Close()
        Catch
            MessageBox.Show("File tidak bisa dibuka.")
        End Try
    End Sub

    Private Sub tombolBersihkan_Click(sender As Object, e As EventArgs) Handles tombolBersihkan.Click
        'membersihkan kotak list
        listTeman.Items.Clear()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
