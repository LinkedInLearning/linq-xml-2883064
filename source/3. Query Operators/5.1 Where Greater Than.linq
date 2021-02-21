<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use the LINQ Query operators and syntax
// use let keyword to create variables 
// used in the query
// this example, do subtraction on the parsed values
var q = from card in collectibles.Elements()
				let bid = card.Element("Prices").Element("BidPrice")

				where decimal.Parse(bid.Value) > 12.00M
				select new
				{
					CardName = card.Attribute("card-name").Value,
					BidPrice = bid.Value


				};

q.Dump();