Public Class MainPage
    'Coloring book Main Page.
    'The page where you pick what you want to do.
    'Last Modified 4/30/19
    'Created by Brian Nicewander and Emily Gerhardt

    Public picture As Image
    Public picture2 As Image
    Public newRatio, pictureRatio As Decimal

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        'This will take you to the Coloring Page form and show the Car picture
        picture = My.Resources.car                      'Tells the program what picture to put into the coloring page form picture box.
        picture2 = New Bitmap(My.Resources.car, New Size(600 * ResizeIt(), 600))
        ColoringPage.pbxPicture.Image = picture2
        ColoringPage.Show()                             'Shows the coloring page form.
        Me.Hide()                                       'Hides the Main Page form.
    End Sub

    Private Sub btnDragon_Click(sender As Object, e As EventArgs) Handles btnDragon.Click
        'This will take you to the Coloring Page form and show the Dragon picture
        picture = My.Resources.Dragon
        picture2 = New Bitmap(picture, New Size(600 * ResizeIt(), 600))
        ColoringPage.pbxPicture.Image = picture2
        ColoringPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnFish_Click(sender As Object, e As EventArgs) Handles btnFish.Click
        'This will take you to the Coloring Page form and show the Fish picture
        picture = My.Resources.Fish
        picture2 = New Bitmap(picture, New Size(600 * ResizeIt(), 600))
        ColoringPage.pbxPicture.Image = picture2
        ColoringPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnHouse_Click(sender As Object, e As EventArgs) Handles btnHouse.Click
        'This will take you to the Coloring Page form and show the House picture
        picture = My.Resources.House
        picture2 = New Bitmap(picture, New Size(600 * ResizeIt(), 600))
        ColoringPage.pbxPicture.Image = picture2
        ColoringPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnMinions_Click(sender As Object, e As EventArgs) Handles btnMinions.Click
        'This will take you to the Coloring Page form and show the Minions picture
        picture = My.Resources.Minion
        picture2 = New Bitmap(picture, New Size(600 * ResizeIt(), 600))
        ColoringPage.pbxPicture.Image = picture2
        ColoringPage.Show()
        Me.Hide()
    End Sub

    Private Sub bntWolf_Click(sender As Object, e As EventArgs) Handles bntWolf.Click
        'This will take you to the Coloring Page form and show the Wolf picture
        picture = My.Resources.wolf
        picture2 = New Bitmap(picture, New Size(600 * ResizeIt(), 600))
        ColoringPage.pbxPicture.Image = picture2
        ColoringPage.Show()
        Me.Hide()
    End Sub

    Private Sub mnuShow_Click(sender As Object, e As EventArgs) Handles mnuShow.Click
        'This will take you to the slide show form
        SlideShow.Show()                    'This will show the SlideShow form.
        Me.Hide()                           'This will Hide this form.
    End Sub

    Private Sub mnuLoad_Click(sender As Object, e As EventArgs) Handles mnuLoad.Click
        'This will load a previously saved coloring page on the coloringPage form
        If ofdOpenFile.ShowDialog() = DialogResult.OK Then
            picture = Image.FromFile(ofdOpenFile.FileName)
            ' ColoringPage.strFileName = ofdOpenFile.FileName
            picture2 = New Bitmap(picture, New Size(600 * ResizeIt(), 600))
            ColoringPage.pbxPicture.Image = picture2
            ColoringPage.Show()
            Me.Hide()
            ofdOpenFile.FileName = ""                   'This sets the ofdOpenFile filename to nothing.

            'If the use clicks cancel. 
        Else
            ofdOpenFile.Dispose()                           'it dispose of the openFileialog.
        End If
    End Sub

    Function Ratio() As Decimal 'Helps set the width and height.
        pictureRatio = picture.Width / picture.Height
        Return pictureRatio
    End Function

    Function ResizeIt() As Decimal 'resizes the cool picturebox to maintain the ratio
        ColoringPage.pbxPicture.Height = 600
        ColoringPage.pbxPicture.Width = 600
        pictureRatio = picture.Width / picture.Height
        newRatio = 1
        Do While newRatio > pictureRatio  ' picture width greater than the height
            ColoringPage.pbxPicture.Width = ColoringPage.pbxPicture.Width - 1
            newRatio = ColoringPage.pbxPicture.Width / ColoringPage.pbxPicture.Height
        Loop
        Do While newRatio < pictureRatio  ' picture width greater than the height
            ColoringPage.pbxPicture.Width = ColoringPage.pbxPicture.Width + 1
            newRatio = ColoringPage.pbxPicture.Width / ColoringPage.pbxPicture.Height
        Loop
        Return newRatio
    End Function

    Private Sub btnYourPic_Click(sender As Object, e As EventArgs) Handles btnYourPic.Click
        'This is so the user can put in their own coloring page.       
        If ofdOpenFile.ShowDialog() = DialogResult.OK Then
            picture = Image.FromFile(ofdOpenFile.FileName)
            picture2 = New Bitmap(picture, New Size(600 * ResizeIt(), 600))
            ColoringPage.pbxPicture.Image = picture2
            ColoringPage.Show()
            Me.Hide()
            ofdOpenFile.FileName = ""

        Else
            ofdOpenFile.Dispose()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'This closes the program
        Me.Close()
    End Sub
End Class
