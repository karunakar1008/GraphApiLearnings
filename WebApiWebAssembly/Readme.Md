1. How to test protected Web apis from post man
- Create App registration (Graph-Quickstart)
- Expose API:api://8c9a7b51-9f71-43bb-b08d-42cf69b27403
- Add scope:
- api.scope (admin and users)
- Create App roles
- Manager (Users&Groups)
- Assign user in enterprise application
	
 "AzureAd": {
    "Instance": "https://login.microsoftonline.com/",
    "TenantId": "0014ebb3-2539-411a-b2c0-62546ee6e1f0",
    "ClientId": "8c9a7b51-9f71-43bb-b08d-42cf69b27403",
    "Scopes": "api.scope"
  }

2. Create another app resigration for postman client
-Configure authentication    
1. Add platform (single application)
 Redirect URi: https://oauth.pstmn.io/v1/callback
 Check boxes checked (Access tokens and Id tokens)

Configure Post man:

Authorization:
    Type: OAuth 2.0
    Grant Type: Implicit
    Call back url:https://oauth.pstmn.io/v1/callback
Auth Url: https://login.microsoftonline.com/0014ebb3-2539-411a-b2c0-62546ee6e1f0/oauth2/v2.0/authorize
ClientID:
Scope:api://8c9a7b51-9f71-43bb-b08d-42cf69b27403/api.scope


Learnt at: https://www.youtube.com/watch?v=5lRbtDSyjjs&list=PLW6IC4y81fVvqxtGevoDkut23QA2mvPnb&index=2
