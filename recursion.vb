Function SearchValue(Root As Integer, ValueToFind As Integer)
	If Root = -1 Then
		Return -1
	Else
		If ArrayNodes(Root, 1) = ValueToFind Then
			Return Root
		Else
			If ArrayNodes(Root, 1) = -1 Then
				Return -1
			End If
		End If
	End If

	If ArrayNodes(Root, 1) > ValueToFind Then
		Return SearchValue(ArrayNodes(Root, 0), ValueToFind)
	End If

	If ArrayNodes(Root, 1) < ValueToFind Then
		Return SearchValue(ArrayNodes(Root, 2), ValueToFind)
	End If
End Function
