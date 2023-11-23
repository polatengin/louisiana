# Using Azure Application Configuration in a dotnet 8 console and web apps

There is a [./.iac/deploy.sh](./.iac/deploy.sh) script that deploys the infrastructure to [Azure](https://azure.com).

It creates a resource group, app configuration, and a few keys in the App Configuration.

The script prints out the connection string to the App Configuration.

## Console app

The [./src/ConsoleApp](./src/ConsoleApp) folder contains a dotnet 8 console app that reads the keys from the App Configuration.
