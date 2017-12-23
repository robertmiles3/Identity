﻿using System;
using Microsoft.Extensions.Identity.Claims;

namespace Microsoft.AspNetCore.Identity
{
    internal class ActionUserClaimsMappingProvider<TUser> : IUserClaimsMappingsProvider<TUser> where TUser : class
    {
        private readonly Action<UserClaimsModel<TUser>> _configure;
        private Action<UserClaimsModel<TUser>> configure;

        public ActionUserClaimsMappingProvider(Action<UserClaimsModel<TUser>> configure)
        {
            _configure = configure;
        }

        public void ConfigureMappings(UserClaimsModel<TUser> claimMappings) => configure(claimMappings);
    }
}