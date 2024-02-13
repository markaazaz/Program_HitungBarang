Imports System.Diagnostics.Eventing.Reader
Public Class Form1

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        Dim diskon As Double

        txt_namaBarang.Text = txt_inputNamaBarang.Text
        txt_hargaSatuan.Text = txt_inputHargaSatuan.Text
        txt_banyakBarang.Text = txt_inputBanyakBarang.Text
        txt_total.Text = Val(txt_inputHargaSatuan.Text) * Val(txt_inputBanyakBarang.Text)

        If Val(txt_total.Text) > 500000 AndAlso Val(txt_total.Text) < 1000000 Then
            diskon = Val(txt_total.Text) * 0.1
            txt_diskon.Text = diskon.ToString() & " (10 %)"

        ElseIf Val(txt_total.Text) >= 1000000 AndAlso Val(txt_total.Text) < 5000000 Then
            diskon = Val(txt_total.Text) * 0.2
            txt_diskon.Text = diskon.ToString() & " (20 %)"

        ElseIf Val(txt_total.Text) > 5000000 Then
            diskon = Val(txt_total.Text) * 0.3
            txt_diskon.Text = diskon.ToString() & " (30 %)"
        Else
            diskon = 0
            txt_diskon.Text = diskon.ToString() & " (0 %)"
        End If

        txt_total.Text = Val(txt_inputHargaSatuan.Text) * Val(txt_inputBanyakBarang.Text) - Val(txt_diskon.Text)
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        txt_namaBarang.Text = " "
        txt_hargaSatuan.Text = " "
        txt_banyakBarang.Text = " "
        txt_diskon.Text = " "
        txt_total.Text = " "
    End Sub

    Private Sub btn_selesai_Click(sender As Object, e As EventArgs) Handles btn_selesai.Click
        While True
            Me.Close()
        End While
    End Sub
End Class
