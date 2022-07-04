using Millheat.Api;
using System.Linq;

var millheatClient = new MillheatClient("john.doe@gmail.com", "password");

var authorizationCode = await millheatClient.GetAuthorizationCode("accessKey", "secretToken");
var accessToken = await millheatClient.GetAccessToken(authorizationCode);
var homes = await millheatClient.GetHomes(accessToken);
var rooms = await millheatClient.GetRooms(homes.First());
var devices = await millheatClient.GetDevices(rooms.First());
await millheatClient.SetTemperature(devices.First(), 22);

System.Console.ReadLine();