<Query Kind="Statements" />

#region Load CardSimple xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
#endregion

card.DumpFormatted("Original");

//to rename an attribute, copy, add new, remove old

var teamName = card.Attribute("team-name").Value;
card.Add(new XAttribute("crew", teamName));
card.Attributes("team-name").Remove();


card.DumpFormatted("Modified");