'Patricia Hanus
'151203
'Matching Index And Element
'_____________________________________________________________________________
Public Class Form1
    Dim numbers(9) As Integer
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Me.lstNumbers.Items.Clear()

        For index As Integer = 0 To 9
            numbers(index) = RndInt(0, (numbers.Length - 1))
        Next

        Call DisplayArray(Me.lstNumbers, numbers)
        Call MatchNums(numbers, Me.lblMatch)

    End Sub
    '********************************************************************************************
    'RndInt
    'Returns a random integer between max and min
    '
    'post:  A number is returned
    '********************************************************************************************
    Function RndInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return Int((max - min + 1) * Rnd() + min)
    End Function
    '********************************************************************************************
    'DisplayArray
    'Displays the contents of the passed array in the passed list box values index
    '
    'post:  Array results displayed in list box 
    '********************************************************************************************
    Sub DisplayArray(ByRef lstbox As ListBox, ByRef array() As Integer)
        For index As Integer = 0 To array.Length - 1
            lstbox.Items.Add(index & vbTab & array(index))
        Next
    End Sub
    '********************************************************************************************
    'MatchNums
    'Checks for matching index and element
    '	
    'post: Returns number of matching index/element pairs
    '********************************************************************************************
    Sub MatchNums(ByRef array() As Integer, ByRef label As Label)
        Dim numMatch As Integer = 0
        For i As Integer = 0 To array.Length - 1
            If array(i) = i Then
                numMatch += 1
            End If
        Next
        label.Text = numMatch & " elements matched their index."
    End Sub
End Class
