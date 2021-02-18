<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-WithPrefix.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

collectibles.Dump("The file has a Schema prefix");
XNamespace theNamespace = collectibles.GetNamespaceOfPrefix("bigstar");
// use the .Element to get a single element by name

//collectibles.Dump();
var firstCard = collectibles.Element(theNamespace + "Card");
firstCard.Dump("The Card");
