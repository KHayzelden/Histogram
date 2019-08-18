Module Module1

    Sub Main()

        Dim InputGrade, First, HighSecond, LowSecond, Third, NumStudents, Total, Average, NumPerfect As Integer

        Console.WriteLine("Enter Grades:")
        InputGrade = Console.ReadLine()

        While (InputGrade <= 100)

            Total += InputGrade
            NumStudents += 1

            If (InputGrade = 100) Then
                NumPerfect += 1
            End If

            If (InputGrade >= 70) Then
                First += 1
            ElseIf (InputGrade >= 40) Then
                HighSecond += 1
            ElseIf (InputGrade >= 30) Then
                LowSecond += 1
            Else
                Third += 1
            End If

            InputGrade = Console.ReadLine()

        End While

        Average = Total / NumStudents

        Console.WriteLine("First: {0}, High Second: {1}, Low Second: {2}, Third: {3}", First, HighSecond, LowSecond, Third)
        Console.WriteLine("Number of Students: {0}, Number of 100%s: {1}, Average: {2}", NumStudents, NumPerfect, Average)

        Console.Write(vbCrLf)
        Console.Write("00 - 29     30 - 39     40 - 69     70 - 100")
        Console.Write(vbCrLf)

        While (First > 0 Or HighSecond > 0 Or LowSecond > 0 Or Third > 0)

            Console.Write("   ")

            If (Third > 0) Then
                Console.Write("*")
                Third -= 1
            Else
                Console.Write(" ")
            End If
            Console.Write("           ")

            If (LowSecond > 0) Then
                Console.Write("*")
                LowSecond -= 1
            Else
                Console.Write(" ")
            End If
            Console.Write("           ")

            If (HighSecond > 0) Then
                Console.Write("*")
                HighSecond -= 1
            Else
                Console.Write(" ")
            End If
            Console.Write("           ")

            If (First > 0) Then
                Console.Write("*")
                First -= 1
            Else
                Console.Write(" ")
            End If

            Console.Write(vbCrLf)

        End While

        InputGrade = Console.Read()

    End Sub

End Module
