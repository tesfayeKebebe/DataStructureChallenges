namespace PracticeAlgorithm;

public class TEST
{
    private const string uri = "https://raw.githubusercontent.com/qualified/challenge-data/master/words_alpha.txt";
    private  HttpClient _httpClient;
    private List<string> _wordList;
[Fact]
    public async Task GetWordListTest()
    {
        var result = await GetWordList("aar");
    }

    private async Task<List<string>> GetWordList(string stem)
    {
        _httpClient = new HttpClient();
        var response= await _httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var wordList = content.Split('\n').Select(word=> word.Trim()).ToList();
        if(_wordList==null)
        {
            _wordList = wordList;
        }
       
        if(string.IsNullOrEmpty(stem))
        {
            return _wordList;
        }
        var matchingWords = _wordList.Where(x=>x.StartsWith(stem)).ToList();
        if(matchingWords.Any())
        {
            return matchingWords;
        }
        return new List<string>();

    }
    
}