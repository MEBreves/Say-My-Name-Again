'Miranda Breves
'RCET0265
'Spring 2022
'Say My Name Again
'https://github.com/MEBreves/Say-My-Name-Again

Option Strict On
Option Explicit On

Module SayMyNameAgain

    Sub Main()

        'Declaring Variables
        Dim userName As String


        'Getting name from user
        Console.WriteLine("What's your name?")
        userName = Console.ReadLine()
        Console.WriteLine()

        'Deciding which names to respond to
        If userName = "Emily" Or userName = "Joe" Then
            Console.WriteLine("Hello, " & userName & "!")
            Console.WriteLine()
        ElseIf userName = "Miranda" Then
            Console.WriteLine("Greetings, Master.")
            Console.WriteLine()
        Else
            Console.WriteLine("This is a mere peasant.")
            Console.WriteLine()
        End If

        'Letting the user see the output on the console before ending
        Console.Read()

    End Sub

End Module
