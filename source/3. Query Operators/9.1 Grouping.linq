<Query Kind="Statements" />

#region Load BigStarCollectibles-MissingXML xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-MissingXML.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

var q1 = from color in collectibles.Elements()
		 group color by color.Attribute("team-name").Value; // key selector

q1.Dump();