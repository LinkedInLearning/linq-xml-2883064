<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// returns the XML data (including the element tags)
var sloganElement = collectibles.Element("Card").Element("Slogan");
sloganElement.Dump("Slogan element");

// use .Value to return the element data only.
sloganElement.Value.Dump("Slogan value");

// change the value

sloganElement.SetElementValue("NewElement","New Value");

sloganElement.Dump("Slogan element");
sloganElement.Value.Dump("Modified value");