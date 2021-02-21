<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion


// collectibles.Dump();
var q = from card in collectibles.Elements()
				where card.Attribute("card-name").Value== "Mingle"
				select new
				{
					CardName = card.Attribute("card-name").Value,
					TeamName = card.Attribute("team-name").Value,
					ElementName = card.Element("Slogan").Name,
					Slogan = card.Element("Slogan").Value
				};

q.Dump();