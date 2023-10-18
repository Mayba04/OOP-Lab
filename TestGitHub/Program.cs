using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Octokit;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        string token = "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"; 
        string owner = "Mayba04"; 
        string repoName = "OOP-Lab"; 

        var client = new GitHubClient(new ProductHeaderValue("MyRepoBrowserApp"))
        {
            Credentials = new Credentials(token)
        };

        try
        {
            var contents = await client.Repository.Content.GetAllContents(owner, repoName, "");

            Console.WriteLine($"Список папок у репозиторії {owner}/{repoName}:");

            foreach (var content in contents)
            {
                if (content.Type == ContentType.Dir)
                {
                    Console.WriteLine(content.Name);
                }
            }
        }
        catch (NotFoundException)
        {
            Console.WriteLine($"Репозиторій {owner}/{repoName} не знайдено.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Виникла помилка: {ex.Message}");
        }
    }
}
