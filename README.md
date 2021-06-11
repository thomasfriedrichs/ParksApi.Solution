# _{Park Locator}_

#### _{A Park Locator api}_

#### By _**{Thomas Friedrichs}**_

## Technologies Used

* _dotnet_
* _C#_
* _entity_
* _swagger_
* _aspnetcore_

## Description

_{This is a seeded api which can be called on to display national parks from around the country.}_

## Setup/Installation Requirements

* _go to https://github.com/thomasfriedrichs/ParksApi.Solution_
* _select the green 'code' box and copy the link to your clipboard_
* _navigate to the cloned file and type 'code .'_
* _in the ParksApi.Solution directory create an 'appsettings.json' file_
* _copy the code below into your appsettings.json file_
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=National_Parks;uid=root;pwd=epicodus;"
  }
}
```
* _navigate to NationalParksLocator directory and run 'dotnet ef database update' in your terminal_
* _now do 'dotnet watch run' in your terminal_
* _type 'http://localhost:5000/swagger' in your browser url bar_
* _now you have a view where you can test out those endpoints!_
## Known Bugs

* _No known Bugs_

## License

MIT License

Copyright (c) [2021] [Thomas Friedrichs]

_{If you have any questions or concerns please feel free to contact me!}_

## Contact Information

_{Thomas Friedrichs friedrichs.tommy@gmail.com}_
