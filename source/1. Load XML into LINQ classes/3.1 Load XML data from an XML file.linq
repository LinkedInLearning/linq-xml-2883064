<Query Kind="Statements" />

// A collectible is something of value either in a collection or to a collector.
// Big Star Collectibles trades and sells collectible items.
// Big Star uses data in XML files
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles.xml";
var loaded = XElement.Load(root + upPath + path);
// why not XmlElement (because that name is from earlier XML libraries)

Console.WriteLine(loaded);

//loaded.Dump("Add at title here");