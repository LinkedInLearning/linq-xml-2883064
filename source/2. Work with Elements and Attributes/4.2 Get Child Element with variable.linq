<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// get child element

var monsterElement = collectibles.Element("Card").Element("Monster");

monsterElement.Dump("Monster elements");

monsterElement.Element("EyeCount").Dump("EyeCount only");
monsterElement.Element("Antenna").Dump("Antenna only");