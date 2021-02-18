<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// returns the XML data (including the element tags)
collectibles.Element("Card").Element("Slogan").Dump("Slogan element");

// use .Value to return the element data only.
collectibles.Element("Card").Element("Slogan").Value.Dump("Slogan value");