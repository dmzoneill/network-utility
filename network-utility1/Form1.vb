Imports ASOCKETLib
Imports System.IO
Imports System.Text
Imports System.Net.Sockets
Imports System.Threading


Public Class Form1
    Inherits System.Windows.Forms.Form

#Region "windows forms"

    Public WithEvents TrayIcon As NotifyIcon
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox8 As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox9 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Private Shown As Boolean
#End Region
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents IconMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetworkUtilityPreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportErrorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox7 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents btnLookup As System.Windows.Forms.Button
    Friend WithEvents txtDomain As System.Windows.Forms.TextBox
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents StopAllTimersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillActiveThreadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThreadCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents WindowsColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersionCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GeneralPreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents MenuExit As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.IconMenu = New System.Windows.Forms.ContextMenu
        Me.MenuOpen = New System.Windows.Forms.MenuItem
        Me.MenuExit = New System.Windows.Forms.MenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtResults = New System.Windows.Forms.TextBox
        Me.lblPrompt = New System.Windows.Forms.Label
        Me.btnLookup = New System.Windows.Forms.Button
        Me.txtDomain = New System.Windows.Forms.TextBox
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Button31 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox
        Me.Button15 = New System.Windows.Forms.Button
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox16 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.Button36 = New System.Windows.Forms.Button
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button35 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Button33 = New System.Windows.Forms.Button
        Me.RichTextBox8 = New System.Windows.Forms.RichTextBox
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.RichTextBox9 = New System.Windows.Forms.RichTextBox
        Me.Button37 = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VersionCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NetworkUtilityPreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TextOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneralPreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopAllTimersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KillActiveThreadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ThreadCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button38 = New System.Windows.Forms.Button
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Button39 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconMenu
        '
        Me.IconMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuOpen, Me.MenuExit})
        '
        'MenuOpen
        '
        Me.MenuOpen.Index = 0
        Me.MenuOpen.Text = "Open"
        '
        'MenuExit
        '
        Me.MenuExit.Index = 1
        Me.MenuExit.Text = "Exit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox14)
        Me.GroupBox2.Controls.Add(Me.TextBox20)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button27)
        Me.GroupBox2.Controls.Add(Me.Button28)
        Me.GroupBox2.Controls.Add(Me.RichTextBox7)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(742, 325)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Button30)
        Me.GroupBox14.Controls.Add(Me.Button29)
        Me.GroupBox14.Enabled = False
        Me.GroupBox14.Location = New System.Drawing.Point(603, 49)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(123, 99)
        Me.GroupBox14.TabIndex = 42
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "DHCP Lease"
        '
        'Button30
        '
        Me.Button30.Enabled = False
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button30.Location = New System.Drawing.Point(9, 55)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(105, 24)
        Me.Button30.TabIndex = 41
        Me.Button30.Text = "Renew Release"
        '
        'Button29
        '
        Me.Button29.Enabled = False
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button29.Location = New System.Drawing.Point(9, 25)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(105, 24)
        Me.Button29.TabIndex = 40
        Me.Button29.Text = "Release Lease"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(473, 23)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(124, 20)
        Me.TextBox20.TabIndex = 39
        Me.TextBox20.Text = "/all"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(425, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Args :"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(21, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 19)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Ipconfig"
        '
        'Button27
        '
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button27.Location = New System.Drawing.Point(626, 236)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(80, 19)
        Me.Button27.TabIndex = 36
        Me.Button27.Text = "Clear"
        '
        'Button28
        '
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button28.Location = New System.Drawing.Point(626, 211)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(80, 19)
        Me.Button28.TabIndex = 35
        Me.Button28.Text = "Save Results"
        '
        'RichTextBox7
        '
        Me.RichTextBox7.Location = New System.Drawing.Point(21, 49)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.Size = New System.Drawing.Size(576, 251)
        Me.RichTextBox7.TabIndex = 34
        Me.RichTextBox7.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox19)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.RichTextBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(742, 324)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Info"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(499, 22)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(124, 20)
        Me.TextBox19.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(458, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Args :"
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Location = New System.Drawing.Point(20, 22)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(80, 19)
        Me.Button11.TabIndex = 31
        Me.Button11.Text = "Netstat"
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(641, 201)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 19)
        Me.Button9.TabIndex = 29
        Me.Button9.Text = "Clear"
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Location = New System.Drawing.Point(641, 226)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 19)
        Me.Button10.TabIndex = 28
        Me.Button10.Text = "Save Results"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(20, 47)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(603, 261)
        Me.RichTextBox2.TabIndex = 0
        Me.RichTextBox2.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.GroupBox13)
        Me.GroupBox4.Controls.Add(Me.GroupBox12)
        Me.GroupBox4.Controls.Add(Me.GroupBox11)
        Me.GroupBox4.Controls.Add(Me.RichTextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(742, 324)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ping"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(327, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Alive Machines"
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(645, 299)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 19)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "Clear"
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(328, 299)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 19)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "Save Results"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Button24)
        Me.GroupBox13.Controls.Add(Me.Button6)
        Me.GroupBox13.Controls.Add(Me.TextBox5)
        Me.GroupBox13.Location = New System.Drawing.Point(18, 251)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(273, 67)
        Me.GroupBox13.TabIndex = 24
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Ping Hostname"
        '
        'Button24
        '
        Me.Button24.Enabled = False
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button24.Location = New System.Drawing.Point(192, 41)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(65, 20)
        Me.Button24.TabIndex = 10
        Me.Button24.Text = "Stop"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(192, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(65, 20)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Ping"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(14, 22)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(147, 20)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "boards.ie"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Button26)
        Me.GroupBox12.Controls.Add(Me.Button5)
        Me.GroupBox12.Controls.Add(Me.Label5)
        Me.GroupBox12.Controls.Add(Me.Label4)
        Me.GroupBox12.Controls.Add(Me.TextBox10)
        Me.GroupBox12.Controls.Add(Me.TextBox11)
        Me.GroupBox12.Controls.Add(Me.Button3)
        Me.GroupBox12.Controls.Add(Me.TextBox12)
        Me.GroupBox12.Controls.Add(Me.Button2)
        Me.GroupBox12.Controls.Add(Me.TextBox13)
        Me.GroupBox12.Controls.Add(Me.TextBox6)
        Me.GroupBox12.Controls.Add(Me.TextBox7)
        Me.GroupBox12.Controls.Add(Me.TextBox8)
        Me.GroupBox12.Controls.Add(Me.TextBox9)
        Me.GroupBox12.Location = New System.Drawing.Point(18, 90)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(273, 154)
        Me.GroupBox12.TabIndex = 23
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Ping Ip Range"
        '
        'Button26
        '
        Me.Button26.Enabled = False
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button26.Location = New System.Drawing.Point(191, 111)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(65, 20)
        Me.Button26.TabIndex = 23
        Me.Button26.Text = "Stop"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(191, 62)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 20)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Ping"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Start Range"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "End Range"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(140, 111)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(36, 20)
        Me.TextBox10.TabIndex = 19
        Me.TextBox10.Text = "255"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(98, 111)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(36, 20)
        Me.TextBox11.TabIndex = 18
        Me.TextBox11.Text = "188"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(208, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 20)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Class C"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(56, 111)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(36, 20)
        Me.TextBox12.TabIndex = 17
        Me.TextBox12.Text = "198"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(151, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 20)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Class B"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(14, 111)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(36, 20)
        Me.TextBox13.TabIndex = 16
        Me.TextBox13.Text = "87"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(140, 62)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(36, 20)
        Me.TextBox6.TabIndex = 15
        Me.TextBox6.Text = "1"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(98, 62)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(36, 20)
        Me.TextBox7.TabIndex = 14
        Me.TextBox7.Text = "188"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(56, 62)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(36, 20)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = "198"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(14, 62)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(36, 20)
        Me.TextBox9.TabIndex = 12
        Me.TextBox9.Text = "87"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button25)
        Me.GroupBox11.Controls.Add(Me.Button4)
        Me.GroupBox11.Controls.Add(Me.TextBox4)
        Me.GroupBox11.Controls.Add(Me.TextBox3)
        Me.GroupBox11.Controls.Add(Me.TextBox2)
        Me.GroupBox11.Controls.Add(Me.TextBox1)
        Me.GroupBox11.Location = New System.Drawing.Point(18, 16)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(273, 67)
        Me.GroupBox11.TabIndex = 22
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Ping Ip Address"
        '
        'Button25
        '
        Me.Button25.Enabled = False
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button25.Location = New System.Drawing.Point(192, 41)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(65, 20)
        Me.Button25.TabIndex = 11
        Me.Button25.Text = "Stop"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(192, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 20)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Ping"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(142, 19)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 20)
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.Text = "1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(100, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(36, 20)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "10"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(58, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(36, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "168"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "192"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(328, 33)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(397, 260)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(774, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Info"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(788, 387)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Network Utility Options"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 368)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(774, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Netstat"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(774, 339)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ping"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(774, 339)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Traceroute"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.TextBox14)
        Me.GroupBox6.Controls.Add(Me.Button12)
        Me.GroupBox6.Controls.Add(Me.Button13)
        Me.GroupBox6.Controls.Add(Me.Button14)
        Me.GroupBox6.Controls.Add(Me.RichTextBox3)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox6.Size = New System.Drawing.Size(742, 324)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Host Name or IP Address :"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(154, 29)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(126, 20)
        Me.TextBox14.TabIndex = 35
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Location = New System.Drawing.Point(528, 26)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(80, 19)
        Me.Button12.TabIndex = 34
        Me.Button12.Text = "Trace it"
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Location = New System.Drawing.Point(640, 183)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(80, 19)
        Me.Button13.TabIndex = 33
        Me.Button13.Text = "Clear"
        '
        'Button14
        '
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Location = New System.Drawing.Point(640, 208)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(80, 19)
        Me.Button14.TabIndex = 32
        Me.Button14.Text = "Save Results"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(19, 56)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(589, 249)
        Me.RichTextBox3.TabIndex = 0
        Me.RichTextBox3.Text = ""
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(774, 339)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Whois"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtResults)
        Me.GroupBox7.Controls.Add(Me.lblPrompt)
        Me.GroupBox7.Controls.Add(Me.btnLookup)
        Me.GroupBox7.Controls.Add(Me.txtDomain)
        Me.GroupBox7.Controls.Add(Me.Button16)
        Me.GroupBox7.Controls.Add(Me.Button17)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox7.Size = New System.Drawing.Size(742, 324)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Info"
        '
        'txtResults
        '
        Me.txtResults.BackColor = System.Drawing.SystemColors.Window
        Me.txtResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(26, 52)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResults.Size = New System.Drawing.Size(587, 254)
        Me.txtResults.TabIndex = 43
        Me.txtResults.WordWrap = False
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(25, 28)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(112, 13)
        Me.lblPrompt.TabIndex = 40
        Me.lblPrompt.Text = "&Domain or IP Address:"
        '
        'btnLookup
        '
        Me.btnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLookup.Location = New System.Drawing.Point(525, 25)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(88, 20)
        Me.btnLookup.TabIndex = 42
        Me.btnLookup.Text = "&Lookup"
        '
        'txtDomain
        '
        Me.txtDomain.Location = New System.Drawing.Point(145, 25)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(280, 20)
        Me.txtDomain.TabIndex = 41
        '
        'Button16
        '
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button16.Location = New System.Drawing.Point(642, 220)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(80, 20)
        Me.Button16.TabIndex = 39
        Me.Button16.Text = "Clear"
        '
        'Button17
        '
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button17.Location = New System.Drawing.Point(642, 246)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(80, 20)
        Me.Button17.TabIndex = 38
        Me.Button17.Text = "Save Results"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.GroupBox9)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(774, 339)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Portscan"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.TextBox17)
        Me.GroupBox9.Controls.Add(Me.Button21)
        Me.GroupBox9.Controls.Add(Me.Button22)
        Me.GroupBox9.Controls.Add(Me.Button23)
        Me.GroupBox9.Controls.Add(Me.RichTextBox6)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox9.Size = New System.Drawing.Size(742, 324)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Hostname :"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(86, 24)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(378, 20)
        Me.TextBox17.TabIndex = 47
        Me.TextBox17.Text = " -v -sS -O 192.168.10.50"
        '
        'Button21
        '
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button21.Location = New System.Drawing.Point(544, 24)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(80, 19)
        Me.Button21.TabIndex = 46
        Me.Button21.Text = "Scan"
        '
        'Button22
        '
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button22.Location = New System.Drawing.Point(642, 201)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(80, 19)
        Me.Button22.TabIndex = 45
        Me.Button22.Text = "Clear"
        '
        'Button23
        '
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button23.Location = New System.Drawing.Point(642, 226)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(80, 19)
        Me.Button23.TabIndex = 44
        Me.Button23.Text = "Save Results"
        '
        'RichTextBox6
        '
        Me.RichTextBox6.Location = New System.Drawing.Point(21, 51)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.Size = New System.Drawing.Size(603, 249)
        Me.RichTextBox6.TabIndex = 43
        Me.RichTextBox6.Text = ""
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.GroupBox10)
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(774, 339)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Wake On Lan"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label16)
        Me.GroupBox10.Controls.Add(Me.Button31)
        Me.GroupBox10.Controls.Add(Me.Button32)
        Me.GroupBox10.Controls.Add(Me.RichTextBox5)
        Me.GroupBox10.Controls.Add(Me.Button15)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox10.Size = New System.Drawing.Size(742, 324)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Wake Up Click Here Computers"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(141, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(283, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Unfortunatley the older computers dont support this feature"
        '
        'Button31
        '
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button31.Location = New System.Drawing.Point(640, 199)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(80, 19)
        Me.Button31.TabIndex = 47
        Me.Button31.Text = "Clear"
        '
        'Button32
        '
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button32.Location = New System.Drawing.Point(640, 224)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(80, 19)
        Me.Button32.TabIndex = 46
        Me.Button32.Text = "Save Results"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.Location = New System.Drawing.Point(17, 49)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.Size = New System.Drawing.Size(606, 263)
        Me.RichTextBox5.TabIndex = 2
        Me.RichTextBox5.Text = ""
        '
        'Button15
        '
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Location = New System.Drawing.Point(17, 24)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(103, 18)
        Me.Button15.TabIndex = 1
        Me.Button15.Text = "Wake All"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.Button20)
        Me.TabPage4.Controls.Add(Me.Button19)
        Me.TabPage4.Controls.Add(Me.Button18)
        Me.TabPage4.Controls.Add(Me.RichTextBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(774, 339)
        Me.TabPage4.TabIndex = 9
        Me.TabPage4.Text = "Remote Processes"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.TextBox16)
        Me.GroupBox8.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(311, 123)
        Me.GroupBox8.TabIndex = 20
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Command to execute"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Shutdown"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(105, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Restart"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(239, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Process"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(172, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Taskkill"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Restart Client Process"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(14, 65)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(277, 20)
        Me.TextBox16.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckBox14)
        Me.GroupBox5.Controls.Add(Me.CheckBox13)
        Me.GroupBox5.Controls.Add(Me.CheckBox12)
        Me.GroupBox5.Controls.Add(Me.CheckBox11)
        Me.GroupBox5.Controls.Add(Me.CheckBox10)
        Me.GroupBox5.Controls.Add(Me.CheckBox9)
        Me.GroupBox5.Controls.Add(Me.CheckBox8)
        Me.GroupBox5.Controls.Add(Me.CheckBox7)
        Me.GroupBox5.Controls.Add(Me.CheckBox6)
        Me.GroupBox5.Controls.Add(Me.CheckBox5)
        Me.GroupBox5.Controls.Add(Me.CheckBox4)
        Me.GroupBox5.Controls.Add(Me.CheckBox3)
        Me.GroupBox5.Controls.Add(Me.CheckBox2)
        Me.GroupBox5.Controls.Add(Me.CheckBox1)
        Me.GroupBox5.Controls.Add(Me.CheckBox16)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(17, 153)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(315, 163)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Computers to run on"
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(187, 50)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox14.TabIndex = 32
        Me.CheckBox14.Text = "Localhost"
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(187, 29)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox13.TabIndex = 31
        Me.CheckBox13.Text = "Com50"
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(109, 137)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox12.TabIndex = 30
        Me.CheckBox12.Text = "Com49"
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(109, 116)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox11.TabIndex = 29
        Me.CheckBox11.Text = "Com48"
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(109, 94)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox10.TabIndex = 28
        Me.CheckBox10.Text = "Com47"
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(109, 72)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox9.TabIndex = 27
        Me.CheckBox9.Text = "Com46"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(109, 52)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox8.TabIndex = 26
        Me.CheckBox8.Text = "Com45"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(109, 29)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox7.TabIndex = 25
        Me.CheckBox7.Text = "Com44"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(24, 136)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox6.TabIndex = 24
        Me.CheckBox6.Text = "Com43"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(24, 114)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox5.TabIndex = 23
        Me.CheckBox5.Text = "Com42"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(24, 93)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox4.TabIndex = 22
        Me.CheckBox4.Text = "Com41"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(24, 72)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox3.TabIndex = 21
        Me.CheckBox3.Text = "Com40"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(24, 50)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Com39"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(24, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Com38"
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(189, 136)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox16.TabIndex = 18
        Me.CheckBox16.Text = "Coms 38 - 50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Result Viewer"
        '
        'Button20
        '
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button20.Location = New System.Drawing.Point(546, 303)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(89, 24)
        Me.Button20.TabIndex = 3
        Me.Button20.Text = "Clear Results"
        '
        'Button19
        '
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button19.Location = New System.Drawing.Point(641, 303)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(89, 24)
        Me.Button19.TabIndex = 2
        Me.Button19.Text = "Save Results"
        '
        'Button18
        '
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button18.Location = New System.Drawing.Point(356, 303)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(80, 24)
        Me.Button18.TabIndex = 1
        Me.Button18.Text = "Execute"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Location = New System.Drawing.Point(356, 32)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(374, 260)
        Me.RichTextBox4.TabIndex = 0
        Me.RichTextBox4.Text = ""
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Button36)
        Me.TabPage7.Controls.Add(Me.Button34)
        Me.TabPage7.Controls.Add(Me.Button35)
        Me.TabPage7.Controls.Add(Me.Label15)
        Me.TabPage7.Controls.Add(Me.Label14)
        Me.TabPage7.Controls.Add(Me.TextBox21)
        Me.TabPage7.Controls.Add(Me.TextBox15)
        Me.TabPage7.Controls.Add(Me.Button33)
        Me.TabPage7.Controls.Add(Me.RichTextBox8)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(774, 339)
        Me.TabPage7.TabIndex = 10
        Me.TabPage7.Text = "Optional"
        '
        'Button36
        '
        Me.Button36.Location = New System.Drawing.Point(549, 21)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(62, 16)
        Me.Button36.TabIndex = 50
        Me.Button36.Text = "Execute"
        '
        'Button34
        '
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button34.Location = New System.Drawing.Point(651, 210)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(80, 19)
        Me.Button34.TabIndex = 49
        Me.Button34.Text = "Clear"
        '
        'Button35
        '
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button35.Location = New System.Drawing.Point(651, 235)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(80, 19)
        Me.Button35.TabIndex = 48
        Me.Button35.Text = "Save Results"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(156, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Program"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(384, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Args"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(424, 18)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(102, 20)
        Me.TextBox21.TabIndex = 3
        Me.TextBox21.Text = "/?"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(218, 16)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(145, 20)
        Me.TextBox15.TabIndex = 2
        '
        'Button33
        '
        Me.Button33.Location = New System.Drawing.Point(21, 18)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(100, 18)
        Me.Button33.TabIndex = 1
        Me.Button33.Text = "Select"
        '
        'RichTextBox8
        '
        Me.RichTextBox8.Location = New System.Drawing.Point(20, 45)
        Me.RichTextBox8.Name = "RichTextBox8"
        Me.RichTextBox8.Size = New System.Drawing.Size(592, 273)
        Me.RichTextBox8.TabIndex = 0
        Me.RichTextBox8.Text = ""
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.RichTextBox9)
        Me.TabPage10.Controls.Add(Me.Button37)
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(774, 339)
        Me.TabPage10.TabIndex = 11
        Me.TabPage10.Text = "Windows Hidden Utilities"
        '
        'RichTextBox9
        '
        Me.RichTextBox9.Location = New System.Drawing.Point(19, 49)
        Me.RichTextBox9.Name = "RichTextBox9"
        Me.RichTextBox9.Size = New System.Drawing.Size(741, 281)
        Me.RichTextBox9.TabIndex = 0
        Me.RichTextBox9.Text = ""
        '
        'Button37
        '
        Me.Button37.Location = New System.Drawing.Point(18, 16)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(139, 23)
        Me.Button37.TabIndex = 1
        Me.Button37.Text = "Show Possible Programs"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 443)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(788, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = Global.SystemTray.My.Resources.Resources.oemlogo
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(143, 17)
        Me.ToolStripStatusLabel1.Text = "Network Utility Loaded"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.WebsiteToolStripMenuItem, Me.ReportErrorToolStripMenuItem, Me.VersionCheckToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'ReportErrorToolStripMenuItem
        '
        Me.ReportErrorToolStripMenuItem.Name = "ReportErrorToolStripMenuItem"
        Me.ReportErrorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportErrorToolStripMenuItem.Text = "Report Error"
        '
        'VersionCheckToolStripMenuItem
        '
        Me.VersionCheckToolStripMenuItem.Name = "VersionCheckToolStripMenuItem"
        Me.VersionCheckToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VersionCheckToolStripMenuItem.Text = "Version Check"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator1, Me.helpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(788, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newToolStripButton
        '
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.newToolStripButton.Text = "&New"
        '
        'openToolStripButton
        '
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.openToolStripButton.Text = "&Open"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.saveToolStripButton.Text = "&Save"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.printToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'cutToolStripButton
        '
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.cutToolStripButton.Text = "C&ut"
        '
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.copyToolStripButton.Text = "&Copy"
        '
        'pasteToolStripButton
        '
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.pasteToolStripButton.Text = "&Paste"
        '
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.helpToolStripButton.Text = "He&lp"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetworkUtilityPreferencesToolStripMenuItem, Me.StopAllTimersToolStripMenuItem, Me.KillActiveThreadsToolStripMenuItem, Me.ThreadCountToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'NetworkUtilityPreferencesToolStripMenuItem
        '
        Me.NetworkUtilityPreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsColorsToolStripMenuItem, Me.TextOptionsToolStripMenuItem, Me.GeneralPreferencesToolStripMenuItem})
        Me.NetworkUtilityPreferencesToolStripMenuItem.Name = "NetworkUtilityPreferencesToolStripMenuItem"
        Me.NetworkUtilityPreferencesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.NetworkUtilityPreferencesToolStripMenuItem.Text = "Network Utility Preferences"
        '
        'WindowsColorsToolStripMenuItem
        '
        Me.WindowsColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2})
        Me.WindowsColorsToolStripMenuItem.Name = "WindowsColorsToolStripMenuItem"
        Me.WindowsColorsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.WindowsColorsToolStripMenuItem.Text = "Window Options"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(57, 6)
        '
        'TextOptionsToolStripMenuItem
        '
        Me.TextOptionsToolStripMenuItem.Name = "TextOptionsToolStripMenuItem"
        Me.TextOptionsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TextOptionsToolStripMenuItem.Text = "Text Options"
        '
        'GeneralPreferencesToolStripMenuItem
        '
        Me.GeneralPreferencesToolStripMenuItem.Name = "GeneralPreferencesToolStripMenuItem"
        Me.GeneralPreferencesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.GeneralPreferencesToolStripMenuItem.Text = "General Preferences"
        '
        'StopAllTimersToolStripMenuItem
        '
        Me.StopAllTimersToolStripMenuItem.Name = "StopAllTimersToolStripMenuItem"
        Me.StopAllTimersToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.StopAllTimersToolStripMenuItem.Text = "Stop All Timers"
        '
        'KillActiveThreadsToolStripMenuItem
        '
        Me.KillActiveThreadsToolStripMenuItem.Name = "KillActiveThreadsToolStripMenuItem"
        Me.KillActiveThreadsToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.KillActiveThreadsToolStripMenuItem.Text = "Kill Active Threads"
        '
        'ThreadCountToolStripMenuItem
        '
        Me.ThreadCountToolStripMenuItem.Name = "ThreadCountToolStripMenuItem"
        Me.ThreadCountToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ThreadCountToolStripMenuItem.Text = "Thread Count"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.SystemTray.My.Resources.Resources.oemlogo
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button38
        '
        Me.Button38.Location = New System.Drawing.Point(646, 4)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(95, 19)
        Me.Button38.TabIndex = 9
        Me.Button38.Text = "Stop Threads "
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(753, 3)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(23, 20)
        Me.TextBox18.TabIndex = 10
        Me.TextBox18.Text = "0"
        '
        'Button39
        '
        Me.Button39.Enabled = False
        Me.Button39.Location = New System.Drawing.Point(544, 4)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(95, 19)
        Me.Button39.TabIndex = 11
        Me.Button39.Text = "Allow Threads"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(788, 465)
        Me.Controls.Add(Me.Button39)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Network Utility - A Feed It Out Production - In Association with Click Here Inter" & _
            "net Cafe"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' !!! You have to add this code to the Form.Load Event Handler !!!

        TrayIcon = New NotifyIcon ' Makes a new instance of the tray icon (this
        '                           automatically creates it on the System Tray

        Shown = True '              The form is currently shown, so...


        With TrayIcon '                         Let's fill the tray icon
            .Visible = False '                  Becouse the form is currently
            '                                   shown, let's hide the tray icon
            .Icon = Me.Icon '                   You can define the image to be
            '                                   shown here, i put the icon of the
            '                                   form
            .Text = "Aplication Running..." '   This is the tool tip text that 
            '                                   shows the icon (You can change it
            '                                   dinamicaly)
            .ContextMenu = Me.IconMenu '        This tells the icon to show the 
            '                                   popup menu defined in the form
        End With

    End Sub
