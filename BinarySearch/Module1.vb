Module Module1

    Sub Main()

        Dim items() As String = {"blue", "cyan", "green", "magenta", "red", "yellow"}
        Dim first As Integer
        Dim last As Integer
        Dim mid As Integer
        Dim found As Boolean
        Dim itemToFind As String

        Do
            first = 0
            last = items.Length - 1
            found = False

            Console.Write("What colour do you want to find? ")
            itemToFind = Console.ReadLine

            While first <= last And found = False
                mid = (first + last) \ 2
                If itemToFind = items(mid) Then
                    found = True
                Else
                    If itemToFind < items(mid) Then
                        last = mid - 1
                    Else
                        first = mid + 1
                    End If
                End If
            End While

            If found = True Then
                Console.WriteLine("Colour {0} was found at position {1}", itemToFind, mid)
            Else
                Console.WriteLine("Colour {0} was not found", itemToFind)
            End If

            Console.ReadLine()
        Loop




    End Sub

End Module
