#!/usr/bin/env bash

# Command to initialze and build and run a project inside a folder
dotnet new console -o 2-new_project
dotnet build ./2-new_project
dotnet run --project ./2-new_project/2-new_project.csproj
