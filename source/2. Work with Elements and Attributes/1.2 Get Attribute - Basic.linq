<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion


// use the .Attribute to get a single attribute by name
// Attribute names are unique per element.

XAttribute theAttribute = collectibles.Element("Card").Attribute("card-name");
theAttribute.Dump();


XAttribute nextAttribute = theAttribute.NextAttribute; // return the next sibling (in this example, the next XAttribute)

nextAttribute.Dump();

nextAttribute.NodeType.Dump();