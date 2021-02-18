<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use the LINQ Query operators and syntax
// get child elements
var q1 = from card in collectibles.Elements()
		 select card.Element("Prices").Element("BidPrice");

q1.Dump();

var q2 = from bid in collectibles.Descendants("BidPrice")
		 select bid;

q2.Dump();