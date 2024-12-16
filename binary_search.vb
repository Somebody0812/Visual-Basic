imports System.Console

Public Module Program
	Public Sub Main(args() As string)
	  
		Dim List(10) As Integer
		Dim Index, Upper, Lower As Integer
		Dim Found As Boolean = False
		
		For Index = 1 TO 10
		  List(Index) = ReadLine()
		Next
		
		Dim Search As Integer = ReadLine()
		Index = 1
		Upper = 11
		Lower = 1
		
		Do
		  Index = Int((Upper+Lower)/2)
		  If Search = List(Index) Then
		    Found = True
		  End If
		  If Search > List(Index) Then
		    Lower = Index + 1
		  End If
		  If Search < List(Index) Then
		    Upper = Index - 1
		  End If
		Loop Until (Found = True) Or (Lower = Upper)
		
		If Found = True Then
		  Writeline("Item found at " & Index)
		Else
		  Writeline("Item not found")
		End If
		  
	End Sub
End Module
