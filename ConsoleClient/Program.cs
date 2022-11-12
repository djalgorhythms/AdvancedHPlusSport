// See https://aka.ms/new-console-template for more information
using IdentityModel.Client;

Console.ReadLine();

var client = new HttpClient();

var discoveryDocument = await client.GetDiscoveryDocumentAsync("https://localhost:5001");

var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
{
    Address = discoveryDocument.TokenEndpoint, ClientId = "m2m.client",
    ClientSecret = "511536EF-F270-4058-80CA-1C89C192F69A",
    Scope = "scope1"
});

Console.WriteLine($"Token: {tokenResponse.AccessToken} ");