#Region " IconMenu Handlers "
    ' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    ' !!! You have to add this  handlers to your form to handle the IconMenu events !!!
    ' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    Private Sub MenuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayIcon.DoubleClick, MenuOpen.Click
        ' This handler restores the window when you click open in the 
        ' IconMenu-Open or when you double-click on the tray icon

        Me.WindowState = FormWindowState.Normal '   Restores the window
        Me.ShowInTaskbar = True '                   Show the TaskBar button
        Shown = True '                              The form is currently shown, so...
        TrayIcon.Visible = False '                  Hides the tray icon

    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        ' This handler exits the program when you click exit in the IconMenu-Exit
        ' WARNING!!!: If you have a code for the closing of the program, call it
        ' !!!!!!!!!!  from here, or it may not be executed

        TrayIcon.Visible = False '  This hides the tray icon before closing the
        '                           application. This is nessesary becouse of a
        '                           problem with some Windows (like XP) that don't
        '                           refresh the System Tray unless you hover the 
        '                           mouse over it
        Me.Close() '                Closes the form
        End '                       Ends the program

    End Sub

#End Region
    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        ' This handler hides the Taskbar button of the window and shows the tray icon
        ' if the form was minimized
        If Shown And Me.WindowState = FormWindowState.Minimized Then
            Shown = False '                 The form is currently hided, so...
            Me.ShowInTaskbar = False '      Hides the Taskbar button of the form
            TrayIcon.Visible = True '       Shows the tray icon
        End If
    End Sub

    Private whoisTable As New Hashtable()

    Delegate Sub changeTextControlDelegate(ByVal richtextbox5 As RichTextBox, ByVal sex As String)
    Delegate Sub changeText1ControlDelegate(ByVal richtextbox1 As RichTextBox, ByVal pings As String)
    Delegate Sub changeText2ControlDelegate(ByVal richtextbox1 As RichTextBox, ByVal ret As String)
    Delegate Sub changeText3ControlDelegate(ByVal richtextbox1 As RichTextBox, ByVal range As String)
    Delegate Sub changeText4ControlDelegate(ByVal richtextbox3 As RichTextBox, ByVal trace As String)
    Delegate Sub changeText5ControlDelegate(ByVal richtextbox6 As RichTextBox, ByVal scan As String)

    Public Sub setdisplaytext(ByVal richtextbox5 As RichTextBox, ByVal sex As String)
        richtextbox5.AppendText(sex & System.Environment.NewLine)
    End Sub
    Public Sub setdisplaytext1(ByVal richtextbox1 As RichTextBox, ByVal list As String)
        richtextbox1.AppendText(list & System.Environment.NewLine)
    End Sub
    Public Sub setdisplaytext2(ByVal richtextbox1 As RichTextBox, ByVal ret As String)
        richtextbox1.AppendText(ret & System.Environment.NewLine)
    End Sub
    Public Sub setdisplaytext3(ByVal richtextbox1 As RichTextBox, ByVal range As String)
        If (range = "") Then
            'richtextbox1.AppendText(range & System.Environment.NewLine)
        Else
            richtextbox1.AppendText(range & System.Environment.NewLine)
        End If
    End Sub
    Public Sub setdisplaytext4(ByVal richtextbox3 As RichTextBox, ByVal trace As String)
        richtextbox3.AppendText(trace & System.Environment.NewLine)
    End Sub
    Public Sub setdisplaytext5(ByVal richtextbox6 As RichTextBox, ByVal scan As String)
        richtextbox6.AppendText(scan & System.Environment.NewLine)
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim screen As New SplashScreen1
        screen.ShowDialog()

    End Sub



    Private Function doWhoisQuery(ByVal domain As String, ByVal server As String) As String
        Dim returnData As String = ""
        Dim tcpClient As New TcpClient()
        tcpClient.Connect(server, 43)
        Dim networkStream As NetworkStream = tcpClient.GetStream()
        If networkStream.CanWrite And networkStream.CanRead Then
            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(domain + vbCrLf)
            networkStream.Write(sendBytes, 0, sendBytes.Length)
            Dim bytes(tcpClient.ReceiveBufferSize) As Byte
            Dim recvSize As Int32
            recvSize = networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
            While (recvSize <> 0)
                returnData += Encoding.ASCII.GetString(bytes, 0, recvSize)
                recvSize = networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
            End While
        Else
            If Not networkStream.CanWrite Then
                returnData = "Cannot write data to this stream."
            Else
                If Not networkStream.CanRead Then
                    returnData = "Cannot read data from this stream."
                End If
            End If
        End If
        tcpClient.Close()
        Return returnData

    End Function
    Private Function isDomain(ByVal domain As String) As Boolean
        Dim regex As New RegularExpressions.Regex("^([a-zA-Z0-9]([a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,6}$")
        Return regex.IsMatch(domain)
    End Function
    Private Function isIP(ByVal ip As String) As Boolean
        Dim regex As New RegularExpressions.Regex("^(?:(?:25[0-5]|2[0-4]\d|[01]\d\d|\d?\d)(?(\.?\d)\.)){4}$")
        Return regex.IsMatch(ip)
    End Function
    Private Shared Function LoadWhoisServers(ByVal filename As String) As Hashtable
        Dim tmpArray() As String
        Dim whoisTable As New Hashtable()
        Try
            Dim MyStreamReader As StreamReader = IO.File.OpenText(filename)
            Do While MyStreamReader.Peek() >= 0
                tmpArray = MyStreamReader.ReadLine().Split("|")
                If (tmpArray.GetLength(0) = 6 And tmpArray(0).StartsWith("#") = False) Then
                    whoisTable.Add(tmpArray(0), tmpArray(1))
                End If
            Loop
            MyStreamReader.Close()
        Catch e As Exception
            MsgBox(e.Message + vbLf + "The application will now exit.", MsgBoxStyle.Critical)
            End
        End Try
        Return whoisTable
    End Function
    Private Shared Function GetInfoServer(ByVal queryTxt As String) As String
        Dim regex As New RegularExpressions.Regex("Whois Server:\s+(.+)", RegularExpressions.RegexOptions.IgnoreCase)
        Dim match As RegularExpressions.Match = regex.Match(queryTxt)
        If (match.Value <> "") Then
            Return match.Value.Substring(14)
        Else
            Return ""
        End If
    End Function
    Private Sub Whois_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        whoisTable = LoadWhoisServers("servers.lst")
    End Sub
    Private Sub pingip()
        Dim noddy As String
        Dim ret As String
        Dim objIcmp As ASOCKETLib.IcmpClass = New ASOCKETLib.Icmp()
        Dim objConstants As Constants = New Constants()
        Dim i As Integer
        i = 1
        Do While i > 0
            noddy = TextBox1.Text & "." & TextBox2.Text & "." & TextBox3.Text & "." & TextBox4.Text
            objIcmp.Ping(noddy, 2000)
            If (objIcmp.LastError = objConstants.asERR_SUCCESS) Then
                ret = " Reply from " & noddy & ": time=" & objIcmp.LastDuration.ToString() & "ms" & " TTL=" & objIcmp.LastTtl.ToString() & "ms"
            Else
                ret = noddy
            End If
            If Me.RichTextBox1.InvokeRequired Then
                Me.RichTextBox1.Invoke(New changeText1ControlDelegate(AddressOf setdisplaytext1), New Object() {RichTextBox1, ret})

            Else
                Me.setdisplaytext1(RichTextBox1, ret)
            End If
            System.Threading.Thread.Sleep(1000)
            i = i + 1 - 1
            If TextBox18.Text > 0 Then
                i = -1
            End If
        Loop

        ToolStripStatusLabel1.Text = "Ping request completed"

    End Sub
    Private Sub tracers()
        Dim myProcess As Process = New Process()
        Dim trace As String

        myProcess.StartInfo.FileName = "tracert.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = TextBox14.Text
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        trace = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        trace = trace.Replace(Chr(10), vbCrLf)

        If Me.RichTextBox3.InvokeRequired Then
            Me.RichTextBox3.Invoke(New changeText4ControlDelegate(AddressOf setdisplaytext4), New Object() {RichTextBox3, trace})
            ToolStripStatusLabel1.Text = "Traceroute complete to ..." & TextBox14.Text
        Else
            Me.setdisplaytext4(RichTextBox3, trace)
        End If


        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()
    End Sub
    Private Sub scan()
        Dim myProcess As Process = New Process()
        Dim s As String
        Dim scan As String

        myProcess.StartInfo.FileName = "./nmap/nmap.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = TextBox17.Text
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If
        scan = s

        If Me.RichTextBox6.InvokeRequired Then
            Me.RichTextBox6.Invoke(New changeText5ControlDelegate(AddressOf setdisplaytext5), New Object() {RichTextBox6, scan})

        Else
            Me.setdisplaytext5(RichTextBox6, scan)
        End If

        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()
    End Sub
    Private Sub pingranges()

        Dim noddy As String
        Dim objIcmp As ASOCKETLib.IcmpClass = New ASOCKETLib.Icmp()
        Dim objConstants As Constants = New Constants()
        Dim range As String

        For i As Integer = 1 To 1


            Dim one As Integer
            Dim two As Integer
            Dim three As Integer
            Dim four As Integer

            Dim startoct1 As String = TextBox9.Text
            Dim startoct2 As String = TextBox8.Text
            Dim startoct3 As String = TextBox7.Text
            Dim startoct4 As String = TextBox6.Text

            Dim endoct1 As String = TextBox13.Text
            Dim endoct2 As String = TextBox12.Text
            Dim endoct3 As String = TextBox11.Text
            Dim endoct4 As String = TextBox10.Text

            For one = startoct1 To endoct1
                For two = startoct2 To endoct2
                    For three = startoct3 To endoct3
                        For four = startoct4 To endoct4
                            noddy = one & "." & two & "." & three & "." & four
                            objIcmp.Ping(noddy, 5)
                            If (objIcmp.LastError = objConstants.asERR_SUCCESS) Then
                                range = " Reply from " & noddy & ": time=" & objIcmp.LastDuration.ToString() & "ms" & " TTL=" & objIcmp.LastTtl.ToString() & "ms"
                            Else
                                range = ""
                            End If
                            If Me.RichTextBox1.InvokeRequired Then
                                Me.RichTextBox1.Invoke(New changeText3ControlDelegate(AddressOf setdisplaytext3), New Object() {RichTextBox1, range})
                            Else
                                Me.setdisplaytext3(RichTextBox1, range)
                            End If
                            System.Threading.Thread.Sleep(5)
                            If TextBox18.Text > 0 Then
                                one = 255
                                two = 255
                                three = 255
                                four = 255
                            End If
                        Next
                    Next
                Next
            Next
        Next
    End Sub
    Private Sub pinghost()
        Dim noddy As String
        Dim rep As String
        Dim objIcmp As ASOCKETLib.IcmpClass = New ASOCKETLib.Icmp()
        Dim objConstants As Constants = New Constants()
        Dim i As Integer = 1
        Do While i > 0
            noddy = TextBox5.Text
            objIcmp.Ping(noddy, 2000)
            If (objIcmp.LastError = objConstants.asERR_SUCCESS) Then
                rep = " Reply from " & noddy & ": time=" & objIcmp.LastDuration.ToString() & "ms" & " TTL=" & objIcmp.LastTtl.ToString() & "ms"
            Else
                rep = "Requested time out: " & noddy
            End If
            System.Threading.Thread.Sleep(1000)
            i += 1

            If Me.RichTextBox1.InvokeRequired Then
                Me.RichTextBox1.Invoke(New changeText2ControlDelegate(AddressOf setdisplaytext2), New Object() {RichTextBox1, rep})
                ToolStripStatusLabel1.Text = "Ping Request Completed..." & rep
            Else
                Me.setdisplaytext2(RichTextBox1, rep)
            End If
            If TextBox18.Text > 0 Then
                i = -1
            End If
            i = i + 1
        Loop

        ToolStripStatusLabel1.Text = "Ping request completed"

    End Sub
    Private Sub wakeonlan()

        Dim comps(52) As String
        Dim r As Integer
        Dim sex As String = ""

        comps(0) = ""
        comps(1) = ""
        comps(2) = ""
        comps(3) = ""
        comps(4) = ""
        comps(5) = "com,127.0.0.1,00-30-05-01-B2-2F"
        comps(6) = "com6,192.168.10.6,00-30-05-01-B9-1E"
        comps(7) = "com7,192.168.10.7,00-01-02-43-55-D3"
        comps(8) = "com8,192.168.10.8,00-30-05-01-B9-D9"
        comps(9) = "com9,192.168.10.9,00-01-02-44-64-99"
        comps(10) = "com10,192.168.10.10,00-30-05-01-B3-66"
        comps(11) = "com11,192.168.10.11,00-01-02-44-5C-FC"
        comps(12) = "com12,192.168.10.12,00-30-05-01-B3-71"
        comps(13) = "com13,192.168.10.13,00-30-05-01-B2-24"
        comps(14) = "com14,192.168.10.14,00-30-05-01-BC-F4"
        comps(15) = "com15,192.168.10.15,00-30-05-01-AD-E9"
        comps(16) = "com16,192.168.10.16,00-30-05-01-B0-C6"
        comps(17) = "com17,192.168.10.17,00-30-05-01-AE-74"
        comps(18) = "com18,192.168.10.18,00-30-05-01-B2-0B"
        comps(19) = "com19,192.168.10.19,00-01-02-44-4F-62"
        comps(20) = "com20,192.168.10.20,00-30-05-01-B2-27"
        comps(21) = "com21,192.168.10.21,00-30-05-01-BA-2F"
        comps(22) = "com22,192.168.10.22,00-30-05-01-B2-29"
        comps(23) = "com23,192.168.10.23,00-30-05-01-B3-15"
        comps(24) = "com24,192.168.10.24,00-30-05-01-B2-2B"
        comps(25) = "com25,192.168.10.25,00-30-05-01-BA-CE"
        comps(26) = "com26,192.168.10.26,00-30-05-01-BA-A5"
        comps(27) = "com27,192.168.10.27,00-30-05-01-B9-E5"
        comps(28) = "com28,192.168.10.28,N/S"
        comps(29) = "com29,192.168.10.29,00-30-05-01-B3-79"
        comps(30) = "com30,192.168.10.30,00-30-05-01-BA-14"
        comps(31) = "com31,192.168.10.31,00-30-05-01-BC-6B"
        comps(32) = "com32,192.168.10.32,00-01-02-44-50-D4"
        comps(33) = "com33,192.168.10.33,00-30-05-01-B9-B7"
        comps(34) = "com34,192.168.10.34,00-01-02-44-50-43"
        comps(35) = "com35,192.168.10.35,00-30-05-01-B2-0F"
        comps(36) = "com36,192.168.10.36,00-30-05-01-BA-D3"
        comps(37) = "com37,192.168.10.37,00-01-02-44-65-04"
        comps(38) = "com38,192.168.10.38,00-0F-EA-19-9B-51"
        comps(39) = "com39,192.168.10.39,00-0F-EA-1A-35-64"
        comps(40) = "com40,192.168.10.40,00-0F-EA-19-AA-BF"
        comps(41) = "com41,192.168.10.41,00-0F-EA-19-BC-8D"
        comps(42) = "com42,192.168.10.42,00-0F-EA-1A-24-6D"
        comps(43) = "com43,192.168.10.43,00-0F-EA-19-BF-64"
        comps(44) = "com44,192.168.10.44,00-0F-EA-19-BB-06"
        comps(45) = "com45,192.168.10.45,00-0F-EA-19-BB-54"
        comps(46) = "com46,192.168.10.46,00-0F-EA-1B-DE-07"
        comps(47) = "com47,192.168.10.47,00-0F-EA-1A-1F-9F"
        comps(48) = "com48,192.168.10.48,00-0F-EA-19-C0-12"
        comps(49) = "com49,192.168.10.49,00-0F-EA-19-BA-D4"
        comps(50) = "com50,192.168.10.50,00-0F-EA-19-AA-E5"
        comps(51) = "manager,192.168.10.85,00-01-02-44-65-29"
        comps(52) = "brother,192.168.10.99,00-80-77-38-A0-8C"

        For r = 5 To comps.Length - 1

            sex = ""

            Dim objWol As ASOCKETLib.WOLClass = New ASOCKETLib.WOL()
            Dim objConstants As Constants = New Constants()
            Dim strMAC() As String = comps(r).Split(",")

            sex += "WakeUp " & strMAC(2) & " ..." & vbNewLine
            objWol.WakeUp(strMAC(2))
            sex += "Result: " & objWol.GetErrorDescription(objWol.LastError) & vbNewLine
            sex += "Ready." & vbNewLine
            ToolStripStatusLabel1.Text = "Wake on lan request completed to " & strMAC(0) & "..."
            If Me.RichTextBox5.InvokeRequired Then
                Me.RichTextBox5.Invoke(New changeTextControlDelegate(AddressOf setdisplaytext), New Object() {RichTextBox5, sex})

            Else
                Me.setdisplaytext(RichTextBox5, sex)

            End If
            If TextBox18.Text > 0 Then
                r = 6000000
            End If
        Next
        ToolStripStatusLabel1.Text = "Wake on lan requests completed"

    End Sub



    Private Sub btnLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookup.Click
        Dim lines As String
        Dim server As String
        Dim domain As String = txtDomain.Text
        Dim tld As String

        If (isIP(domain.Trim)) Then
            server = "whois.arin.net"
        ElseIf (isDomain(domain.Trim)) Then
            tld = domain.Substring(domain.IndexOf(".") + 1)
            server = whoisTable.Item(tld)
        Else
            MsgBox("It appears you entered something other than a Domain Name or IP Address.")
            txtDomain.Focus()
            txtDomain.SelectAll()
            Exit Sub
        End If
        ' display our working status
        txtResults.Lines = New String() {"Querying whois server(s)...Please wait"}
        txtResults.Refresh()
        ' do the whois query
        Dim whoisResult As String = doWhoisQuery(domain, server)
        ' send the output to the results textbox
        lines += "[" + server + "]" + vbLf
        lines += whoisResult + vbLf
        ' check for a redirect whois server
        Dim infoServer As String = GetInfoServer(whoisResult)
        If (infoServer <> "") Then
            whoisResult = doWhoisQuery(domain, infoServer)
            lines += "[" + infoServer + "]" + vbLf
            lines += whoisResult
        End If
        txtResults.Lines = lines.Split(vbLf)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myProcess As Process = New Process()
        Dim s As String

        myProcess.StartInfo.FileName = "ipconfig.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = TextBox20.Text
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        sIn.Write("dir c:\windows\system32\*.com" & _
           System.Environment.NewLine)
        sIn.Write("exit" & System.Environment.NewLine)
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        s = s.Replace(Chr(10), vbCrLf)
        Dim ss As String = "Lease Obtained"

        If s.IndexOf(ss, 0) >= 0 Then
            Button29.Enabled = True
            Button30.Enabled = True
            GroupBox14.Enabled = True
        End If
        RichTextBox7.Text = s

        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()
        ToolStripStatusLabel1.Text = "Obtained tcp/ip configuration..."
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox7.Text = 0
        TextBox6.Text = 1
        TextBox11.Text = 255
        TextBox10.Text = 255
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox6.Text = 1
        TextBox10.Text = 255
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim newthread3 As New System.Threading.Thread(AddressOf pingip)
        Dim threadcount As Integer
        threadcount += 1
        RichTextBox1.Clear()
        newthread3.Start()

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim newthread3 As New System.Threading.Thread(AddressOf pingranges)
        Dim threadcount As Integer
        threadcount += 1
        RichTextBox1.Clear()
        newthread3.Start()

        'Timer3.Enabled = True

        'If pingrange.IsAlive() Then
        '    pingrange.Resume()
        'Else
        '    pingrange.Start()
        '    Button26.Enabled = True
        'End If

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim newthread2 As New System.Threading.Thread(AddressOf pinghost)
        Dim threadcount As Integer
        threadcount += 1
        RichTextBox1.Clear()
        newthread2.Start()

        'Timer2.Enabled = True

        'If Pingping.IsAlive() Then
        '    Pingping.Resume()
        '    Button24.Enabled = True
        'Else
        '    Pingping.Start()
        '    Button24.Enabled = True
        'End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        SaveFileDialog1.InitialDirectory = "C:\My Documents"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(RichTextBox1.Text)

        MyWriter.Close()

    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim myProcess As Process = New Process()
        Dim s As String
        myProcess.StartInfo.FileName = "netstat.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = TextBox19.Text
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        sIn.Write("dir c:\windows\system32\*.com" & _
           System.Environment.NewLine)
        sIn.Write("exit" & System.Environment.NewLine)
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        RichTextBox2.Text = s

        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()

    End Sub
    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Dim myProcess As Process = New Process()
        Dim s As String
        TextBox20.Text = "/release"
        myProcess.StartInfo.FileName = "ipconfig.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = "/release"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        sIn.Write("dir c:\windows\system32\*.com" & _
           System.Environment.NewLine)
        sIn.Write("exit" & System.Environment.NewLine)
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        s = s.Replace(Chr(10), vbCrLf)

        RichTextBox7.Text = s & vbNewLine & RichTextBox7.Text

        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()
        ToolStripStatusLabel1.Text = "DHCP Lease released..."
    End Sub
    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Dim myProcess As Process = New Process()
        Dim s As String
        TextBox20.Text = "/renew"
        myProcess.StartInfo.FileName = "ipconfig.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = "/renew"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        sIn.Write("dir c:\windows\system32\*.com" & _
           System.Environment.NewLine)
        sIn.Write("exit" & System.Environment.NewLine)
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        s = s.Replace(Chr(10), vbCrLf)

        RichTextBox7.Text = s & vbNewLine & RichTextBox7.Text

        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()
        ToolStripStatusLabel1.Text = "DHCP Lease renewed..."
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim newthread3 As New System.Threading.Thread(AddressOf tracers)
        Dim threadcount As Integer
        threadcount += 1
        RichTextBox3.Clear()
        newthread3.Start()
        ToolStripStatusLabel1.Text = "Traceroute to " & TextBox14.Text & " in progress...."

    End Sub
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim newthread4 As New System.Threading.Thread(AddressOf scan)
        Dim threadcount As Integer
        threadcount += 1
        RichTextBox3.Clear()
        newthread4.Start()
        ToolStripStatusLabel1.Text = "Scan " & TextBox17.Text & " in progress...."

    End Sub
    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Dim open As New OpenFileDialog
        Dim file() As String

        open.InitialDirectory = "C:\WINDOWS\system32"
        open.Filter = "Executables(*.exe)|*.exe|Executables(*.com)|*.com"
        open.Title = "Select a file for execution"
        open.ShowDialog()
        file = open.FileName.Split("\")
        TextBox15.Text = file(3)

        Dim myProcess As Process = New Process()
        Dim s As String
        myProcess.StartInfo.FileName = file(3)
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.Arguments = TextBox21.Text
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()

        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        's = s.Replace(Chr(10), vbNewLine)

        RichTextBox8.Text = s & vbNewLine & RichTextBox8.Text

    End Sub
    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Dim myProcess As Process = New Process()
        Dim s As String
        myProcess.StartInfo.FileName = TextBox15.Text
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.Arguments = TextBox21.Text
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()

        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        's = s.Replace(Chr(10), vbNewLine)

        RichTextBox8.Text = s & vbNewLine & RichTextBox8.Text
    End Sub
    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Dim myProcess As Process = New Process()
        Dim s As String
        myProcess.StartInfo.FileName = "dir"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.Arguments = " /p /w *.exe"
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()

        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        's = s.Replace(Chr(10), vbNewLine)

        RichTextBox9.Text = s & vbNewLine & RichTextBox9.Text
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim newthread As New System.Threading.Thread(AddressOf wakeonlan)
        Dim threadcount As Integer
        threadcount += 1
        RichTextBox5.Clear()
        newthread.Start()

    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim objSocket As ASOCKETLib.Socket = New ASOCKETLib.Socket()
        Dim objConstants As Constants = New Constants()
        Dim strHost As String
        Dim strMessage As String
        Dim numPort As Integer = 1500
        Dim result As String
        Dim comps As String
        Dim coms() As String
        Dim i As Integer

        comps = ""

        If CheckBox1.Checked = True Then
            comps = comps & "192.168.10.38|"
        End If

        If CheckBox2.Checked = True Then
            comps = comps & "192.168.10.39|"
        End If

        If CheckBox3.Checked = True Then
            comps = comps & "192.168.10.40|"
        End If

        If CheckBox4.Checked = True Then
            comps = comps & "192.168.10.41|"
        End If

        If CheckBox5.Checked = True Then
            comps = comps & "192.168.10.42|"
        End If

        If CheckBox6.Checked = True Then
            comps = comps & "192.168.10.43|"
        End If

        If CheckBox7.Checked = True Then
            comps = comps & "192.168.10.44|"
        End If

        If CheckBox8.Checked = True Then
            comps = comps & "192.168.10.45|"
        End If

        If CheckBox9.Checked = True Then
            comps = comps & "192.168.10.46|"
        End If

        If CheckBox10.Checked = True Then
            comps = comps & "192.168.10.47|"
        End If

        If CheckBox11.Checked = True Then
            comps = comps & "192.168.10.48|"
        End If

        If CheckBox12.Checked = True Then
            comps = comps & "192.168.10.49|"
        End If

        If CheckBox13.Checked = True Then
            comps = comps & "192.168.10.50|"
        End If

        If CheckBox14.Checked = True Then
            comps = comps & "localhost|"

        End If

        result = ""
        coms = comps.Split("|")

        For i = 0 To coms.Length - 1

            strHost = coms(i)

            objSocket.Protocol = objConstants.asPROTOCOL_RAW
            objSocket.Connect(strHost, numPort)
            result = "Connect, result: " & objSocket.LastError.ToString() & " (" & objSocket.GetErrorDescription(objSocket.LastError) & ")" & vbCrLf & result
            If objSocket.LastError = 0 Then

                strMessage = TextBox16.Text
                objSocket.SendString("fff|")
                result = "SendString '" & strMessage & "', result: " & objSocket.LastError.ToString() & " (" & objSocket.GetErrorDescription(objSocket.LastError) & ")" & vbCrLf & result

                objSocket.Sleep(3)

                result = "disconnected " & vbNewLine & result
                RichTextBox4.Text = result
                objSocket.Disconnect()
            End If

        Next

    End Sub
    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        TextBox18.Text = 1
        Button39.Enabled = True
        Button38.Enabled = False
    End Sub
    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        TextBox18.Text = 0
        Button39.Enabled = False
        Button38.Enabled = True
    End Sub


    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Dim x As String

        x = "taskkill | /f /im kazaa.exe /im limewire.exe"
        TextBox16.Text = x

    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Dim x As String

        x = "shutdown |-r -t 30"
        TextBox16.Text = x

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Dim x As String

        x = "shutdown |-s -t 30"
        TextBox16.Text = x

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Dim x As String

        x = "net |stop alerter"
        TextBox16.Text = x

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Dim x As String

        x = "client restart"
        TextBox16.Text = x

    End Sub


    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        RichTextBox7.Clear()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        RichTextBox2.Clear()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox3.Clear()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        txtResults.Clear()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        RichTextBox6.Clear()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        RichTextBox5.Clear()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        RichTextBox4.Clear()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        RichTextBox8.Clear()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        SaveFileDialog1.InitialDirectory = ".\"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(RichTextBox7.Text)

        MyWriter.Close()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        SaveFileDialog1.InitialDirectory = ".\"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(RichTextBox2.Text)

        MyWriter.Close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFileDialog1.InitialDirectory = ".\"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(RichTextBox3.Text)

        MyWriter.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        SaveFileDialog1.InitialDirectory = ".\"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(txtResults.Text)

        MyWriter.Close()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        SaveFileDialog1.InitialDirectory = ".\"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(RichTextBox6.Text)

        MyWriter.Close()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        SaveFileDialog1.InitialDirectory = ".\"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(RichTextBox5.Text)

        MyWriter.Close()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        SaveFileDialog1.InitialDirectory = ".\"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(RichTextBox4.Text)

        MyWriter.Close()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        SaveFileDialog1.InitialDirectory = ".\"

        SaveFileDialog1.Filter = "Text Files(*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim MyWriter As System.IO.TextWriter

        MyWriter = System.IO.File.CreateText(SaveFileDialog1.FileName)

        MyWriter.Write(RichTextBox8.Text)

        MyWriter.Close()
    End Sub

    Private Sub ToolStripProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
