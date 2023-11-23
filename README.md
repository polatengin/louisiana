# Using Azure Application Configuration in a dotnet 8 console and web apps

There is a [./.iac/deploy.sh](./.iac/deploy.sh) script that deploys the infrastructure to [Azure](https://azure.com).

It creates a resource group, app configuration, and a few keys in the App Configuration.

The script prints out the connection string to the App Configuration.

## Console app

The [./src/ConsoleApp](./src/ConsoleApp) folder contains a dotnet 8 console app that reads the keys from the App Configuration.

## Web app

The [./src/WebApp](./src/WebApp) folder contains a dotnet 8 web app that reads the keys from the App Configuration.

The web app is also configured to refresh all the keys _when "Version" key is changed_.

## Running the apps

First export the connection string to the App Configuration as an environment variable:

```bash
export CONFIG_CONNECTION_STRING="<copy-paste the connection string from deploy.sh output>"
```

Then run the console app:

```bash
dotnet run
```

Then run the web app:

```bash
dotnet run
```
