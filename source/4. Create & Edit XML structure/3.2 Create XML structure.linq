<Query Kind="Statements" />

// Use the LINQ XML classes to create an XML tree

// If indented properly, 
// the code to construct XElement objects closely 
// resembles the structure of the underlying XML.
XElement card = 
	new XElement("Card",
		new XComment("The signatures of the XElement constructors"),
		new XComment("let you pass the contents of the"),
		new XComment("element or attribute as arguments to the constructor"),
		new XAttribute("card-name", "Rivet"),
		new XAttribute("team-name", "Mavericks"),
		new XAttribute("rarity", "Common"),
		new XElement("Slogan", "Hauling mud since 2012"),
		new XElement("Description", "Rivet descended from an assembly line of amphibious robots..."),
		new XElement("PublishedDate", "2016-05-15"),
		new XElement("ImageUri", "Robot-Rivet-card.png"),
		new XElement("Prices",
			new XElement("BidPrice", 3.95M),
			new XElement("CatalogPrice", 6.99M)),
		new XElement("Robot",
			new XElement("PowerSource", "Fission"))
				
	);
							

card.Dump();