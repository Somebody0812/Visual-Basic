imports System.Console
Public Module Module1

  Dim Queue(50) As String
  Dim HeadPointer As Integer = -1
  Dim TailPointer As Integer = 0
  
  Sub Enqueue(Data As String)
    
    If TailPointer > 50 Then
      WriteLine("Queue is full.")
    
    Else
      Queue(TailPointer) = Data
      TailPointer += 1
      If HeadPointer = -1 Then
        HeadPointer = 0
        
      End If 
      
    End If
  End Sub

  Function Dequeue()
    If HeadPointer = -1 Or HeadPointer = TailPointer Then
      WriteLine("Queue is empty.")
      return "Empty"
    End If
    
    HeadPointer += 1
    return Queue(HeadPointer-1)
  End Function
  
  Sub Main(args() As String)
    Enqueue("Test")
    Writeline(Dequeue())
  End Sub
End Module
