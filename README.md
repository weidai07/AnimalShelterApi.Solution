# Animal Shelter Api Project
##### By Wei Dai
###### Created 31 January, 2020

## Description

This project allows users to search for dogs and cats at local animal shelters. 

## Links:

Github - https://github.com/weidai07/AnimalShelterApi.Solution

## Setup/Installation Requirements:

1. Open https://github.com/weidai07/AnimalShelterApi.Solution
2. Clone repository to local machine 
3. Build and Run project

  - $ dotnet restore - when you are ready to restore the dependencies of the project
  - $ dotnet build - when you are ready to build the project
  - $ dotnet ef migrations add Initial - to build the table in MySQL
  - $ dotnet ef database update - to update the table in the database 
  - $ dotnet watch run - to run the project and play the game 

### Specification

This program is designed to allow users to search for cats and dogs at local animal shelters as well as the quantity of each animal at the shelter. The user can search specifically for either cats or dogs. 

This project uses Swagger. In order to access the homepage, please click on the local host website once the project starts running. 

To find cats, please use the following words for your search: Bengal, Ragdoll, Birman, Persian, and Sphynx.

To find dogs, please use the following words for your search: Corgi, Lab, Retriever, Husky, and Chihuahua. 


## Known Bugs

* _None at this time_

## Technologies Used:

* C#
* .NET
* Microsoft(MS) Test
* MySQL
* LINQ
* Swagger 

### License:

Copyright (c) 2020 Wei Dai

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.