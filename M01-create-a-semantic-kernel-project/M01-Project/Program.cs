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

var result = await kernel.InvokePromptAsync(
		"Give me a list of breakfast foods with eggs and cheese");
Console.WriteLine(result);