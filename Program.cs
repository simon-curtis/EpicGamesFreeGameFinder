using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using EpicGamesFreeGameFinder.Models;

string query = File.ReadAllText("graphql.query");
string variables = File.ReadAllText("variables.json");

var baseUrl = "https://www.epicgames.com";
var client = new HttpClient
{
    BaseAddress = new Uri(baseUrl)
};

var endpoint = $"graphql?query={query}&variables={variables}";
var result = await client.GetAsync(endpoint);

if (await result.Content.ReadFromJsonAsync<Root>() is not { } root)
    return;

var elements = root.data.Catalog.searchStore.elements;

var stringBuilder = new StringBuilder();

foreach (var group in elements.GroupBy(x => x.effectiveDate.Date).OrderByDescending(x => x.Key))
{
    stringBuilder.AppendFormat("## {0:dd MMM yyyy}\n\n", group.Key);
    foreach (var element in group)
    {
        var slug = element.productSlug?
            .Replace("/home", "")
            .Replace("/", "--")
            ?? element.title;

        stringBuilder.AppendFormat("[{0}]({1}) \n\n", element.title, $"{baseUrl}/en-US/p/{slug}");
    }
}

File.WriteAllText("output.md", stringBuilder.ToString());