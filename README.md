# About

Millheat.Api is a C# wrapper over the Mill Open API, which lets you control [Mill](https://millnorway.com/) smart heaters. It lets you retrieve homes, rooms and devices connected to your Mill account.

# How to use
Before you use this, make sure you've applied for the [Mill Open API](https://api.millheat.com/) and have received an access key and a secret token.

Create a new `MillheatClient` with your username and password as parameters (your credentials when logging on to the Millheat app):

```csharp
var millheatClient = new MillheatCLient("john.doe@gmail.com", "password"); 
```

Next you'll need the authorization code to retrieve an access token, using the access key and the secret token you received from applying to the Mill Open API:

```csharp
var authorizationCode = await millheatClient.GetAuthorizationCode(access_key, secret_token);
```

Finally you can get the access token needed to retrieve the homes connected to your Mill account:
```csharp
var accessToken = await millheatClient.GetAccessToken(authorizationCode);
```

Now you can get the homes connected to your account using the access token:
```csharp
var homes = await millheatClient.GetHomes(accessToken);
```

Get all the rooms connected to your specific home (using `First()` as example):
```csharp
var rooms = await millheatClient.GetRooms(homes.First());
```

Get all the devices connected to your specific room (using `First()` as example):
```csharp
var devices = await millheatClient.GetDevices(rooms.First());
```

Set the temperature (in Celsius) for the specific device:
```csharp
await millheatClient.SetTemperature(devices.First(), 22);
```

# Blogpost
Check my blogpost on how I used the API to connect to Google Assistant via Azure Functions: https://www.andreasnesheim.no/controlling-your-mill-smart-heater-using-google-assistant-and-azure-functions/
