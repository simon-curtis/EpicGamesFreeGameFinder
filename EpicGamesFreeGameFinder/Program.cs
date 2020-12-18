using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using EpicGamesFreeGameFinder.Models;

string query = File.ReadAllText("graphql.query");
string variables = File.ReadAllText("variables.json");

var client = new HttpClient
{
    BaseAddress = new Uri("https://www.epicgames.com")
};

var endpoint = $"graphql?query={query}&variables={variables}";
var result = await client.GetAsync(endpoint);

var root = await result.Content.ReadFromJsonAsync<Root>();

if (root == null)
    return;

foreach (var element in root.data.Catalog.searchStore.elements)
{
    Console.WriteLine(element.title);
}