<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ColoringPage
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.radPen = New System.Windows.Forms.RadioButton()
        Me.radEraser = New System.Windows.Forms.RadioButton()
        Me.btnErase = New System.Windows.Forms.Button()
        Me.cboErase = New System.Windows.Forms.ComboBox()
        Me.btnPen = New System.Windows.Forms.Button()
        Me.cboPen = New System.Windows.Forms.ComboBox()
        Me.mnuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.cdColor = New System.Windows.Forms.ColorDialog()
        Me.pbxPicture = New System.Windows.Forms.PictureBox()
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.mnuStrip1.SuspendLayout()
        CType(Me.pbxPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radPen
        '
        Me.radPen.Location = New System.Drawing.Point(15, 632)
        Me.radPen.Margin = New System.Windows.Forms.Padding(2)
        Me.radPen.Name = "radPen"
        Me.radPen.Size = New System.Drawing.Size(49, 53)
        Me.radPen.TabIndex = 23
        Me.radPen.TabStop = True
        Me.ToolTip1.SetToolTip(Me.radPen, "Select me to color")
        Me.radPen.UseVisualStyleBackColor = True
        '
        'radEraser
        '
        Me.radEraser.Location = New System.Drawing.Point(197, 631)
        Me.radEraser.Margin = New System.Windows.Forms.Padding(2)
        Me.radEraser.Name = "radEraser"
        Me.radEraser.Size = New System.Drawing.Size(49, 53)
        Me.radEraser.TabIndex = 22
        Me.radEraser.TabStop = True
        Me.ToolTip1.SetToolTip(Me.radEraser, "Select me to erase")
        Me.radEraser.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnErase.Location = New System.Drawing.Point(250, 631)
        Me.btnErase.Margin = New System.Windows.Forms.Padding(2)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(117, 28)
        Me.btnErase.TabIndex = 20
        Me.btnErase.Text = "Change Eraser Color"
        Me.ToolTip1.SetToolTip(Me.btnErase, "Click me to choose your eraser color")
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'cboErase
        '
        Me.cboErase.FormattingEnabled = True
        Me.cboErase.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboErase.Location = New System.Drawing.Point(249, 663)
        Me.cboErase.Margin = New System.Windows.Forms.Padding(2)
        Me.cboErase.Name = "cboErase"
        Me.cboErase.Size = New System.Drawing.Size(92, 21)
        Me.cboErase.TabIndex = 21
        Me.cboErase.Text = "Eraser Size"
        Me.ToolTip1.SetToolTip(Me.cboErase, "Select your eraser size here")
        '
        'btnPen
        '
        Me.btnPen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPen.Location = New System.Drawing.Point(70, 632)
        Me.btnPen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPen.Name = "btnPen"
        Me.btnPen.Size = New System.Drawing.Size(110, 28)
        Me.btnPen.TabIndex = 18
        Me.btnPen.TabStop = False
        Me.btnPen.Text = "Change Pen Color"
        Me.ToolTip1.SetToolTip(Me.btnPen, "Click me to choose your color")
        Me.btnPen.UseVisualStyleBackColor = True
        '
        'cboPen
        '
        Me.cboPen.FormattingEnabled = True
        Me.cboPen.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboPen.Location = New System.Drawing.Point(70, 664)
        Me.cboPen.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPen.Name = "cboPen"
        Me.cboPen.Size = New System.Drawing.Size(92, 21)
        Me.cboPen.TabIndex = 19
        Me.cboPen.Text = "Pen Size"
        Me.ToolTip1.SetToolTip(Me.cboPen, "Select your pen size here")
        '
        'mnuStrip1
        '
        Me.mnuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.mnuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip1.Name = "mnuStrip1"
        Me.mnuStrip1.Size = New System.Drawing.Size(882, 24)
        Me.mnuStrip1.TabIndex = 6
        Me.mnuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuSaveAs, Me.mnuBack, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(114, 22)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "This will save the Coloring Page"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(114, 22)
        Me.mnuSaveAs.Text = "Save &As"
        Me.mnuSaveAs.ToolTipText = "This will let you pick where to save your Coloring Page"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(114, 22)
        Me.mnuBack.Text = "&Back"
        Me.mnuBack.ToolTipText = "This will take you back to the Main Page"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(114, 22)
        Me.mnuExit.Text = "&Exit"
        Me.mnuExit.ToolTipText = "This will exit the program"
        '
        'tmrClock
        '
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.SystemColors.Control
        Me.lblClock.Location = New System.Drawing.Point(12, 697)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(254, 27)
        Me.lblClock.TabIndex = 8
        '
        'pbxPicture
        '
        Me.pbxPicture.Location = New System.Drawing.Point(12, 26)
        Me.pbxPicture.Name = "pbxPicture"
        Me.pbxPicture.Size = New System.Drawing.Size(600, 600)
        Me.pbxPicture.TabIndex = 7
        Me.pbxPicture.TabStop = False
        '
        'sfdSaveFile
        '
        Me.sfdSaveFile.Filter = "| *.jpg "
        '
        'ColoringPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 732)
        Me.Controls.Add(Me.btnPen)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.cboPen)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.cboErase)
        Me.Controls.Add(Me.mnuStrip1)
        Me.Controls.Add(Me.radEraser)
        Me.Controls.Add(Me.pbxPicture)
        Me.Controls.Add(Me.radPen)
        Me.MainMenuStrip = Me.mnuStrip1
        Me.Name = "ColoringPage"
        Me.Text = "Coloring Page"
        Me.mnuStrip1.ResumeLayout(False)
        Me.mnuStrip1.PerformLayout()
        CType(Me.pbxPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents mnuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents tmrClock As Timer
    Friend WithEvents lblClock As Label
    Friend WithEvents pbxPicture As PictureBox
    Friend WithEvents cdColor As ColorDialog
    Friend WithEvents sfdSaveFile As SaveFileDialog
    Friend WithEvents btnErase As Button
    Friend WithEvents cboErase As ComboBox
    Friend WithEvents radPen As RadioButton
    Friend WithEvents radEraser As RadioButton
    Friend WithEvents btnPen As Button
    Friend WithEvents cboPen As ComboBox
End Class
