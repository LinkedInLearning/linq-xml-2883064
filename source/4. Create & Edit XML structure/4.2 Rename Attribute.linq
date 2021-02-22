<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion

card.Dump("Card");

card.Element ("PublishedDate").Name = "ReleaseDate";
// XAttribute Name property is read-only.  (Why?)
// card.Attribute("collector-number").Name = "12/245";


card.Dump("Modified Card");