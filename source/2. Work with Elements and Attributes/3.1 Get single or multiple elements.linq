<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// to simplify examples in the remainder of the course
// we'll use the non schema file.

// Element returns a single element

XElement firstCard = collectibles.Element("Card");
firstCard.Dump();

// Elements returns a collection of child elements
collectibles.Elements("Card").Dump();
