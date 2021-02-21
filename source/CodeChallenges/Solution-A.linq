<Query Kind="Statements" />

#region Load WebColors xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"WebColorsA.xml";
var allElements = XElement.Load(root + upPath + path);
#endregion

// My code challenge solution
var q = from color in allElements.Elements()

				select
				new
				{
					ColorName = color.Attribute("color-name").Value,
					Formula = $"rgb ({color.Element("Red").Value}, {color.Element("Green").Value}, {color.Element("Blue").Value})"
				};


q.Dump();