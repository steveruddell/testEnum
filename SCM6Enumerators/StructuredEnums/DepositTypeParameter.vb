Namespace SCM6Enums.StructuredEnums

Public Class DepositTypeParameter
    Public ReadOnly Property Id As Integer
    Public ReadOnly Property Name As String
    Public ReadOnly Property DefaultValue As String
    Public ReadOnly Property DepositTypeId As Integer
    Public ReadOnly Property ConfigValueTypeId As Integer

    public Sub New(ByVal id As Integer, ByVal name As String, ByVal defaultValue As String, ByVal depositTypeId As Integer, ByVal configValueTypeId As Integer)
        Me.Id = id
        Me.Name = name
        Me.DefaultValue = defaultValue
        Me.DepositTypeId = depositTypeId
        Me.ConfigValueTypeId = configValueTypeId
    End Sub
        
	''' <summary>
	''' Allows for the casting of an int type to a DepositTypeParameter
	''' </summary>
	Public Shared Narrowing Operator CType(id As Integer) As DepositTypeParameter
		if ([Enum].IsDefined(GetType(DepositTypeParameter), id))
            Return CType(id, DepositTypeParameter)
		End If

		Throw New InvalidCastException("The value " + id.ToString() + " is not a valid DepositTypeParameter")
	End Operator

	''' <summary>
	''' Allows for the casting of a DepositTypeParameter to an integer type
	''' </summary>
	Public Shared Narrowing Operator CType(value As DepositTypeParameter) As Integer
		Return value.Id
	End Operator

End Class

end namespace