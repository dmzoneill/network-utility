Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents IconMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox7 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents btnLookup As System.Windows.Forms.Button
    Friend WithEvents txtDomain As System.Windows.Forms.TextBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
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
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetworkUtilityPreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralPreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopAllTimersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillActiveThreadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThreadCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportErrorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersionCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.IconMenu = New System.Windows.Forms.ContextMenu
        Me.MenuOpen = New System.Windows.Forms.MenuItem
        Me.MenuExit = New System.Windows.Forms.MenuItem
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
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
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton
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
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NetworkUtilityPreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TextOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneralPreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopAllTimersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KillActiveThreadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ThreadCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VersionCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
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
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(347, 26)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(403, 20)
        Me.TextBox18.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(783, 399)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Network Utility Options"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(777, 380)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(769, 353)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Info"
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
        Me.GroupBox2.Size = New System.Drawing.Size(742, 310)
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
        Me.Label9.Size = New System.Drawing.Size(30, 13)
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(774, 341)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Netstat"
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
        Me.Label1.Size = New System.Drawing.Size(30, 13)
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(774, 341)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ping"
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
        Me.Label8.Size = New System.Drawing.Size(75, 13)
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
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Start Range"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
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
        Me.TextBox11.Text = "10"
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
        Me.TextBox12.Text = "168"
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
        Me.TextBox13.Text = "192"
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
        Me.TextBox7.Text = "10"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(56, 62)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(36, 20)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = "168"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(14, 62)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(36, 20)
        Me.TextBox9.TabIndex = 12
        Me.TextBox9.Text = "192"
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
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(774, 341)
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
        Me.Label2.Size = New System.Drawing.Size(128, 13)
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
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(774, 341)
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
        Me.lblPrompt.Size = New System.Drawing.Size(108, 13)
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
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(774, 341)
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
        Me.Label7.Size = New System.Drawing.Size(57, 13)
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
        Me.TabPage9.Location = New System.Drawing.Point(4, 23)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(774, 341)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Wake On Lan"
        '
        'GroupBox10
        '
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
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(774, 341)
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
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Shutdown"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(105, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Restart"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(239, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Process"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(172, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Taskkill"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
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
        Me.CheckBox14.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox14.TabIndex = 32
        Me.CheckBox14.Text = "Localhost"
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(187, 29)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox13.TabIndex = 31
        Me.CheckBox13.Text = "Com50"
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(109, 137)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox12.TabIndex = 30
        Me.CheckBox12.Text = "Com49"
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(109, 116)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox11.TabIndex = 29
        Me.CheckBox11.Text = "Com48"
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(109, 94)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox10.TabIndex = 28
        Me.CheckBox10.Text = "Com47"
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(109, 72)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox9.TabIndex = 27
        Me.CheckBox9.Text = "Com46"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(109, 52)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox8.TabIndex = 26
        Me.CheckBox8.Text = "Com45"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(109, 29)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox7.TabIndex = 25
        Me.CheckBox7.Text = "Com44"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(24, 136)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox6.TabIndex = 24
        Me.CheckBox6.Text = "Com43"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(24, 114)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox5.TabIndex = 23
        Me.CheckBox5.Text = "Com42"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(24, 93)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox4.TabIndex = 22
        Me.CheckBox4.Text = "Com41"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(24, 72)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox3.TabIndex = 21
        Me.CheckBox3.Text = "Com40"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(24, 50)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Com39"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(24, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Com38"
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(189, 136)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox16.TabIndex = 18
        Me.CheckBox16.Text = "Coms 38 - 50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 455)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(790, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.ToolStripStatusLabel1.Text = "Network Utility Loaded"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator1, Me.helpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(790, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newToolStripButton
        '
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Text = "&New"
        '
        'openToolStripButton
        '
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Text = "&Open"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Text = "&Save"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        '
        'cutToolStripButton
        '
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Text = "C&ut"
        '
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Text = "&Copy"
        '
        'pasteToolStripButton
        '
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        '
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Text = "He&lp"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(790, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetworkUtilityPreferencesToolStripMenuItem, Me.StopAllTimersToolStripMenuItem, Me.KillActiveThreadsToolStripMenuItem, Me.ThreadCountToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'NetworkUtilityPreferencesToolStripMenuItem
        '
        Me.NetworkUtilityPreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsColorsToolStripMenuItem, Me.TextOptionsToolStripMenuItem, Me.GeneralPreferencesToolStripMenuItem})
        Me.NetworkUtilityPreferencesToolStripMenuItem.Name = "NetworkUtilityPreferencesToolStripMenuItem"
        Me.NetworkUtilityPreferencesToolStripMenuItem.Text = "Network Utility Preferences"
        '
        'WindowsColorsToolStripMenuItem
        '
        Me.WindowsColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2})
        Me.WindowsColorsToolStripMenuItem.Name = "WindowsColorsToolStripMenuItem"
        Me.WindowsColorsToolStripMenuItem.Text = "Window Options"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        '
        'TextOptionsToolStripMenuItem
        '
        Me.TextOptionsToolStripMenuItem.Name = "TextOptionsToolStripMenuItem"
        Me.TextOptionsToolStripMenuItem.Text = "Text Options"
        '
        'GeneralPreferencesToolStripMenuItem
        '
        Me.GeneralPreferencesToolStripMenuItem.Name = "GeneralPreferencesToolStripMenuItem"
        Me.GeneralPreferencesToolStripMenuItem.Text = "General Preferences"
        '
        'StopAllTimersToolStripMenuItem
        '
        Me.StopAllTimersToolStripMenuItem.Name = "StopAllTimersToolStripMenuItem"
        Me.StopAllTimersToolStripMenuItem.Text = "Stop All Timers"
        '
        'KillActiveThreadsToolStripMenuItem
        '
        Me.KillActiveThreadsToolStripMenuItem.Name = "KillActiveThreadsToolStripMenuItem"
        Me.KillActiveThreadsToolStripMenuItem.Text = "Kill Active Threads"
        '
        'ThreadCountToolStripMenuItem
        '
        Me.ThreadCountToolStripMenuItem.Name = "ThreadCountToolStripMenuItem"
        Me.ThreadCountToolStripMenuItem.Text = "Thread Count"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.WebsiteToolStripMenuItem, Me.ReportErrorToolStripMenuItem, Me.VersionCheckToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'ReportErrorToolStripMenuItem
        '
        Me.ReportErrorToolStripMenuItem.Name = "ReportErrorToolStripMenuItem"
        Me.ReportErrorToolStripMenuItem.Text = "Report Error"
        '
        'VersionCheckToolStripMenuItem
        '
        Me.VersionCheckToolStripMenuItem.Name = "VersionCheckToolStripMenuItem"
        Me.VersionCheckToolStripMenuItem.Text = "Version Check"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(790, 477)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
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
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public WithEvents TrayIcon As NotifyIcon    'This is the tray icon to be
    ' displayed, the WithEvents is to handle the double-click of the tray icon

    Private Shown As Boolean                     'This variable is used to hide
    ' tray icon when the form is visible. It really tells if the form is beeing
    ' shown (Suggestion: Try to find another way to make this work, becouse this
    ' isn't very nice (But it works)

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
