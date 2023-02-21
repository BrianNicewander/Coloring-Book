<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Me.grpColoringPage = New System.Windows.Forms.GroupBox()
        Me.btnYourPic = New System.Windows.Forms.Button()
        Me.bntWolf = New System.Windows.Forms.Button()
        Me.btnDragon = New System.Windows.Forms.Button()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.btnMinions = New System.Windows.Forms.Button()
        Me.btnFish = New System.Windows.Forms.Button()
        Me.btnHouse = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpColoringPage.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpColoringPage
        '
        Me.grpColoringPage.Controls.Add(Me.btnYourPic)
        Me.grpColoringPage.Controls.Add(Me.bntWolf)
        Me.grpColoringPage.Controls.Add(Me.btnDragon)
        Me.grpColoringPage.Controls.Add(Me.btnCar)
        Me.grpColoringPage.Controls.Add(Me.btnMinions)
        Me.grpColoringPage.Controls.Add(Me.btnFish)
        Me.grpColoringPage.Controls.Add(Me.btnHouse)
        Me.grpColoringPage.Location = New System.Drawing.Point(12, 27)
        Me.grpColoringPage.Name = "grpColoringPage"
        Me.grpColoringPage.Size = New System.Drawing.Size(205, 300)
        Me.grpColoringPage.TabIndex = 0
        Me.grpColoringPage.TabStop = False
        Me.grpColoringPage.Text = "Pick a Coloring Page"
        '
        'btnYourPic
        '
        Me.btnYourPic.Location = New System.Drawing.Point(20, 262)
        Me.btnYourPic.Margin = New System.Windows.Forms.Padding(1)
        Me.btnYourPic.Name = "btnYourPic"
        Me.btnYourPic.Size = New System.Drawing.Size(159, 23)
        Me.btnYourPic.TabIndex = 6
        Me.btnYourPic.Text = "&Pick your own coloring page"
        Me.ToolTip1.SetToolTip(Me.btnYourPic, "This lets you pick your own coloring page to color on.")
        Me.btnYourPic.UseVisualStyleBackColor = True
        '
        'bntWolf
        '
        Me.bntWolf.Location = New System.Drawing.Point(20, 226)
        Me.bntWolf.Name = "bntWolf"
        Me.bntWolf.Size = New System.Drawing.Size(159, 23)
        Me.bntWolf.TabIndex = 5
        Me.bntWolf.Text = "&Wolf"
        Me.ToolTip1.SetToolTip(Me.bntWolf, "This will load the Wolf coloring page")
        Me.bntWolf.UseVisualStyleBackColor = True
        '
        'btnDragon
        '
        Me.btnDragon.Location = New System.Drawing.Point(20, 69)
        Me.btnDragon.Name = "btnDragon"
        Me.btnDragon.Size = New System.Drawing.Size(159, 23)
        Me.btnDragon.TabIndex = 1
        Me.btnDragon.Text = "&Dragon"
        Me.ToolTip1.SetToolTip(Me.btnDragon, "This will load the Dragon coloring page")
        Me.btnDragon.UseVisualStyleBackColor = True
        '
        'btnCar
        '
        Me.btnCar.Location = New System.Drawing.Point(20, 29)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(159, 23)
        Me.btnCar.TabIndex = 0
        Me.btnCar.Text = "&Car"
        Me.ToolTip1.SetToolTip(Me.btnCar, "This will load the Car coloring page")
        Me.btnCar.UseVisualStyleBackColor = True
        '
        'btnMinions
        '
        Me.btnMinions.Location = New System.Drawing.Point(20, 188)
        Me.btnMinions.Name = "btnMinions"
        Me.btnMinions.Size = New System.Drawing.Size(159, 23)
        Me.btnMinions.TabIndex = 4
        Me.btnMinions.Text = "&Minion"
        Me.ToolTip1.SetToolTip(Me.btnMinions, "This will load the Minion coloring page")
        Me.btnMinions.UseVisualStyleBackColor = True
        '
        'btnFish
        '
        Me.btnFish.Location = New System.Drawing.Point(20, 110)
        Me.btnFish.Name = "btnFish"
        Me.btnFish.Size = New System.Drawing.Size(159, 23)
        Me.btnFish.TabIndex = 2
        Me.btnFish.Text = "F&ish"
        Me.ToolTip1.SetToolTip(Me.btnFish, "This will load the Fish Coloring page")
        Me.btnFish.UseVisualStyleBackColor = True
        '
        'btnHouse
        '
        Me.btnHouse.Location = New System.Drawing.Point(20, 150)
        Me.btnHouse.Name = "btnHouse"
        Me.btnHouse.Size = New System.Drawing.Size(159, 23)
        Me.btnHouse.TabIndex = 3
        Me.btnHouse.Text = "&House"
        Me.ToolTip1.SetToolTip(Me.btnHouse, "This will load the House coloring page")
        Me.btnHouse.UseVisualStyleBackColor = True
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.Title = "Pick a image"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(233, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShow, Me.mnuLoad, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuShow
        '
        Me.mnuShow.Name = "mnuShow"
        Me.mnuShow.Size = New System.Drawing.Size(131, 22)
        Me.mnuShow.Text = "&Slide Show"
        Me.mnuShow.ToolTipText = "This will take you to a slide show of coloring pages"
        '
        'mnuLoad
        '
        Me.mnuLoad.Name = "mnuLoad"
        Me.mnuLoad.Size = New System.Drawing.Size(131, 22)
        Me.mnuLoad.Text = "&Load"
        Me.mnuLoad.ToolTipText = "This will load a previously saved coloring page"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(131, 22)
        Me.mnuExit.Text = "&Exit"
        Me.mnuExit.ToolTipText = "This will exit the program"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 340)
        Me.Controls.Add(Me.grpColoringPage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPage"
        Me.Text = "Main Page"
        Me.grpColoringPage.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpColoringPage As GroupBox
    Friend WithEvents bntWolf As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnDragon As Button
    Friend WithEvents btnCar As Button
    Friend WithEvents btnMinions As Button
    Friend WithEvents btnFish As Button
    Friend WithEvents btnHouse As Button
    Friend WithEvents ofdOpenFile As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuLoad As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuShow As ToolStripMenuItem
    Friend WithEvents btnYourPic As Button
End Class
