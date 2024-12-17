Public Module Program
	Dim StackData(10) As Integer
	Dim StackPointer As Integer = 0
	
	Sub DisplayArray()
	  Dim Index as Integer = 0
	  WriteLine("Pointer: " & StackPointer)
	  For Index = 0 to 9
	    Writeline(StackData(Index))
	  Next
	End Sub
	
	Function Push(Number As Integer)
	  If StackPointer = 10 Then
	    return False
	  End If
	  
	  StackData(StackPointer) = Number
	  StackPointer += 1
	  return True
	End Function
	
	Function Pop()
	  If StackPointer = 0
	    return -1
	  End If
  
    StackPointer = StackPointer - 1
    return StackData(StackPointer)
	End Function

  Sub Main(args() As String)
    
    Dim Index As Integer
    Dim InputNum As Integer
    Dim Flag as Boolean
    
    For Index = 0 to 10
      InputNum = Readline()
      
      Flag = Push(InputNum)
      If Flag = True Then
        Writeline(InputNum & " was added to the stack")
      Else
        Writeline("Stack is full, cannot add " & InputNum)
        
      End If
    Next
    
    DisplayArray()
  End Sub
End Module
