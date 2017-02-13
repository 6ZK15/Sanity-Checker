Public NotInheritable Class SplashScreen1

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'Application title
        ApplicationTitle.Text = "Sanity Checker"
        ' Version
        Version.Text = "CIS 497 | Senior Project | Fall 2016"
        'Copyright info
        ' Copyright.Text = "Copyright © 2016"
    End Sub

End Class
