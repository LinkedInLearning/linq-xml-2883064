<Query Kind="Statements" />

#region Load BigStarCollectibles-MissingXML xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-MissingXML.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// card-family
var q1 = from card in collectibles.Elements()
		 group card by card.Attribute("card-family").Value
		 into teams
		 let count = teams.Count()
		 orderby count
		 select new
		 {
		 	Count = count,
			Team = teams.Key,
		 	Cards = teams.SelectMany(t => t.Attributes("card-name"))
			
		 }
		 ; 

q1.Dump();