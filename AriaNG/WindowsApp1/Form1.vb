Public Class Form1
    Private FormDrag As Boolean = False
    Private Clicked As Point

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim doURL As String = "file:\\\" + Application.StartupPath + "\index.html"
        Me.WebBrowser1.Url = New Uri(doURL)



    End Sub
    Private Sub webBrowser1_DocumentTitleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles WebBrowser1.DocumentTitleChanged

        Topbar.Text = WebBrowser1.DocumentTitle
        If Topbar.Text = "无法访问此页面" Then
            Topbar.Text = "请前往Github页面查看详情 或 放入mayswind制作的index.html文件"
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.ShowInTaskbar = True
        Me.Show()
        Me.WindowState = FormWindowState.Normal

    End Sub

    '-------------------关闭按钮--------------------
    Private Sub OFF_Click(sender As Object, e As EventArgs) Handles OFF.Click
        Me.Close()
    End Sub
    '-------------------------------------------------
    '-------------------最小化按钮--------------------
    Private Sub Mini_Click(sender As Object, e As EventArgs) Handles Mini.Click
        Me.Hide()
    End Sub
    '-------------------------------------------------
    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 显示ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示ToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.Visible = False Then
            显示ToolStripMenuItem.Enabled = True
            退出ToolStripMenuItem.Enabled = True
        ElseIf Me.Visible = True Then
            显示ToolStripMenuItem.Enabled = False
            退出ToolStripMenuItem.Enabled = True
        End If
    End Sub
    '----------------Top窗口任意位置鼠标拖动-------------------
    Private Sub Topbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Topbar.MouseDown
        Me.FormDrag = True
        Me.Clicked = New Point(e.X, e.Y)
    End Sub
    Private Sub Topbar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Topbar.MouseUp
        Me.FormDrag = False
    End Sub
    Private Sub Topbar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Topbar.MouseMove
        If Me.FormDrag Then
            Dim Moving As Point
            Moving = Me.PointToScreen(New Point(e.X, e.Y))
            Moving.Offset(Me.Clicked.X * -1,
            (Me.Clicked.Y) * -1)
            Me.Location = Moving
        End If
    End Sub
    Private Sub Topbar2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Topbar2.MouseDown
        Me.FormDrag = True
        Me.Clicked = New Point(e.X, e.Y)
    End Sub
    Private Sub Topbar2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Topbar2.MouseUp
        Me.FormDrag = False
    End Sub
    Private Sub Topbar2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Topbar2.MouseMove
        If Me.FormDrag Then
            Dim Moving As Point
            Moving = Me.PointToScreen(New Point(e.X, e.Y))
            Moving.Offset(Me.Clicked.X * -1,
            (Me.Clicked.Y) * -1)
            Me.Location = Moving
        End If
    End Sub
    '-----------------------------------------------------------

End Class
