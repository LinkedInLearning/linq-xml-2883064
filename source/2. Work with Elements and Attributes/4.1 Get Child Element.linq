<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion


// get child element
collectibles.Element("Card").Dump("Card");
collectibles.Element("Card").Element("Slogan").Dump("Slogan");
collectibles.Element("Card").Element("Monster").Element("Antenna").Dump("Antenna");