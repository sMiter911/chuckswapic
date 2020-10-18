# ChuckSwapic SovTech Submission

The ChuckSwapi demo application gets data from two sources:
1. The Star Wars API
2. The Chuck Norris API

In the Demo application there are three root endpoints that point to the various destinations using said API
1. /chuck = /chuck/categories - gives out the jokes categories linked to a Chuck Norris joke
2. /swapi = /swapi/people - gives out a list of characters associated with the Star Wars Universe
3. /search = search?query=luke (example) - will give out the associated query from both the Chuck Norris and Star Wars APIs in this case it will return jokes relating Luke (Chuck Norris API) and a character named Luke (Star Wars API)

The demo application is live on Heroku:
https://chuckswapic.herokuapp.com/

With the following routes:
1. https://chuckswapic.herokuapp.com/chuck/categories
2. https://chuckswapic.herokuapp.com/swapi/people
3. https://chuckswapic.herokuapp.com/search?query={query}

Alternatively the swagger UI can be used in order to execute the routes. It can be found at:
https://chuckswapic.herokuapp.com/swagger

### Starting the application locally

Once the repo has been downloaded, the project may be opened via the solutions file.
In visual studio there are two main methods of running the application
1. Docker - if docker desktop is installed - this will execute the Dockerfile and run the application
2. chuckswapic - will run the application 

Alternatively be run via command line or VS Code Termninal:
```sh
$ dotnet run
```
This should be done once inside the project folder (not solutions folder) e.g. ~/source/repos/solution-name/project-name
