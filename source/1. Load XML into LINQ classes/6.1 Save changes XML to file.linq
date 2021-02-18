<Query Kind="Statements" />

var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"CardSimple.xml";
var card = XElement.Load(root + upPath + path);
card.Dump("Before");

// change the <Slogan> and <PublishedDate> values (details about working with values available in later chapters).

card.SetElementValue("Slogan" , "Triple Trouble");
card.SetElementValue("PublishedDate" , "2019-09-09");

card.Dump("After");

// save changes to a file.

card.Save(root +   upPath + @"\CardSimple-Copy.xml");