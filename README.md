# Old Icelandic Dictionary

Old Icelandic dictionary for C# / .NET. From "A Concise Dictionary of Old Icelandic" by Geir Zoëga

The dictionary consists of 29 000+ Old Icelandic words with English translations.

### Install

```
dotnet add package OldIcelandicDictionary
```

### Usage


```csharp
using OldIcelandicDictionary;

// Get all dictionary entries.
var dictionary = new Dictionary();
var result = dictionary.GetEntries();
Console.WriteLine(dictionar.Count); // 29 951 entries.

// Individual entry contains headword and definitions list.
DictionaryEntry entry = result[0];
Console.WriteLine(entry.Headword); // a
Console.WriteLine(entry.Definitions[0]); // a negative suffix to verbs, not;
Console.WriteLine(entry.Definitions[1]); // era útmakligt, at it is not unmeet that.

DictionaryEntry entry2 = result[24999]
Console.WriteLine(entry2.Headword); // undanfœrsla
Console.WriteLine(entry2.Definitions[0]); // f. evasion, pleading one’s innocence.

// ToString is overwritten for generic presentation.
Console.WriteLine(entry2.ToString()); //undanfœrsla - f. evasion, pleading one’s innocence.

```

### About "A Concise Dictionary of Old Icelandic"

"A Concise Dictionary of Old Icelandic" dictionary was published in 1910 by Geir Zoëga, which leads to there being many public domain versions of the book available. Zoëgas attempt was to made easier-to-approach version of the more full Cleasby - Vigfusson dictionary, specifically for beginners and those interested in Old Icelandic prose writing.
