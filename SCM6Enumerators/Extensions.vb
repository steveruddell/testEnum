Imports System.Runtime.CompilerServices 


Namespace SCM6Enums

	Public Module Extensions

		<Extension()>
		Public Function IncludesLoginMethod(ByVal loginMethod As eLoginMethodFlag, ByVal testMethod As eLoginMethodFlag) As Boolean
			If testMethod = eLoginMethodFlag.None Then
				Throw New ArgumentException("A value of eLoginMethodFlag could equal eLoginMethodFlag.None, but it may not *include* eLoginMethodFlag.None and testing for eLoginMethodFlag.None is invalid.", "testMethod")
			End If

			' eLoginMethodFlag is a Bit field, use bitwise And operator then compare to the test value
			Return (loginMethod And testMethod) = testMethod
		End Function

		<Extension()>
		Public Sub AddLoginMethod(ByRef loginMethod As eLoginMethodFlag, ByVal newMethod As eLoginMethodFlag)
			' eLoginMethodFlag is a Bit field, use bitwise operator to add the value
			loginMethod = loginMethod Or newMethod
		End Sub

		<Extension()>
		Public Sub RemoveLoginMethod(ByRef loginMethod As eLoginMethodFlag, ByVal removeMethod As eLoginMethodFlag)
			' eLoginMethodFlag is a Bit field, use bitwise operator to remove the value
			loginMethod = loginMethod And (Not removeMethod)
		End Sub

	End Module


End Namespace
