<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// returns the XML data (including the element tags)
// Elements can contain content, or other elements

var eyeElement = collectibles.Element("Card").Element("Monster").Element("EyeCount");

eyeElement.Dump("EyeCount element");
eyeElement.Value.Dump ("EyeCount value");

// change the value
eyeElement.Value = "5";
eyeElement.Dump("Modified EyeCount element");
eyeElement.Value.Dump ("Modified EyeCount value");



