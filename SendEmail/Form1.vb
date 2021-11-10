Imports System.Net.Mail
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim mail As New MailMessage
            Dim smtpserver As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(txtfrom.Text)
            mail.To.Add(txtto.Text)
            mail.Subject = txtsubj.Text
            mail.Body = txtbody.Text

            smtpserver.Port = 587
            smtpserver.Credentials = New System.Net.NetworkCredential(txtfrom.Text, txtpass.Text)
            smtpserver.EnableSsl = True
            smtpserver.Send(mail)
            MsgBox("Sent")


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class
