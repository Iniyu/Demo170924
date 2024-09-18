using DataverseModel;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContactAddress.ContactAddress.Helper
{
    static class EntityExtension
    {
        internal static bool ContainsAnyKey(this Entity entity, params string[] attributeNames)
        {
            if (entity == null) return false;
            return attributeNames.Any(an => entity.Attributes.Contains(an?.ToLower()));
        }

        public static TEntity MergeEntity<TEntity>(this TEntity instance, TEntity toMerge)
            where TEntity : Entity, new()
        { 
        TEntity retVal = new TEntity();
        retVal.Attributes.AddRange(instance.Attributes);
            retVal.Id = instance.Id;
            foreach (string key in toMerge?.Attributes.Keys.Where(v => !retVal.Attributes.ContainsKey(v)) ?? new string[0])
            {
                retVal[key] = toMerge[key];
            }

            return retVal;
        }
    }
}
