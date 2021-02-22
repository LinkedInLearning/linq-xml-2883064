<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion

card.Dump("Card");

// replaces all existing attributes with new content
 card.ReplaceAttributes(new XAttribute("crew", "DarkShadows"));
 
 //card.ReplaceAttributes(new XAttribute("crew", "DarkShadows"), 
 //												new  XAttribute("inventory-count", "14"));


card.Dump("Modified Card");