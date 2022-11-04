# _Botanical Adventure API_

#### By _**Helen Lehrer, Keisha Marie, Kelly Bruce, Tiberius Locket, and Harold Mesa**_

#### _API for the Botanical Adventure MVC._

## Technologies Used

* _C#_
* _.NET Core_
* _MySQL_
* _Entity_

## Description

_The Botanical Adventure API provides with a database of mushrooms, flowers and trees in the coast, desert and forest of Oregon for a game._

_All requests are made to endpoints beginning: http://localhost:5004/api/_

_The API has one endpoint:_
* _api/items_

_api/items provides with a database of mushrooms, flowers and trees. Users can filter the search based on four parameters (name, category, type, difficulty) in the following way:_
* _api/items?name='The name of the botanical item the user wants to look for'_
* _api/items?category='The category of the botanical item the user wants to look for'_
* _api/items?type='The type of the botanical item the user wants to look for'_
* _api/items?difficulty='The difficulty of the botanical item the user wants to look for'_

###### * _This API will host the database for the [Botanical Adventure MVC website](https://github.com/curiousmockingbird/team-week-mvc.git)._

## Setup

* _If you haven't yet, install the dotnet ef tool through your command line (run $ dotnet tool install --global dotnet-ef --version 5.0.1)_
* _On the root directory, create an appsettings.json fie and add the following code:_  
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=botanical_adventure;uid=root;pwd=[Your-MySql-password-here];"
  }
}
* _Run '$ dotnet ef database update'_
* _Run '$ dotnet watch run' to run the API. It will open the http://localhost:5004/api/items endpoint._ 

## Bugs

* _No known bugs_

## License

_[MIT License](https://en.wikipedia.org/wiki/MIT_License)_

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _24 Nov, 2022_ _Helen Lehrer, Keisha Marie, Kelly Bruce, Tiberius Lockett, Harold Mesa_
