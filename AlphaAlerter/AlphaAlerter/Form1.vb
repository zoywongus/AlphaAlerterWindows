Public Class Form1
    Dim notif As New NotifyIcon
    Dim secondspassed As Integer = 0
    Dim currentinterval As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Me.ComboBox1.SelectedIndex = 0
        MsgBox(ComboBox1.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = True
        Button1.Enabled = False
        If ComboBox1.SelectedIndex = 0 Then
            currentinterval = 30
        ElseIf ComboBox1.SelectedIndex = 0 Then
            currentinterval = 60
        ElseIf ComboBox1.SelectedIndex = 0 Then
            currentinterval = 300
        ElseIf ComboBox1.SelectedIndex = 0 Then
            currentinterval = 600
        ElseIf ComboBox1.SelectedIndex = 0 Then
            currentinterval = 900
        End If
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Timer1.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button2.Enabled = False
        Timer1.Stop()
        secondspassed = 0
    End Sub

    Private Sub sendnotif()
        notif.Icon = Me.Icon
        notif.Visible = True
        notif.ShowBalloonTip(6000, "ALPHAALERTER ALERT", TextBox2.Text, ToolTipIcon.Warning)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        secondspassed = secondspassed + 1
        If secondspassed = currentinterval Then
            sendnotif()
            secondspassed = 0
        End If
    End Sub


End Class
