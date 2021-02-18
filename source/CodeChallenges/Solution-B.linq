<Query Kind="Statements" />

#region Load WebColors xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"WebColors.xml";
var webColors = XElement.Load(root + upPath + path);
#endregion

// My code challenge solution

var q = from c in webColors.Elements()
		where c.Element("Saturation").Value == ""
		// && String.IsNullOrEmpty( c.Element("Hue").Value)

		select c;

q.Dump();
