<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion


collectibles.Dump("All");
var robots = collectibles.Elements().Where(x =>x.Attribute("card-family").Value=="Robot" );
		
robots.Dump("Robots Only");

robots.Remove();

collectibles.Dump("Removed the Robots");