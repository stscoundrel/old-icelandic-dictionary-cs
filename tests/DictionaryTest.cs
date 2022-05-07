using Xunit;
using System;
using OldIcelandicDictionary;

namespace OldIcelandicDictionaryTest;

public class DictionaryTest
{
    [Fact]
    public void DictionaryHasCorrectAmountOfEntriesTest()
    {
        var dictionary = new Dictionary();
        var result = dictionary.GetEntries();

        Assert.Equal(29951, result.Count);
    }

    [Fact]
    public void DictionaryHasExpectedContentTest()
    {
        var dictionary = new Dictionary();
        var result = dictionary.GetEntries();

        Assert.Equal("a", result[0].Headword);
        Assert.Equal("a negative suffix to verbs, not;", result[0].Definitions[0]);
        Assert.Equal("era útmakligt, at it is not unmeet that.", result[0].Definitions[1]);

        Assert.Equal("afbindi", result[14].Headword);
        Assert.Equal("n. constipation.", result[14].Definitions[0]);

        Assert.Equal("andstreymr", result[1000].Headword);
        Assert.Equal("a. strongly adverse (andstreym ørlög); Sighvatr var heldr ~ um eptirmálin, hard to come to terms with.", result[1000].Definitions[0]);

        Assert.Equal("undanhald", result[25000].Headword);
        Assert.Equal("n. flight.", result[25000].Definitions[0]);
    }
}