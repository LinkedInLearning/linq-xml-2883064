<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// get element by ordinal value

XElement firstCard = collectibles.Element("Card");
firstCard.Dump("First");

XElement firstCardAgain = collectibles.Elements().ElementAt(0);
firstCardAgain.Dump("First Again");

XElement thirdCard = collectibles.Elements().ElementAt(2);
thirdCard.Dump("Third");