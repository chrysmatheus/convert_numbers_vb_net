Module Module1
    Dim result As String
    Dim i As Integer
    Public Function convertForRom(num As Integer) As String
        Dim arabic(12) As Integer
        Dim roman(12) As String

        result = ""
        arabic(0) = 1000
        arabic(1) = 900
        arabic(2) = 500
        arabic(3) = 400
        arabic(4) = 100
        arabic(5) = 90
        arabic(6) = 50
        arabic(7) = 40
        arabic(8) = 10
        arabic(9) = 9
        arabic(10) = 5
        arabic(11) = 4
        arabic(12) = 1
        roman(0) = "M"
        roman(1) = "CM"
        roman(2) = "D"
        roman(3) = "CD"
        roman(4) = "C"
        roman(5) = "XC"
        roman(6) = "L"
        roman(7) = "XL"
        roman(8) = "X"
        roman(9) = "IX"
        roman(10) = "V"
        roman(11) = "IV"
        roman(12) = "I"

        i = 0
        Do While num
            Do While num >= arabic(i)
                num = num - arabic(i)
                result = result + roman(i)
            Loop
            i = i + 1
        Loop

        Return result
    End Function
    Private Enum RomanDigit
        I = 1
        V = 5
        X = 10
        L = 50
        C = 100
        D = 500
        M = 1000
    End Enum

    Public Function convertForArabic(input As String) As Integer
        input = input.ToUpper().Trim()
        If input = "N" Then
            Return 0
        End If

        Dim ptr As Integer = 0
        Dim values As New ArrayList()
        Dim maxDigit As Integer = 1000
        While ptr < input.Length
            Dim numeral As Char = input(ptr)
            Dim digit As Integer = CInt([Enum].Parse(GetType(RomanDigit), numeral.ToString()))

            Dim nextDigit As Integer = 0
            If ptr < input.Length - 1 Then
                Dim nextNumeral As Char = input(ptr + 1)
                nextDigit = CInt([Enum].Parse(GetType(RomanDigit), nextNumeral.ToString()))

                If nextDigit > digit Then
                    maxDigit = digit - 1
                    digit = nextDigit - digit
                    ptr += 1
                End If
            End If

            values.Add(digit)
            ptr += 1
        End While

        Dim total As Integer = 0
        For Each digit As Integer In values
            total += digit
        Next

        Return total
    End Function
End Module
