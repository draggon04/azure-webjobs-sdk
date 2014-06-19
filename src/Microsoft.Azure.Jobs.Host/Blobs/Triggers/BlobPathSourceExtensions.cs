﻿using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Jobs.Host.Blobs.Triggers
{
    internal static class BlobPathSourceExtensions
    {
        public static IReadOnlyDictionary<string, Type> CreateBindingDataContract(this IBlobPathSource path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            Dictionary<string, Type> contract = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

            foreach (string parameterName in path.ParameterNames)
            {
                contract.Add(parameterName, typeof(string));
            }

            return contract;
        }
    }
}