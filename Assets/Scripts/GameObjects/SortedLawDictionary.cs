using System;
using System.Collections;
using System.Collections.Generic;

public class SortedBySectionLawDictionay : SortedDictionary<int, Law>
{
}

public class SortedByArticleLawDictionary : SortedDictionary<int, SortedBySectionLawDictionay>
{
}