namespace HomeWork3_17_3;

public class EnUaDictionary {

    private Dictionary<string, string> _ = new Dictionary<string, string>();

    public void Add(string enWord, string uaWord) {
        if (_.ContainsKey(enWord))
            throw new Exception("Слово вже міститься в словнимку");

        _.Add(enWord, uaWord);
    }

    public IEnumerable<dynamic> GetEntries() {
        return _.Select(x => new { 
            EnWord = x.Key,
            UaWord = x.Value
        });
    }

}
