<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion


card.Dump("Card");

card.Attributes("team-name").Remove();
card.Add(new XAttribute("crew", "DarkShadows"));





card.Dump("Modified Card");