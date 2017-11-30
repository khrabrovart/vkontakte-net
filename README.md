# Citrina
Citrina is a full-blown high-performance [VK (VKontakte) API](https://vk.com/dev/manuals) realization for .NET that offers full support of all existing methods.

## Table of contents
- [Description](https://github.com/khrabrovart/Citrina/blob/master/README.md#description)
- [Installation](https://github.com/khrabrovart/Citrina/blob/master/README.md#installation)
- [User Guide](https://github.com/khrabrovart/Citrina/blob/master/README.md#user-guide)
	- [Access Tokens](https://github.com/khrabrovart/Citrina/blob/master/README.md#access-tokens)
    - [Client](https://github.com/khrabrovart/Citrina/blob/master/README.md#client)
    - [Authentication Helpers](https://github.com/khrabrovart/Citrina/blob/master/README.md#authentication-helpers)
    - [Standard API](https://github.com/khrabrovart/Citrina/blob/master/README.md#working-with-api)
    - [Custom Execute Methods](https://github.com/khrabrovart/Citrina/blob/master/README.md#custom-execute-methods)
    - [File Uploading](https://github.com/khrabrovart/Citrina/blob/master/README.md#file-uploading)

## Description 
Citrina is a VK API wrapper for .NET framework. This realization uses an [official VK API JSON Schema](https://github.com/VKCOM/vk-api-schema) to keep all the request/response models and methods up to date. Using this schema __guarantees the correctness and completeness__ of models that VK API actually supports. Current API version that described by VK API JSON Schema is __5.67__.

Converter that parses the JSON schema and transforms it to C# code published separately in [another repo](https://github.com/khrabrovart/VKApiSchemaParser).

Citrina uses request queues to deal with high loads. Every request either puts in a queue or processes instantly depending on existence of an access token. Every access token has its own queue to maximize performance. This kind of logic prevents VK from returning the "Too many requests per second" error. 
It is important when you need to process several requests at a time. There can be maximum 3 requests to API methods per second from a client according to the [official VK API documentation](https://vk.com/dev/api_requests). Citrina puts these requests in a queue and then processes them as fast as possible. All you need to do is just wait for responses to return.
You can do this in _async_ way: call any VK API method async, do whatever you want and then get the response when you need it.

__All the API methods in Citrina are async.__

In addition Citrina supports custom [execute methods](https://vk.com/dev/execute). This kind of methods can be created by application administrator. With Citrina you can call that methods easily by creating custom request/response models and passing a dictionary of parameters in the constructor.

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
2. __Group Token__
   
   ```csharp
   var token = new GroupAccessToken(value: "73364910a57d813fd86be4c4836ff008d1aed4b7ff", communityId: 123123123, appId: 7654321);
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

### Working with API
Citrina client is required to call any VK API method.
All methods are _async_ but they are named as they are named in VK.

Try to call the __Wall.Get__ method to get some posts from your wall.
```csharp
var call = await client.Wall.Get(token, ownerId: 7654321, count: 5);

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

### Custom Execute Methods
In VK API an __execute__ method is universal method for calling a sequence of other methods while saving and filtering interim results.
Such methods can be useful when you need to call several methods at once and get the response instantly. With Citrina you can easily call your own execute methods.

For example, response models:
```csharp
public class ExecuteResponse
{
   IEnumerable<ExecuteResponseItem> Items;
}

public class ExecuteResponseItem
{
   public int? Id { get; set; }
   public int? FromId { get; set; }
   public DateTime? Date { get; set; }
}
```

Method call (note that prefix _execute_ in the method name is not needed):
```csharp
public async Task<ExecuteResponse> ExecuteMe(int communityOwnerId, UserAccessToken accessToken)
{
   var call = await client.Execute.Call<ExecuteResponse>("testMethod", new ExecuteRequest(accessToken, new Dictionary<string, object>
   {
      ["ownerId"] = communityOwnerId
   }));

   if (call.IsError)
   {
       throw new Exception($"Error has occured: {call.Error.Message}");
   }

   return call.Response;
}
```

### File Uploading
Citrina supports all kinds of file uploading in VK API. You can get an uploader from the [Citrina.Uploader](https://www.nuget.org/packages/Citrina.Uploader/) package.
Read [official VK documentation](https://vk.com/dev/upload_files) for more information about file uploading.

For now let's try to upload some photos to an album.
```csharp
var client = new CitrinaClient();
var uploader = new CitrinaUploader();

var albumId = 123123123;
var serverRequest = await client.Photos.GetUploadServer(token, albumId);

if (!serverRequest.IsError) 
{
	var uploadRequest = await uploader.Photos.UploadAlbumPhotosAsync(serverRequest.Response, new[] 
	{ 
		@"C:\some_photo.png" 
	});
	
	var saveRequest = await client.Photos.Save(token, albumId, null, uploadRequest.Data.Server, uploadRequest.Data.PhotosList, 
		uploadRequest.Data.Hash, null, null, "My photo caption");
}
```

And now let's upload an owner photo for community.

```csharp
var client = new CitrinaClient();
var uploader = new CitrinaUploader();

var communityId = -111222333;
var serverRequest = await client.Photos.GetOwnerPhotoUploadServer(token, communityId);

if (!serverRequest.IsError)
{
	var uploadRequest = await uploader.Photos.UploadOwnerPhotoAsync(serverRequest.Response, @"C:\comm_cover.jpg");
	var saveRequest = await client.Photos.SaveOwnerPhoto(token, uploadRequest.Response.Server.ToString(), 
		uploadRequest.Response.Hash, uploadRequest.Response.Photo);
}
```


### To be continued...
