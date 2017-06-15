Imports System.ComponentModel
Public Class Form1
    Public Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click
        Try
            If rdb_for_rom.Checked Or rdb_for_arabic.Checked Then
                If rdb_for_rom.Checked Then
                    Me.Size = New System.Drawing.Size(1216, 481)
                    lbl_result.Text = convertForRom(txt_num.Text)
                ElseIf rdb_for_arabic.Checked Then
                    Me.Size = New System.Drawing.Size(1216, 481)
                    lbl_result.Text = convertForArabic(txt_num.Text)
                End If
            Else
                MsgBox("Selecione uma conversão.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO!")
            End If
        Catch ex As Exception
            MsgBox("Digite números validos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO!")
            txt_num.Text = ""
        End Try

    End Sub

    Private Sub frm_conversao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_result.Text = ""
        txt_num.Text = ""
        Me.Size = New System.Drawing.Size(422, 481)
    End Sub

    Private Sub txt_num_GotFocus(sender As Object, e As EventArgs) Handles txt_num.GotFocus
        Me.Size = New System.Drawing.Size(422, 481)
        lbl_result.Text = ""
        txt_num.Text = ""
        rdb_for_rom.Checked = False
        rdb_for_arabic.Checked = False
        rdb_for_rom.Enabled = True
        rdb_for_arabic.Enabled = True
    End Sub

    Private Sub btn_voltar2_Click(sender As Object, e As EventArgs) Handles btn_voltar2.Click
        Me.Size = New System.Drawing.Size(819, 481)
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Size = New System.Drawing.Size(422, 481)
    End Sub

    Private Sub btn_avançar_Click(sender As Object, e As EventArgs) Handles btn_avançar.Click
        If txt_num.Text <> "" Then
            Me.Size = New System.Drawing.Size(819, 481)
            If IsNumeric(txt_num.Text) Then
                rdb_for_arabic.Enabled = False
            Else
                rdb_for_rom.Enabled = False
            End If

        Else
            MsgBox("Digite um número ou algarismo romano a ser convertido.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Size = New System.Drawing.Size(422, 481)
        lbl_result.Text = ""
        txt_num.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
