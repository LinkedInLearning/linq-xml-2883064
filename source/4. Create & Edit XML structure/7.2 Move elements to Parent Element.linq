<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// use a foreach loop to move children of one element
// to another parent

collectibles.DumpFormatted("Collectibles");

var q = from c in collectibles.Elements()
				select c;
foreach (var card in q)
{
	// create the new element
	XElement edElement = new XElement("Editorial");
	card.Add(edElement);
	XElement existingSlogan = card.Element("Slogan");
	edElement.Add(existingSlogan);
	existingSlogan.Remove();

	XElement existingDescription = card.Element("Description");
	edElement.Add(existingDescription);
	existingDescription.Remove();
}


collectibles.DumpFormatted("Modified");
