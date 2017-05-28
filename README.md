# Citrina
Citrina is a first full-blown high-performance [VK (VKontakte) API](https://vk.com/dev/manuals) realization for .NET that offers full support of all existing methods.
It uses request queues to deal with high loads. 
Citrina is suitable for any .NET application that needs fast access to VK data.

## Installation
Installation process is very simple with the NuGet Package Manager. Just copy the command below to your Package Manager Console and execute it:

```
Install-Package Citrina
```

[Citrina package in the NuGet](https://www.nuget.org/packages/Citrina/)

## User Guide
### Access Tokens
To run most API methods you need to pass an __access_token__, a special access key. 
Token is a string of digits and latin characters and may refer to a user, community or application itself. 
Read more about access tokens and how to get it on [official VK page](https://vk.com/dev/access_token).

Citrina works with all types of access tokens and will help you to get one.
1. __User Token__
   
   ```csharp
   var token = new UserAccessToken(value: "73364910a57d813fd86be4c4836ff008d1aed4b7ff", expiresIn: 3600, userId: 1234567, appId: 7654321);
   ```
2. __Community Token__
   
   ```csharp
   var token = new CommunityAccessToken(value: "73364910a57d813fd86be4c4836ff008d1aed4b7ff", communityId: 123123123, appId: 7654321);
   ```
3. __Service Token__
   
   Read more about service tokens on [official VK page](https://vk.com/dev/service_token).
   ```csharp
   var token = new ServiceAccessToken(value: "73364910a57d813fd86be4c4836ff008d1aed4b7ff", appId: 7654321);
   ```

### Client
To start working with Citrina you have to create a new client instance. After that you'll be able to call any API method.
```csharp
var client = new CitrinaClient();
```

### Authentication Helpers
To obtain a new token you can use special authentication helpers.

For user tokens use __GenerateLink__ with __LinkType.Code__ for [Authorization Code Flow](https://vk.com/dev/authcode_flow_user) and __LinkType.Token__ for [Implicit Flow](https://vk.com/dev/implicit_flow_user).
```csharp
var codeLink = client.Authentication.GenerateLink(LinkType.Code, 7654321, "http://test.com/account", DisplayOptions.Default, UserPermissions.Audio | UserPermissions.Offline, "some message");
```
Use GetAccessTokenAsync to get an access token for Authorization Code Flow.
Note that __RedirectUri__ in __GetAccessTokenAsync__ method must be equal to __RedirectUri__ in __GenerateLink__ method!
```csharp
var call = await client.Authentication.GetAccessTokenAsync(7654321, "wkE1SyDTei4h2MyV", "http://test.com/account", "ecc20ad9c6a53a5");
var token = call.AccessToken;
```

Code generation and token obtaining process for community tokens is almost the same.
```csharp
var codeLink = client.Authentication.GenerateLink(LinkType.Code, 7654321, new []{ 123123123, 345345345 }, "http://test.com/account", DisplayOptions.Default, GroupPermissions.Manage | GroupPermissions.Messages, "some message");
```

### Standard API
Citrina client is required to call any VK API method with parameters.
All methods are _async_ but they are named as they are named in VK.

Try to call the __Wall.Get__ method to get some posts from your wall.
```csharp
var call = await client.Wall.Get(new WallGetRequest() { AccessToken = token, OwnerId = 7654321, Count = 5 });

if (!call.IsError)
{
   var posts = call.Response.Items;
   var postsObtainedCount = call.Response.Count;
}
else
{
   var errorMessage = call.Error.Message;
}
```

### File Uploading
Citrina supports all kinds of file uploading in VK API. You can get an uploader right from the Citrina client. 
Read [official VK documentation](https://vk.com/dev/upload_files) for more information about file uploading.

For now let's try to upload some photos to an album.
```csharp
var call = await client.Photos.GetUploadServer(new PhotoGetUploadServerRequest() { AccessToken = token, AlbumId = 23452345 });

var upload = await client.Uploader.Photos.UploadAlbumPhotosAsync(call.Response, new[] { @"C:\photo.jpg", @"C:\citrina.png" });

if (!upload.IsError)
{
   var result = await Client.Photos.Save(new SaveRequest
   {
      AccessToken = token,
      AlbumId = upload.Data.AlbumId,
      Caption = "citrina test",
      Hash = upload.Data.Hash,
      PhotosList = upload.Data.PhotosList,
      Server = upload.Data.Server
   });
}
```

And now let's upload an audio.
```csharp
var call = await Client.Audio.GetUploadServer(new AudioGetUploadServerRequest { AccessToken = token });

var upload = await Client.Uploader.Audio.UploadAudioAsync(call.Response, @"C:\my_fav_song.mp3");

if (!upload.IsError)
{
   var result = await Client.Audio.Save(new AudioSaveRequest
   {
      AccessToken = token,
      Hash = upload.Data.Hash,
      Server = upload.Data.Server,
      Audio = upload.Data.Audio,
      Artist = "some artist",
      Title = "some title"
   });
}
```

### To be continued...
