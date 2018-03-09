﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using Moq;

namespace Microsoft.VisualStudio.ProjectSystem.VS
{
    internal static class IProjectGuidServiceFactory
    {
        public static IProjectGuidService ImplementProjectGuid(Guid result)
        {
            var mock = new Mock<IProjectGuidService>();
            mock.Setup(s => s.ProjectGuid)
                .Returns(result);

            return mock.Object;
        }
    }
}
