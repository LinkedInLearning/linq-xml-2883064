<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use the LINQ Query operators and syntax
// collectibles.Dump();
var q = from card in collectibles.Elements()
		let bid = card.Element("Prices").Element("BidPrice")
		let cat = card.Element("Prices").Element("CatalogPrice")
		
		
		select new
		{
			CardName = card.Attribute("card-name").Value,
			BidPrice = bid.Value,
			CatalogPrice = cat.Value,
			
		};

q.Dump();