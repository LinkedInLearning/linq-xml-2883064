<Query Kind="Program" />

void Main()
{
	// I'll use a function to evaluate the valid HexValue
	// If you are using LINQPad choose the C# Program template
	// from the Language dropdown
}
public bool IsValidHex(string candidate)
{
	return false;
}
// Challenge:

// use the WebColorsB.xml file as the data source

// The WebColors data has some invalid data 
// HexValue element.

// 1.
// Write a query expression that finds ColorName values that contains [full stop, period] (".")

// 2.
// Also find HexValues that are not valid hexadecimal values (0-9, A, B, C, D, E, F)
// FFFF00 is valid
// FF34T3 is invalid because it has an invalid char (T)

// Combine both these tests into a single query expression!
