
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_550

	''' <summary>
	'''     Indicates whether the character at the specified position in a specified string is categorized as a lowercase
	'''     letter.
	''' </summary>
	''' <param name="s">A string.</param>
	''' <param name="index">The position of the character to evaluate in .</param>
	''' <returns>true if the character at position  in  is a lowercase letter; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsLower(s As [String], index As Int32) As [Boolean]
		Return [Char].IsLower(s, index)
	End Function
End Module


