<Query Kind="Program" />

#region Load WebColors xml file

void Main()
{
	var root = Path.GetDirectoryName(Util.CurrentQueryPath);
	var upPath = @"\..\";
	var path = @"WebColorsA.xml";
	var webColors = XElement.Load(root + upPath + path);
	#endregion
	
	
	var q = from color in webColors.Elements()
			select color;


	foreach (var color in q)
	{
		// attributes to Element

		XElement colorNameElement = new XElement("ColorName");
		colorNameElement.Value = (color.Attribute("color-name").Value);
		color.Add(colorNameElement);
		
		XElement colorFamilyElement = new XElement("ColorFamily");
		colorFamilyElement.SetValue(color.Attribute("color-family").Value);
		color.Add(colorFamilyElement);
		color.ReplaceAttributes();
		// move to parent element
		XElement rgbElement = new XElement("RGB");
		color.Add(rgbElement);
		MoveToParentElement(rgbElement, color, "Red");
		MoveToParentElement(rgbElement, color, "Blue");
		MoveToParentElement(rgbElement, color, "Green");

		XElement hslElement = new XElement("HSL");
		color.Add(hslElement);

		MoveToParentElement(hslElement, color, "Hue");
		MoveToParentElement(hslElement, color, "Saturation");
		MoveToParentElement(hslElement, color, "Lightness");

	
	}
	
	q.Dump();
}

 private void MoveToParentElement(XElement parent, XElement currentElement,string elementName)
{
	XElement existing = currentElement.Element(elementName);
	parent.Add(existing);
	existing.Remove();
}
// You can define other methods, fields, classes and namespaces here
