<Query Kind="Statements" />

#region Load BigStarCollectibles-MissingXML xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-MissingXML.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

	// bad data in the XML file

var q = from card in collectibles.Elements()
		let pubElement = card.Element("PublishedDate")
	
		//
		let pubValue = pubElement.Value
		// let parsedDate = DateTime.Parse(pubValue)
		
		
		//let pubValue = String.IsNullOrEmpty(pubElement.Value) ? "missing" : card.Element("PublishedDate").Value
		

		select new
		{
			CardName = card.Attribute("card-name").Value,
			PublishedDate = pubValue,
			//ParsedDate = parsedDate,
			PublishedElement = pubElement,
		
			PublishedIsEmpty = pubElement.IsEmpty,
			ZeroLength = String.IsNullOrEmpty(pubValue)
		};

	q.Dump();
