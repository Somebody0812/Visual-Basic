imports System.Console

Public Module Program
	Public Sub Main(args() As string)
	  
	    Dim List() As Integer = New Integer() {4, 2, 8, 17, 9, 1, 32, 6, 6, 23}
	    Dim Boundary As Integer = 8
	    Dim NoSwaps As Boolean = False
	    Dim Temp, Index As Integer
	    
	    While NoSwaps = False
	      
	      NoSwaps = True
	      
	      For Index = 0 to Boundary
	        If List(Index) > List(Index + 1)
	          
	          Temp = List(Index)
	          List(Index) = List(Index + 1)
	          List(Index + 1) = Temp
	          NoSwaps = False
	          
	        End If
	      Next
	      
	      Boundary = Boundary - 1
	    End While
	  
	    For Index = 0 to 9
	      WriteLine(List(Index))
	    Next Index
    
	End Sub
End Module
