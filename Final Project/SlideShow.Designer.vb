<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlideShow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.btnPrevious = New System.Windows.Forms.Button()
		Me.pbxSlideShow = New System.Windows.Forms.PictureBox()
		Me.chkSlide = New System.Windows.Forms.CheckBox()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtTime = New System.Windows.Forms.TextBox()
		Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
		Me.lblTime = New System.Windows.Forms.Label()
		CType(Me.pbxSlideShow, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnNext
		'
		Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnNext.Location = New System.Drawing.Point(388, 551)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(75, 82)
		Me.btnNext.TabIndex = 0
		Me.btnNext.Text = ">"
		Me.ToolTip1.SetToolTip(Me.btnNext, "This will go to the next picture")
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnPrevious
		'
		Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPrevious.Location = New System.Drawing.Point(307, 551)
		Me.btnPrevious.Name = "btnPrevious"
		Me.btnPrevious.Size = New System.Drawing.Size(75, 82)
		Me.btnPrevious.TabIndex = 2
		Me.btnPrevious.Text = "<"
		Me.ToolTip1.SetToolTip(Me.btnPrevious, "This will go to the previous picture")
		Me.btnPrevious.UseVisualStyleBackColor = True
		'
		'pbxSlideShow
		'
		Me.pbxSlideShow.Location = New System.Drawing.Point(12, 27)
		Me.pbxSlideShow.Name = "pbxSlideShow"
		Me.pbxSlideShow.Size = New System.Drawing.Size(752, 518)
		Me.pbxSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxSlideShow.TabIndex = 1
		Me.pbxSlideShow.TabStop = False
		'
		'chkSlide
		'
		Me.chkSlide.AutoSize = True
		Me.chkSlide.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSlide.Location = New System.Drawing.Point(473, 607)
		Me.chkSlide.Name = "chkSlide"
		Me.chkSlide.Size = New System.Drawing.Size(165, 33)
		Me.chkSlide.TabIndex = 3
		Me.chkSlide.Text = "Slide Show"
		Me.ToolTip1.SetToolTip(Me.chkSlide, "This will start and stop  the slide show")
		Me.chkSlide.UseVisualStyleBackColor = True
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(773, 24)
		Me.MenuStrip1.TabIndex = 4
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'mnuFile
		'
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuExit})
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Size = New System.Drawing.Size(37, 20)
		Me.mnuFile.Text = "&File"
		'
		'mnuBack
		'
		Me.mnuBack.Name = "mnuBack"
		Me.mnuBack.Size = New System.Drawing.Size(99, 22)
		Me.mnuBack.Text = "&Back"
		Me.mnuBack.ToolTipText = "This will take you back to the Main Page"
		'
		'mnuExit
		'
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.Size = New System.Drawing.Size(99, 22)
		Me.mnuExit.Text = "&Exit"
		Me.mnuExit.ToolTipText = "This will close the program"
		'
		'txtTime
		'
		Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTime.Location = New System.Drawing.Point(473, 577)
		Me.txtTime.Name = "txtTime"
		Me.txtTime.Size = New System.Drawing.Size(92, 31)
		Me.txtTime.TabIndex = 5
		Me.txtTime.Text = "2"
		Me.ToolTip1.SetToolTip(Me.txtTime, "Enter in how long you want between each slide.")
		'
		'tmrTime
		'
		Me.tmrTime.Interval = 2000
		'
		'lblTime
		'
		Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTime.Location = New System.Drawing.Point(469, 554)
		Me.lblTime.Name = "lblTime"
		Me.lblTime.Size = New System.Drawing.Size(189, 23)
		Me.lblTime.TabIndex = 6
		Me.lblTime.Text = "Time Between Slides"
		'
		'SlideShow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(773, 715)
		Me.Controls.Add(Me.lblTime)
		Me.Controls.Add(Me.txtTime)
		Me.Controls.Add(Me.chkSlide)
		Me.Controls.Add(Me.btnPrevious)
		Me.Controls.Add(Me.pbxSlideShow)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "SlideShow"
		Me.Text = "SlideShow"
		CType(Me.pbxSlideShow, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnNext As Button
    Friend WithEvents pbxSlideShow As PictureBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents chkSlide As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents tmrTime As Timer
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblTime As Label
End Class
