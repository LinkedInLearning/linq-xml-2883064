<Query Kind="Statements" />

// use the Parse method to work with XML data in a string

var parsed = XElement.Parse(@"
<Card name='Rex' rarity='Uncommon' team-name='Crashmasters' collector-number='06/143' card-family='Robot'>
      <Slogan>Great Microcontrollers Think Alike</Slogan>
      <Description>Rex is the Mayor of Binaryville, and a well-loved personality in town. He rose to robotdom from a microprocessor plant on the south side of town, where many famous and influential robots before him were conceived.
			</Description>
      <PublishedDate>2016-09-16</PublishedDate>
      <ImageUri>Robot-Rex-card.png</ImageUri>
      <Prices>
        <CatalogPrice>5.99</CatalogPrice>
        <BidPrice>17.95</BidPrice>
      </Prices>
      <Robot>
        <PowerSource>Battery</PowerSource>
      </Robot>
</Card>");

parsed.Dump();