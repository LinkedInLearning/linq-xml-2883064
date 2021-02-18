<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion

card.Dump("Card");

card.Attribute("team-name").Dump("team-name Attribute");

// replaces existing attributes with new content
 card.ReplaceAttributes(new XAttribute("crew", "DarkShadows?"));



card.Dump("Modified Card");