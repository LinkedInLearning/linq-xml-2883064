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
var eyeElement = collectibles.Element("Card").Element("Monster").Element("EyeCount");

eyeElement.Dump("EyeCount element");
// use .Value to return the element contents.
eyeElement.Value.Dump("EyeCount element");

// what about elements with child elements?
monsterElement.Dump("Monster element");
monsterElement.Value.Dump("Monster value");
 