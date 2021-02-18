<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion

card.Dump("Card");

card.Element ("Slogan").Dump("Slogan Element");

card.Element ("Slogan").ReplaceWith	(new XElement("Motto", "Trouble, what trouble?"));

card.Dump("Mocified Card");