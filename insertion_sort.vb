imports System.Console
Public Module Program
  Sub Main()
    
    Dim MyList(10) As Integer
    MyList = New Integer() {10, 5, 6, 7, 1, 12, 13, 15, 21, 8}
    Dim ListSize As Integer = 10
    Dim Index As Integer = 0
    Dim ValueToInsert As Integer
    Dim HolePosition As Integer
    
    For Index = 0 to ListSize -1
      ValueToInsert = MyList(Index)
      HolePosition = Index
      
      While (HolePosition > 0) AndAlso (MyList(HolePosition - 1) > ValueToInsert)
        MyList(HolePosition) = MyList(HolePosition - 1)
        HolePosition = HolePosition - 1
        
      End While
      MyList(HolePosition) = ValueToInsert
    Next
    
    For Index = 0 to 9
      Writeline(MyList(Index))
    Next
    
    
  End Sub
End Module
