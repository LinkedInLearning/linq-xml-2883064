<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion

card.Dump("Card");

card.Element ("Monster").ReplaceWith	(
							new XElement("Rogue", 
								new XAttribute("scaly","true"),
								new XElement("Scariness", 4),
								new XElement("Flyer", "true")	));

card.Dump("Modified Card");