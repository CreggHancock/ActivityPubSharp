// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.

using ActivityPub.Common.Util;
using ActivityPub.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ActivityPub.Common;

public static class CommonModule
{
    public static void TryAddCommonModule(this IServiceCollection services)
    {
        services.TryAddTypesModule();
        
        services.TryAddSingleton<ActivityPubOptions>();
    }
}