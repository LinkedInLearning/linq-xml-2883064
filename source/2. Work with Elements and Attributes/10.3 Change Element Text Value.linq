<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// returns the XML data (including the element tags)
// Elements can contain content, or other elements
var monsterElement = collectibles.Element("Card").Element("Monster");

monsterElement.Dump();
monsterElement.Value.Dump("Monster value");
// change the value
monsterElement.Value= "Replace Everything";

monsterElement.Dump("Modified Monster element");
monsterElement.Value.Dump("Modified Monster value");

