<Query Kind="Statements" />

#region Load WebColors xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"WebColorsB.xml";
var webColors = XElement.Load(root + upPath + path);
#endregion

// My code challenge solution

var q = from color in webColors.Elements()
				where String.IsNullOrEmpty(color.Element("Hue").Value)
				// && color.Element("Saturation").Value == ""

				select color;

q.Dump();
