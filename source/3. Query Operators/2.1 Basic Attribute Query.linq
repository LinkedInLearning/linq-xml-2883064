<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use the LINQ Query operators and syntax
// get attributes
collectibles.Element("Card").Dump();
var q1 = from att in collectibles.Element("Card").Attributes()
		 select att;

q1.Dump();



