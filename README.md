# Citrina
Citrina is a first full-blown high-performance [VK (VKontakte) API](https://vk.com/dev/manuals) realization for .NET that offers full support of all existing methods.

## Description 
Citrina is a VK API wrapper for .NET framework. This realization uses an [official VK API JSON Schema](https://github.com/VKCOM/vk-api-schema) to keep all the request/response models and methods up to date. Using this schema __guarantees the correctness and completeness__ of the models that VK API actually supports. Current API version that is described by VK API JSON Schema is __5.62__.

_The converter that parses the JSON schema and transforms it to C# code is not included in the current repo and will be published separately in the near future._

Moreover Citrina uses request queues to deal with high loads. Every request either puts in a queue or processes instantly depending on the existence of an access token. Every access token has its own queue to maximize performance. This kind of logic prevents VK from returning the "Too many requests per second" error. 
It is important when you need to process several requests at a time. There can be maximum 3 requests to API methods per second from a client according to the [official VK API documentation](https://vk.com/dev/api_requests). Citrina puts these requests in a queue and then processes them as fast as possible. All you need to do is to wait for responses to return.
You can do this in _async_ way: call the VK API method async, do whatever you want and then get the response when you need it.

__All the API methods in Citrina are async.__

In addition Citrina supports custom [execute methods](https://vk.com/dev/execute). This kind of methods can be created by application administrator. With Citrina you can call that methods easily by creating custom request/response models and passing a dictionary of parameters in the constructor.

There is also the [Callback API](https://vk.com/dev/callback_api) support. Callback API is a tracking tool for users activity in your VK communities.

In any case Citrina is suitable for every .NET application that needs fast access to VK data.

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
