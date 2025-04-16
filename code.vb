Public Class Form1
    Async Function TextAnimation(ByVal TextMessage As String) As Task                                       'Function that plays the text animation
        Dim i, TotalCharacters As Integer                                                                   'Declaring variables

        i = 1                                                                                               'i being set to 1 so that variable TextMessage starts at the first character
        TotalCharacters = Len(TextMessage)                                                                  'Gets the amount of characters of the text

        For i = 1 To TotalCharacters                                                                        'Plays the actual animation
            "Your message label" = Mid$(TextMessage, 1, i)
            PlaySound("Your audio file in .wav format")
            Await Task.Delay(150)                                                                           'Delays so its visible to the human eye
        Next

        Await Task.Delay(50)
        "Your activation button".Enabled = True                                                             'Turns button back on after 50 milliseconds to prevent spam
    End Function

    Function PlaySound(filepath As String)                                                                  'Plays audios
        My.Computer.Audio.Play(filepath, AudioPlayMode.Background)
    End Function

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles "Your activation button".Click
        TextAnimation("Your text input")                                                                     'Inputs variable into the function so it can be played
        "Your activation button".Enabled = False                                                              'Anti spam feature by disabling the button until action is completed
    End Sub
End Class

'Make sure to change "Your message label/text input/activation button to the ones you are using
