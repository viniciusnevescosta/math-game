﻿Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = (nome)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        ' Listar:
        Dim i As Integer

        If TextBox1.Text.Trim.Length = 0 Then
            For i = 1 To 10 Step 1
                TextBox1.Text &= " " & i.ToString() & "x2 = " & vbCrLf
            Next i
        Else
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Verfica se contém apenas números:
        If Not IsNumeric(TextBox2.Text & TextBox3.Text & TextBox4.Text & TextBox5.Text & TextBox6.Text & TextBox7.Text & TextBox8.Text & TextBox9.Text & TextBox10.Text & TextBox11.Text) Then
            MessageBox.Show("Apenas números", "Error")
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox11.Clear()
        End If

        ' Verifica se todos os campos foram preenchidos + pontuação:
        Dim vazio As Integer

        If TextBox2.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox2.Text) = (2 * 1) Then
            pontuacao2 += 2
        End If

        If TextBox3.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox3.Text) = (2 * 2) Then
            pontuacao2 += 2
        End If

        If TextBox4.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox4.Text) = (2 * 3) Then
            pontuacao2 += 2
        End If

        If TextBox5.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox5.Text) = (2 * 4) Then
            pontuacao2 += 2
        End If

        If TextBox6.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox6.Text) = (2 * 5) Then
            pontuacao2 += 2
        End If

        If TextBox7.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox7.Text) = (2 * 6) Then
            pontuacao2 += 2
        End If

        If TextBox9.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox8.Text) = (2 * 7) Then
            pontuacao2 += 2
        End If

        If TextBox9.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox9.Text) = (2 * 8) Then
            pontuacao2 += 2
        End If

        If TextBox10.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox10.Text) = (2 * 9) Then
            pontuacao2 += 2
        End If

        If TextBox11.Text.Trim.Length = 0 Then
            vazio += 1
        ElseIf Convert.ToInt32(TextBox11.Text) = (2 * 10) Then
            pontuacao2 += 2
        End If

        If vazio >= 1 Then
            MessageBox.Show("Responda todos os campos", "Aviso")
        End If

        Label3.Text = (pontuacao2 & "/4 pontos")

        ' proxima fase
        If vazio = 0 And pontuacao2 >= 4 Then
            Button2.Visible = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Close()
    End Sub
End Class