<Query Kind="Program" />

#region Load WebColors xml file

void Main()
{
	var root = Path.GetDirectoryName(Util.CurrentQueryPath);
	var upPath = @"\..\";
	var path = @"WebColorsB.xml";
	var webColors = XElement.Load(root + upPath + path);
	#endregion
	// My code challenge solution
	
	var q = from c in webColors.Elements()
			let isValid = IsValidHex(c.Element("Hex").Value)
			where c.Attribute("color-name").Value.Contains(".") ||
			isValid == false
			orderby isValid
			select c;
			
	q.Dump();
}

// You can define other methods, fields, classes and namespaces here
public bool IsValidHex(string candidate)
{
	return int.TryParse(candidate, System.Globalization.NumberStyles.HexNumber, null, out _);
}

