<Query Kind="Statements" />

#region Load BigStarCollectibles-MissingXML xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-MissingXML.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

	// bad data in the XML file

var q = from card in collectibles.Elements()
		let bidElement = card.Element("Prices").Element("BidPrice")
		let catElement = card.Element("Prices").Element("CatalogPrice")
		//
		let bidValue = bidElement.Value
		let catValue = catElement.Value
		
		//let bidValue = bidElement.IsEmpty ? "missing" : card.Element("Prices").Element("BidPrice").Value
		//let catValue = catElement.IsEmpty ? "missing" : card.Element("Prices").Element("CatalogPrice").Value

		select new
		{
			CardName = card.Attribute("card-name").Value,
			BidPrice = bidValue,
			CatalogPrice = catValue,
			
			BidPriceElement = bidElement,
			CatalogPriceElement = catElement,
			BidIsEmpty = bidElement.IsEmpty,
			CatalogIsEmpty = catElement.IsEmpty
		};

	q.Dump();
