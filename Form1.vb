Public Class Form1
    Dim zodiac() As String = {"Aries", "Taurus", "Gemini", "Cancer",  'Variable name zodiac
                              "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius",
                              "Capricorn", "Aquarius", "Pisces"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer         'Varible age, months, days
        Dim months As String = Format(DateTimePicker1.Value, "MMMM")
        Dim days As Integer = Format(DateTimePicker1.Value, "dd")


        age = DateDiff(DateInterval.Year, DateTimePicker1.Value, DateTimePicker2.Value)
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Age : " & age).ToString()


        Select Case months     'Condition
            Case "January"
                If days >= 1 And days <= 19 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(9))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(10))
                End If
            Case "February"
                If days >= 1 And days <= 18 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(10))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(11))
                End If
            Case "March"
                If days >= 21 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(0))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(11))
                End If
            Case "April"
                If days >= 1 And days <= 19 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(0))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(1))
                End If
            Case "May"
                If days >= 1 And days <= 20 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(1))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(2))
                End If
            Case "June"
                If days >= 1 And days <= 21 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(2))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(3))
                End If
            Case "July"
                If days >= 1 And days <= 22 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(3))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(4))
                End If
            Case "August"
                If days >= 1 And days <= 22 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(4))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(5))
                End If
            Case "September"
                If days >= 1 And days <= 22 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(5))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(6))
                End If
            Case "October"
                If days >= 1 And days <= 22 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(6))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(7))
                End If
            Case "November"
                If days >= 1 And days <= 21 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(7))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(8))
                End If
            Case "December"
                If days >= 1 And days <= 21 Then
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(8))
                Else
                    ListBox1.Items.Add("Zodiac Sign :" & zodiac(9))
                End If
        End Select

    End Sub

End Class
