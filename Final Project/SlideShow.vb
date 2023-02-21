Public Class SlideShow
    'Coloring book Slideshow page.
    'The page where you can view a slideshow of previously colored pages.
    'Last Modified 4/30/19
    'Created by Brian Nicewander and Emily Gerhardt

    Dim time As Decimal = 2                 'Is the default time for the timer
    Dim Imagepicture As Integer

    Private Sub SlideShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This tells the picturebox what picture to start with.
        pbxSlideShow.Image = My.Resources.garfield_car
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'This will take you to the next picture in the slide show
        Imagepicture = Imagepicture + 1                         'This is how many picture to move at a time.
        If Imagepicture > 6 Then Imagepicture = 0               'If the imgepicture gets to 6 go back to 0

        Select Case Imagepicture
            Case 0
                pbxSlideShow.Image = My.Resources.garfield_car
            Case 1
                pbxSlideShow.Image = My.Resources.dergon
            Case 2
                pbxSlideShow.Image = My.Resources.Blushy_Fish
            Case 3
                pbxSlideShow.Image = My.Resources.HouseColoringPage
            Case 4
                pbxSlideShow.Image = My.Resources.MinionColoringPage
            Case 5
                pbxSlideShow.Image = My.Resources.wolfColoringPage
            Case 6
                pbxSlideShow.Image = My.Resources.BunnyColoringPage
        End Select
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'This will take you to the previous picture.
        Imagepicture = Imagepicture - 1
        If Imagepicture < 0 Then Imagepicture = 6

        Select Case Imagepicture
            Case 0
                pbxSlideShow.Image = My.Resources.garfield_car
            Case 1
                pbxSlideShow.Image = My.Resources.dergon
            Case 2
                pbxSlideShow.Image = My.Resources.Blushy_Fish
            Case 3
                pbxSlideShow.Image = My.Resources.HouseColoringPage
            Case 4
                pbxSlideShow.Image = My.Resources.MinionColoringPage
            Case 5
                pbxSlideShow.Image = My.Resources.wolfColoringPage
            Case 6
                pbxSlideShow.Image = My.Resources.BunnyColoringPage
        End Select
    End Sub

    Private Sub chkSlide_CheckedChanged(sender As Object, e As EventArgs) Handles chkSlide.CheckedChanged
        'This checks the checkbox and controls the timer
        If chkSlide.Checked = True Then            'Checks to see if the chkslide has a checkmark in it or not.
            Try
                time = CDec(txtTime.Text)
                tmrTime.Interval = time * 1000            'multiplied by 1000 because its in milliseconds
                tmrTime.Enabled = True                    'If the chkslide has a check mark then enable the timer.
            Catch ex As Exception
                MessageBox.Show("Please put in a number!")
                chkSlide.Checked = False
            End Try

        Else
            tmrTime.Enabled = False                   'If the chkslide does not have a check mark then the timer is not enabled.
        End If
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        'Calls the button next to run the slide show.
        btnNext_Click(sender, e)
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        'Thiks will take you back to the Maine Page form.
        Me.Close()                      'This closes this form.
        MainPage.Show()                 'This shows the mainpage form.       
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'This will close the program.
        MainPage.Close()
    End Sub

    Private Sub SlideShow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'This will close the program.
        MainPage.Show()
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged
        'This checkes to see if the text changes.
        tmrTime.Enabled = False
        chkSlide.Checked = False
    End Sub
End Class