using Millheat.Api.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Millheat.Api
{
    public class MillheatClient
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly StringContent stringData = new StringContent(string.Empty);
        private readonly string username;
        private readonly string password;


        /// <summary>
        /// Creates an instance of the <see cref="MillheatClient"/> using the given username and password.
        /// </summary>
        /// <param name="username">The username (e-mail) you use to log on to the Millheat app with.</param>
        /// <param name="password">The password you use to log on to the Millheat app with.</param>
        public MillheatClient(string username, string password)
        {
            httpClient.BaseAddress = new Uri("https://api.millheat.com/");
            this.username = username;
            this.password = password;
        }

        /// <summary>
        /// Gets the authorization code that you need to be able to retrieve an access token.
        /// </summary>
        /// <param name="accessKey">Mill API access key that you recieved from applying at https://api.millheat.com/</param>
        /// <param name="secretToken">Mill API secret token key that you recieved from applying at https://api.millheat.com/</param>
        /// <returns>The authorization code needed to in turn get the access token.</returns>
        public async Task<string> GetAuthorizationCode(string accessKey, string secretToken)
        {
            httpClient.DefaultRequestHeaders.Add("access_key", accessKey);
            httpClient.DefaultRequestHeaders.Add("secret_token", secretToken);

            var response = await httpClient.PostAsync("share/applyAuthCode", stringData);
            var result = await response.Content.ReadAsStringAsync();
            var jsonResult = JsonSerializer.Deserialize<ApplyAuthCodeResponse>(result);
            return jsonResult.Data.AuthorizationCode;
        }

        /// <summary>
        /// Gets the access token needed to retrieve the homes connected to your Mill account.
        /// </summary>
        /// <param name="authorizationCode">The authorization code received from <see cref="GetAuthorizationCode(string, string)"/></param>
        /// <returns>The access token needed to retrieve the homes connected to your Mill account.</returns>
        public async Task<string> GetAccessToken(string authorizationCode)
        {
            httpClient.DefaultRequestHeaders.Remove("access_key");
            httpClient.DefaultRequestHeaders.Remove("secret_token");

            httpClient.DefaultRequestHeaders.Add("authorization_code", authorizationCode);

            var requestUrl = $"share/applyAccessToken?password={password}&username={username}";
            var response = await httpClient.PostAsync(requestUrl, stringData);
            var result = await response.Content.ReadAsStringAsync();
            var jsonResult = JsonSerializer.Deserialize<ApplyAccessTokenResponse>(result);
            return jsonResult.Data.AccessToken;
        }

        /// <summary>
        /// Gets the homes connected to your Mill account.
        /// </summary>
        /// <param name="accessToken">The access token received from <see cref="GetAccessToken(string)"/></param>
        /// <returns>A list of homes (if any) connected to your Mill account.</returns>
        public async Task<List<Home>> GetHomes(string accessToken)
        {
            httpClient.DefaultRequestHeaders.Remove("authorization_code");

            httpClient.DefaultRequestHeaders.Add("access_token", accessToken);

            var requestUrl = $"uds/selectHomeList";
            var response = await httpClient.PostAsync(requestUrl, stringData);
            var result = await response.Content.ReadAsStringAsync();
            var jsonResult = JsonSerializer.Deserialize<SelectHomeListResponse>(result);
            return jsonResult.Data.Homes.ToList();
        }

        /// <summary>
        /// Gets the rooms connected to your <see cref="Home"/>.
        /// </summary>
        /// <param name="home"> The <see cref="Home"/> that you want to get the rooms for.</param>
        /// <returns></returns>
        public async Task<List<Room>> GetRooms(Home home)
        {
            var requestUrl = $"uds/selectRoombyHome?homeId={home.HomeId}";
            var response = await httpClient.PostAsync(requestUrl, stringData);
            var result = await response.Content.ReadAsStringAsync();
            var jsonResult = JsonSerializer.Deserialize<SelectRoombyHomeResponse>(result);
            return jsonResult.Data.Rooms.ToList();
        }

        /// <summary>
        /// Gets the devices connected to your <see cref="Room"/>.
        /// </summary>
        /// <param name="room">The <see cref="Room"/> that you want to get devices for.</param>
        /// <returns></returns>
        public async Task<List<Device>> GetDevices(Room room)
        {
            var requestUrl = $"uds/selectDevicebyRoom?roomId={room.RoomId}";
            var response = await httpClient.PostAsync(requestUrl, stringData);
            var result = await response.Content.ReadAsStringAsync();
            var jsonResult = JsonSerializer.Deserialize<SelectDevicebyRoomResponse>(result);
            return jsonResult.Data.Devices.ToList();
        }

        /// <summary>
        /// Sets the temperature for a given <see cref="Device"/>.
        /// </summary>
        /// <param name="device">The <see cref="Device"/> to set the temperature for control.</param>
        /// <param name="temperature">The temperature (in Celsius) to set.</param>
        /// <returns></returns>
        public async Task SetTemperature(Device device, int temperature)
        {
            // 0 = switch control (on/off). 1 = temperature control.
            var operation = 1;
            // when operation is 0, means the switch（0：off，1：on ）
            // when operation is 1, means the switch of single control（0：set to room control，1：set to single control ）
            var status = 1;

            var requestUrl = $"uds/deviceControlForOpenApi?deviceId={device.DeviceId}&holdTemp={temperature}&operation={operation}&status={status}";
            var response = await httpClient.PostAsync(requestUrl, stringData);
            var result = await response.Content.ReadAsStringAsync();
        }
    }
}
