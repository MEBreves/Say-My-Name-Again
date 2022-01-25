'Miranda Breves
'RCET0265
'Spring 2022
'Say My Name Again
'url

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

        Console.Read()

    End Sub

End Module
