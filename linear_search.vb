imports System.Console

Public Module Program
	Public Sub Main(args() As string)
	  
		Dim List(5) As Integer
		Dim Found as Boolean
		Dim UpperBound,LowerBound as Integer
		Dim Index As Integer
		Dim Search As Integer
		
		For Index = 1 TO 5
		  List(Index) = ReadLine()
		Next
		
		For Index = 1 TO 5
		  Writeline(List(Index))
		Next
		
		Index = 1
		UpperBound = 5
		Search = ReadLine()
		
		While Found = False and Index <= UpperBound
		
		  If List(Index) = Search Then
		    Found = True
		  
		  Else
		    Index = Index + 1
		    
		  End If
		
		End While
		
		If Found = True Then
		  Writeline("Item found")
		Else
		  Writeline("Item not found")
		End If
		
	End Sub
End Module