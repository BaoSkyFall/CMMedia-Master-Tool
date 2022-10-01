// See https://aka.ms/new-console-template for more information
using CMMedia_Master_Tool;
using Org.BouncyCastle.Asn1.Ocsp;

Console.WriteLine("Hello, World!");

string hostName = ".facebook.com";
var chromeManager = new ChromeManager();
var data = chromeManager.GetCookies(hostName);
//var readCookies = new ChromeCookieReader();
//var temp = readCookies.ReadCookies(hostName);
foreach (var item in data)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Value);
}
//Console.WriteLine(data);