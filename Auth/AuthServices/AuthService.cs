﻿using Microsoft.Identity.Client;

namespace AuthServices;

public class AuthService: BaseAuthService
{
    public AuthService()
    {
        authenticationClient = PublicClientApplicationBuilder.Create(Constants.ClientId)
            .WithRedirectUri($"msal{Constants.ClientId}://auth")
#if ANDROID
            .WithParentActivityOrWindow(() => Platform.CurrentActivity)
#endif
            .Build();
    }
}