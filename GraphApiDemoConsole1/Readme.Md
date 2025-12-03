1. How to get Access token, using which we can test graph end points

- Create App registration (Graph-Quickstart)
- Assign API permisions- Application
	- Directory.ReadWrite.All
	- User.ReadWrite.All
- Add role assignment User Administrator on to the app registration Graph-Quickstart
- Create secret: x5i8Q~fWpf.OBnw6aCkk3poNNE6c_S056U4A6dra

-Open Postman

HttpPost
https://login.microsoftonline.com/0014ebb3-2539-411a-b2c0-62546ee6e1f0/oauth2/v2.0/token

Headers:
Content-Type:application/x-www-form-urlencoded

client_id:
client_secret:x5i8Q~fWpf.OBnw6aCkk3poNNE6c_S056U4A6dra
grant_type:client_credentials
scope:https://graph.microsoft.com/.default


Learn about: grant types
https://oauth.net/2/grant-types/

2. Get all users in the tenant
https://graph.microsoft.com/v1.0/users

Headers:
 Authorization:bearer <token>

3. Get count of users in the tenant
https://graph.microsoft.com/v1.0/users/$count

Headers:
 Authorization:bearer <token>
 ConsistencyLevel:eventual

4.Get user with filter
https://graph.microsoft.com/v1.0/users?$filter=startswith(displayName,'G')
https://graph.microsoft.com/v1.0/users?$filter=startswith(displayName,'k')&$orderBy=displayName&$count=true
https://graph.microsoft.com/v1.0/users?$filter=startswith(displayName,'k')&$orderBy=displayName&$count=true&$top=10
https://graph.microsoft.com/v1.0/users?$filter=startswith(displayName,'k')&$orderBy=displayName&$count=true&$top=10&$select=displayName,id

--filter user whose displayname contains 'go'
https://graph.microsoft.com/v1.0/users?$search="displayName:go"
https://graph.microsoft.com/v1.0/users?$search="displayName:k"&$select=displayName,id


Headers:
 Authorization:bearer <token>
 ConsistencyLevel:eventual

5.Create new User(Post)
https://graph.microsoft.com/v1.0/users
Headers:
 Authorization:bearer <token>
 Content-Type:application/json
 body:
 {
    "accountEnabled":true,
    "displayName":"Danvik",
    "mailNickname":"Danvik",
    "userPrincipalName":"Danvik@gorintlasandhyaoutlook.onmicrosoft.com",
    "passwordProfile":{
        "forceChangePasswordNextSignIn":true,
        "password":"TkapFirst@123$34fs"
    }
}
6. Get User details by name equal to Danvik
https://graph.microsoft.com/v1.0/users?$filter=displayName eq 'Danvik'
https://graph.microsoft.com/v1.0/users?$filter=id eq '24ed5b1c-cd45-4cf4-86e2-d818c48a1b05'

Headers:
 Authorization:bearer <token>

7. Get User properties by user id
 https://graph.microsoft.com/v1.0/users/24ed5b1c-cd45-4cf4-86e2-d818c48a1b05
 https://graph.microsoft.com/v1.0/users/24ed5b1c-cd45-4cf4-86e2-d818c48a1b05?$select=displayName,id,userPrincipalName

Headers:
 Authorization:bearer <token>
8. Path user
https://graph.microsoft.com/v1.0/users/24ed5b1c-cd45-4cf4-86e2-d818c48a1b05
Headers:
 Authorization:bearer <token>
 Content-Type:application/json
 body:

{
    "city":"bangalore",
    "country":"India"
}
9. Get user details
 https://graph.microsoft.com/v1.0/users/24ed5b1c-cd45-4cf4-86e2-d818c48a1b05?$select=displayName,id,userPrincipalName,city,country

 10. delete user
  
