<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysInForntToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IpAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxSlot2Current = New System.Windows.Forms.GroupBox()
        Me.LabelTA2 = New System.Windows.Forms.Label()
        Me.LabelDST2 = New System.Windows.Forms.Label()
        Me.LabelCallType2 = New System.Windows.Forms.Label()
        Me.LabelSRC2 = New System.Windows.Forms.Label()
        Me.GroupBoxSlot2Last = New System.Windows.Forms.GroupBox()
        Me.LabelLast2 = New System.Windows.Forms.Label()
        Me.GroupBoxSlot1Current = New System.Windows.Forms.GroupBox()
        Me.LabelTA1 = New System.Windows.Forms.Label()
        Me.LabelDST1 = New System.Windows.Forms.Label()
        Me.LabelCallType1 = New System.Windows.Forms.Label()
        Me.LabelSRC1 = New System.Windows.Forms.Label()
        Me.GroupBoxSlot1Last = New System.Windows.Forms.GroupBox()
        Me.LabelLast1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxSlot2Current.SuspendLayout()
        Me.GroupBoxSlot2Last.SuspendLayout()
        Me.GroupBoxSlot1Current.SuspendLayout()
        Me.GroupBoxSlot1Last.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 294)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(484, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(280, 17)
        Me.ToolStripStatusLabel2.Text = "HH:MM:SS"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 17)
        Me.ToolStripStatusLabel1.Text = "Listening on xxx.xxx.xxx.xxx:xxxxx"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.CheckOnClick = True
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.LogToolStripMenuItem.Text = "Log"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysInForntToolStripMenuItem, Me.IpAddressToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EditToolStripMenuItem.Text = "Options"
        '
        'AlwaysInForntToolStripMenuItem
        '
        Me.AlwaysInForntToolStripMenuItem.Checked = True
        Me.AlwaysInForntToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AlwaysInForntToolStripMenuItem.Name = "AlwaysInForntToolStripMenuItem"
        Me.AlwaysInForntToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlwaysInForntToolStripMenuItem.Text = "Always in front"
        '
        'IpAddressToolStripMenuItem
        '
        Me.IpAddressToolStripMenuItem.Name = "IpAddressToolStripMenuItem"
        Me.IpAddressToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.IpAddressToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IpAddressToolStripMenuItem.Text = "socket settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "About ..."
        '
        'Timer1
        '
        '
        'GroupBoxSlot2Current
        '
        Me.GroupBoxSlot2Current.Controls.Add(Me.LabelTA2)
        Me.GroupBoxSlot2Current.Controls.Add(Me.LabelDST2)
        Me.GroupBoxSlot2Current.Controls.Add(Me.LabelCallType2)
        Me.GroupBoxSlot2Current.Controls.Add(Me.LabelSRC2)
        Me.GroupBoxSlot2Current.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxSlot2Current.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBoxSlot2Current.Location = New System.Drawing.Point(0, 24)
        Me.GroupBoxSlot2Current.Name = "GroupBoxSlot2Current"
        Me.GroupBoxSlot2Current.Size = New System.Drawing.Size(484, 80)
        Me.GroupBoxSlot2Current.TabIndex = 10
        Me.GroupBoxSlot2Current.TabStop = False
        Me.GroupBoxSlot2Current.Text = "Slot 2 Current"
        '
        'LabelTA2
        '
        Me.LabelTA2.AutoSize = True
        Me.LabelTA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTA2.Location = New System.Drawing.Point(12, 40)
        Me.LabelTA2.Name = "LabelTA2"
        Me.LabelTA2.Size = New System.Drawing.Size(44, 29)
        Me.LabelTA2.TabIndex = 10
        Me.LabelTA2.Text = "TA"
        '
        'LabelDST2
        '
        Me.LabelDST2.AutoSize = True
        Me.LabelDST2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDST2.Location = New System.Drawing.Point(338, 16)
        Me.LabelDST2.Name = "LabelDST2"
        Me.LabelDST2.Size = New System.Drawing.Size(41, 20)
        Me.LabelDST2.TabIndex = 9
        Me.LabelDST2.Text = "DST"
        '
        'LabelCallType2
        '
        Me.LabelCallType2.AutoSize = True
        Me.LabelCallType2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCallType2.Location = New System.Drawing.Point(129, 16)
        Me.LabelCallType2.Name = "LabelCallType2"
        Me.LabelCallType2.Size = New System.Drawing.Size(128, 20)
        Me.LabelCallType2.TabIndex = 8
        Me.LabelCallType2.Text = ">>> call type >>>"
        Me.LabelCallType2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelSRC2
        '
        Me.LabelSRC2.AutoSize = True
        Me.LabelSRC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSRC2.Location = New System.Drawing.Point(13, 16)
        Me.LabelSRC2.Name = "LabelSRC2"
        Me.LabelSRC2.Size = New System.Drawing.Size(43, 20)
        Me.LabelSRC2.TabIndex = 7
        Me.LabelSRC2.Text = "SRC"
        '
        'GroupBoxSlot2Last
        '
        Me.GroupBoxSlot2Last.Controls.Add(Me.LabelLast2)
        Me.GroupBoxSlot2Last.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxSlot2Last.Location = New System.Drawing.Point(0, 104)
        Me.GroupBoxSlot2Last.Name = "GroupBoxSlot2Last"
        Me.GroupBoxSlot2Last.Size = New System.Drawing.Size(484, 55)
        Me.GroupBoxSlot2Last.TabIndex = 11
        Me.GroupBoxSlot2Last.TabStop = False
        Me.GroupBoxSlot2Last.Text = "Slot 2 Last"
        '
        'LabelLast2
        '
        Me.LabelLast2.AutoSize = True
        Me.LabelLast2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLast2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelLast2.Location = New System.Drawing.Point(13, 20)
        Me.LabelLast2.Name = "LabelLast2"
        Me.LabelLast2.Size = New System.Drawing.Size(40, 20)
        Me.LabelLast2.TabIndex = 10
        Me.LabelLast2.Text = "Last"
        '
        'GroupBoxSlot1Current
        '
        Me.GroupBoxSlot1Current.Controls.Add(Me.LabelTA1)
        Me.GroupBoxSlot1Current.Controls.Add(Me.LabelDST1)
        Me.GroupBoxSlot1Current.Controls.Add(Me.LabelCallType1)
        Me.GroupBoxSlot1Current.Controls.Add(Me.LabelSRC1)
        Me.GroupBoxSlot1Current.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxSlot1Current.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBoxSlot1Current.Location = New System.Drawing.Point(0, 159)
        Me.GroupBoxSlot1Current.Name = "GroupBoxSlot1Current"
        Me.GroupBoxSlot1Current.Size = New System.Drawing.Size(484, 80)
        Me.GroupBoxSlot1Current.TabIndex = 12
        Me.GroupBoxSlot1Current.TabStop = False
        Me.GroupBoxSlot1Current.Text = "Slot 1 Current"
        '
        'LabelTA1
        '
        Me.LabelTA1.AutoSize = True
        Me.LabelTA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTA1.Location = New System.Drawing.Point(12, 40)
        Me.LabelTA1.Name = "LabelTA1"
        Me.LabelTA1.Size = New System.Drawing.Size(44, 29)
        Me.LabelTA1.TabIndex = 10
        Me.LabelTA1.Text = "TA"
        '
        'LabelDST1
        '
        Me.LabelDST1.AutoSize = True
        Me.LabelDST1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDST1.Location = New System.Drawing.Point(338, 16)
        Me.LabelDST1.Name = "LabelDST1"
        Me.LabelDST1.Size = New System.Drawing.Size(41, 20)
        Me.LabelDST1.TabIndex = 9
        Me.LabelDST1.Text = "DST"
        '
        'LabelCallType1
        '
        Me.LabelCallType1.AutoSize = True
        Me.LabelCallType1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCallType1.Location = New System.Drawing.Point(129, 16)
        Me.LabelCallType1.Name = "LabelCallType1"
        Me.LabelCallType1.Size = New System.Drawing.Size(128, 20)
        Me.LabelCallType1.TabIndex = 8
        Me.LabelCallType1.Text = ">>> call type >>>"
        Me.LabelCallType1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelSRC1
        '
        Me.LabelSRC1.AutoSize = True
        Me.LabelSRC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSRC1.Location = New System.Drawing.Point(13, 16)
        Me.LabelSRC1.Name = "LabelSRC1"
        Me.LabelSRC1.Size = New System.Drawing.Size(43, 20)
        Me.LabelSRC1.TabIndex = 7
        Me.LabelSRC1.Text = "SRC"
        '
        'GroupBoxSlot1Last
        '
        Me.GroupBoxSlot1Last.Controls.Add(Me.LabelLast1)
        Me.GroupBoxSlot1Last.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxSlot1Last.Location = New System.Drawing.Point(0, 239)
        Me.GroupBoxSlot1Last.Name = "GroupBoxSlot1Last"
        Me.GroupBoxSlot1Last.Size = New System.Drawing.Size(484, 55)
        Me.GroupBoxSlot1Last.TabIndex = 13
        Me.GroupBoxSlot1Last.TabStop = False
        Me.GroupBoxSlot1Last.Text = "Slot 1 Last"
        '
        'LabelLast1
        '
        Me.LabelLast1.AutoSize = True
        Me.LabelLast1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLast1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelLast1.Location = New System.Drawing.Point(13, 20)
        Me.LabelLast1.Name = "LabelLast1"
        Me.LabelLast1.Size = New System.Drawing.Size(40, 20)
        Me.LabelLast1.TabIndex = 10
        Me.LabelLast1.Text = "Last"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 316)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBoxSlot1Last)
        Me.Controls.Add(Me.GroupBoxSlot1Current)
        Me.Controls.Add(Me.GroupBoxSlot2Last)
        Me.Controls.Add(Me.GroupBoxSlot2Current)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1200, 355)
        Me.MinimumSize = New System.Drawing.Size(500, 165)
        Me.Name = "MainForm"
        Me.Text = "Displayserver by ON7LDS"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxSlot2Current.ResumeLayout(False)
        Me.GroupBoxSlot2Current.PerformLayout()
        Me.GroupBoxSlot2Last.ResumeLayout(False)
        Me.GroupBoxSlot2Last.PerformLayout()
        Me.GroupBoxSlot1Current.ResumeLayout(False)
        Me.GroupBoxSlot1Current.PerformLayout()
        Me.GroupBoxSlot1Last.ResumeLayout(False)
        Me.GroupBoxSlot1Last.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlwaysInForntToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxSlot2Current As GroupBox
    Friend WithEvents LabelTA2 As Label
    Friend WithEvents LabelDST2 As Label
    Friend WithEvents LabelCallType2 As Label
    Friend WithEvents LabelSRC2 As Label
    Friend WithEvents GroupBoxSlot2Last As GroupBox
    Friend WithEvents LabelLast2 As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IpAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxSlot1Current As GroupBox
    Friend WithEvents LabelTA1 As Label
    Friend WithEvents LabelDST1 As Label
    Friend WithEvents LabelCallType1 As Label
    Friend WithEvents LabelSRC1 As Label
    Friend WithEvents GroupBoxSlot1Last As GroupBox
    Friend WithEvents LabelLast1 As Label
End Class
