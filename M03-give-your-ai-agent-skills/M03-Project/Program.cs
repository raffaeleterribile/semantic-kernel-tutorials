﻿using Microsoft.SemanticKernel;

string yourDeploymentName = "";
string yourEndpoint = "";
string yourApiKey = "";

var builder = Kernel.CreateBuilder();
builder.AddAzureOpenAIChatCompletion(
    yourDeploymentName,
    yourEndpoint,
    yourApiKey,
    "gpt-4o-mini");

var kernel = builder.Build();
kernel.ImportPluginFromType<MusicLibraryPlugin>();

var result = await kernel.InvokeAsync(
    "MusicLibraryPlugin",
    "AddToRecentlyPlayed",
    new()
    {
        ["artist"] = "Tiara",
        ["song"] = "Danse",
        ["genre"] = "French pop, electropop, pop"
    }
);

Console.WriteLine(result);