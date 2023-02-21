Public Class ColoringPage
    'Coloring book Coloring Page.
    'The page where you color your picture.
    'Last Modified 4/30/19
    'Created by Brian Nicewander and Emily Gerhardt

    Dim draw As Boolean = False
    Dim g As Graphics
    Dim rainbow As Color
    Dim rainbow2 As String
    Dim pen As Integer
    Dim penLine As Integer = 2                              ' line thickness for the pen
    Dim penEraser As Integer = 2                            ' line thickness for the eraser
    Dim x, y, x2, y2 As Integer
    Dim blnIsChanged As Boolean = False                     'File change flag
    Public strFileName As String = String.Empty             'Document filename
    Dim brush As String = "line"
    Dim rainbowEraser As Color = Color.White                'color for eraser
    Dim rainbowLine As Color = Color.Black                  'color for line

    Private Sub ColoringPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On Load event sets my Timer up and the color
        tmrClock.Enabled = True                       'Enables the Timer
        tmrClock.Interval = 1                         'Set the Timer interval
        g = Graphics.FromImage(MainPage.picture2)     'integrate pictures here maybe i dunno
        rainbow = Color.Black                         'initial color
        pen = penLine                                 'initial pen size
        radEraser.BackColor = Color.White
        radPen.BackColor = Color.Black
        radPen.Checked = True
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        'Timer procedure used to update the time by the second
        lblClock.Text = Now.ToString("D") & " " & CStr(TimeOfDay)
    End Sub

    Private Sub pbxPicture_MouseDown(sender As Object, e As MouseEventArgs) Handles pbxPicture.MouseDown
        'If the mouse is the clicked down it will draw.
        draw = True
    End Sub

    Private Sub pbxPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles pbxPicture.MouseMove
        'Sets up how to draw when the mouse is clicked down.
        If draw = True Then
            ' the cool pen we gotta write color and pen funtions for
            If radPen.Checked = True Then
                x = getMouse.X - 12 'first set of chords
                y = getMouse.Y - 25
                Threading.Thread.Sleep(20) 'let it rest for a bit so it can get those cords
                x2 = getMouse.X - 12 ' second set of chords
                y2 = getMouse.Y - 25
                pen = penLine 'change size to whatever the drawign thing is
                rainbow = rainbowLine 'change color to whatever the drawy thing is set to
                Dim line As New Pen(rainbowLine, penLine) ' our pen boi
                g.DrawLine(line, x, y, x2, y2) ' aactually draws the line
                pbxPicture.Refresh() 'makes our cool line actually show up
            End If
            If radEraser.Checked = True Then
                x = getMouse.X - 12 'first set of chords
                y = getMouse.Y - 25
                Threading.Thread.Sleep(20) 'let it rest for a bit so it can get those cords
                x2 = getMouse.X - 12  ' second set of chords
                y2 = getMouse.Y - 25
                pen = penEraser ' change size to whatever eraser is set at
                rainbow = rainbowEraser ' change pen color to whatever the eraser is
                Dim eraser As New Pen(rainbow, pen) 'our eraser boi
                g.DrawLine(eraser, x, y, x2, y2) 'actually draws the line
                pbxPicture.Refresh() 'makes our cool line actually show up
            End If
            blnIsChanged = True
        End If
    End Sub

    Private Sub pbxPicture_MouseUp(sender As Object, e As MouseEventArgs) Handles pbxPicture.MouseUp
        draw = False 'so it does a good stop
    End Sub

    Public Function getMouse() As Point
        Return PointToClient(Cursor.Position) ' the PointToCLient makes it so it actually finds the locations on the form
    End Function

    Private Sub btnPen_Click(sender As Object, e As EventArgs) Handles btnPen.Click
        'This is for the pen.
        If cdColor.ShowDialog = DialogResult.OK Then
            rainbow2 = ColorTranslator.ToHtml(cdColor.Color) 'from a color value to a string name
            rainbowLine = ColorTranslator.FromHtml(rainbow2) 'back to a color so its usable up there
            radPen.BackColor = rainbowLine 'change background to selected color
        End If 'all this makes the color dialog box work
    End Sub

    Private Sub cboPen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPen.SelectedIndexChanged
        'This is to set the pen size.
        penLine = cboPen.SelectedIndex + 1
    End Sub

    Private Sub cboErase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboErase.SelectedIndexChanged
        'This is Today set the Erase size.
        penEraser = cboErase.SelectedIndex + 1
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        'This is for the Eraser
        If cdColor.ShowDialog = DialogResult.OK Then
            rainbow2 = ColorTranslator.ToHtml(cdColor.Color) 'from a color value to a string name
            rainbowEraser = ColorTranslator.FromHtml(rainbow2) 'back to a color so its usable up there
            radEraser.BackColor = rainbowEraser ' change background to the selected color

        End If 'all this makes the color dialog box work
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        'This saves the file 
        If strFileName = String.Empty Then                           'This checks to see if a file name has been created 
            If sfdSaveFile.ShowDialog() = DialogResult.OK Then       'Checks to see if the user clicks ok.
                pbxPicture.Image.Save(sfdSaveFile.FileName, Imaging.ImageFormat.Jpeg)  'This saves the image.
                strFileName = sfdSaveFile.FileName                   'Puts a file name into the program so strFileName does not = String.Empty anymore.
                blnIsChanged = False                                 'Changes the isChanged to false.
            End If

        Else
            pbxPicture.Image.Save(strFileName, Imaging.ImageFormat.Jpeg)  'If a file name has already been created it overwrite the current save.
            blnIsChanged = False
        End If
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        'This does a save as to the file
        If sfdSaveFile.ShowDialog() = DialogResult.OK Then
            pbxPicture.Image.Save(sfdSaveFile.FileName, Imaging.ImageFormat.Jpeg)
            strFileName = sfdSaveFile.FileName
            blnIsChanged = False
        End If
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        'This will check to see if any changes have been made since the last save and if so ask if the user wants to save them. Then goes back to the main page form.
        If blnIsChanged = True Then         'Checks to see if anything has been changed since last save.
            Dim result As Integer = MessageBox.Show("The current changes are not saved." & "Do you wish to save them?", "Confirm save", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then         'Checks to see if the user clicks yes
                If strFileName = String.Empty Then
                    If sfdSaveFile.ShowDialog() = DialogResult.OK Then
                        pbxPicture.Image.Save(sfdSaveFile.FileName, Imaging.ImageFormat.Jpeg)
                        strFileName = sfdSaveFile.FileName
                        blnIsChanged = False
                        MainPage.Show()
                        Me.Close()
                    End If
                Else
                    pbxPicture.Image.Save(strFileName, Imaging.ImageFormat.Jpeg)
                    blnIsChanged = False
                    MainPage.Show()
                    Me.Close()
                End If

            ElseIf result = DialogResult.No Then
                blnIsChanged = False
                MainPage.Show()
                Me.Close()
            End If

        Else
            MainPage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'This will check to see if any changes have been made since the last save and if so ask if the user wants to save them. Then it closes the program.
        If blnIsChanged = True Then
            Dim result As Integer = MessageBox.Show("The current changes are not saved." & "Do you wish to save them?", "Confirm save", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                If strFileName = String.Empty Then
                    If sfdSaveFile.ShowDialog() = DialogResult.OK Then
                        pbxPicture.Image.Save(sfdSaveFile.FileName, Imaging.ImageFormat.Jpeg)
                        strFileName = sfdSaveFile.FileName
                        MainPage.Close()
                    End If
                Else
                    pbxPicture.Image.Save(strFileName, Imaging.ImageFormat.Jpeg)
                    MainPage.Close()
                End If
            ElseIf result = DialogResult.No Then
                MainPage.Close()
            End If

        Else
            MainPage.Close()
        End If
    End Sub

    Private Sub ColoringPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'This will check to see if any changes have been made since the last save and if so ask if the user wants to cancel the closing of the form.
        If blnIsChanged = True Then
            If MessageBox.Show("The current changes have not been saved." & "Do you wish to discard them?", "Confirm", MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
                MainPage.Show()
            Else
                e.Cancel = True
            End If
        Else
            MainPage.Show()
        End If
    End Sub
End Class