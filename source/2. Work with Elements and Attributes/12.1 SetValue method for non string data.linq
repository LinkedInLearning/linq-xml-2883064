<Query Kind="Statements">
  <Namespace>System.Numerics</Namespace>
</Query>

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

var catPriceElement = collectibles.Element("Card").Element("Prices").Element("CatalogPrice");
decimal newPrice = 35.99M;
catPriceElement.Dump();

// .Value is typed as string 
 //catPriceElement.Value = newPrice;
 //catPriceElement.Value = newPrice.ToString();
// SetValue takes an object parameter
catPriceElement.SetValue(newPrice);

catPriceElement.Dump();