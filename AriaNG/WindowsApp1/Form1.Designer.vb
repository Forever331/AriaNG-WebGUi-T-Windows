<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Topbar = New System.Windows.Forms.Label()
        Me.Topbar2 = New System.Windows.Forms.Label()
        Me.Mini = New System.Windows.Forms.Button()
        Me.OFF = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 28)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1142, 625)
        Me.WebBrowser1.TabIndex = 0
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "AriaNG WGTW"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 48)
        '
        '显示ToolStripMenuItem
        '
        Me.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem"
        Me.显示ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.显示ToolStripMenuItem.Text = "显示"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'Topbar
        '
        Me.Topbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Topbar.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Topbar.Location = New System.Drawing.Point(0, -1)
        Me.Topbar.Name = "Topbar"
        Me.Topbar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Topbar.Size = New System.Drawing.Size(1141, 29)
        Me.Topbar.TabIndex = 1
        Me.Topbar.Text = "AriaNG-WebToWindows"
        Me.Topbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Topbar2
        '
        Me.Topbar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Topbar2.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Topbar2.Image = Global.WindowsApp1.My.Resources.Resources.favicon
        Me.Topbar2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Topbar2.Location = New System.Drawing.Point(0, -1)
        Me.Topbar2.Name = "Topbar2"
        Me.Topbar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Topbar2.Size = New System.Drawing.Size(230, 29)
        Me.Topbar2.TabIndex = 5
        Me.Topbar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mini
        '
        Me.Mini.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Mini.FlatAppearance.BorderSize = 0
        Me.Mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mini.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Mini.Image = Global.WindowsApp1.My.Resources.Resources.最小化
        Me.Mini.Location = New System.Drawing.Point(1070, -1)
        Me.Mini.Name = "Mini"
        Me.Mini.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mini.Size = New System.Drawing.Size(36, 29)
        Me.Mini.TabIndex = 4
        Me.Mini.TabStop = False
        Me.Mini.UseVisualStyleBackColor = False
        '
        'OFF
        '
        Me.OFF.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.OFF.FlatAppearance.BorderSize = 0
        Me.OFF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.OFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OFF.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.OFF.Image = Global.WindowsApp1.My.Resources.Resources.关闭
        Me.OFF.Location = New System.Drawing.Point(1106, -1)
        Me.OFF.Name = "OFF"
        Me.OFF.Size = New System.Drawing.Size(36, 29)
        Me.OFF.TabIndex = 3
        Me.OFF.TabStop = False
        Me.OFF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.OFF.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1142, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.Topbar2)
        Me.Controls.Add(Me.Mini)
        Me.Controls.Add(Me.OFF)
        Me.Controls.Add(Me.Topbar)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Topbar As Label
    Friend WithEvents Mini As Button
    Friend WithEvents OFF As Button
    Friend WithEvents Topbar2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 显示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
End Class
