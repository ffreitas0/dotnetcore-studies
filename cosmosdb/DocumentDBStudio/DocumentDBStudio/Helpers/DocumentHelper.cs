﻿using System;
using System.Collections.Generic;
using Microsoft.Azure.DocumentDBStudio.Properties;
using Microsoft.Azure.Documents;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.DocumentDBStudio.Helpers
{
    static class DocumentHelper
    {
        private static readonly List<string> SystemResourceNames = new List<string>
        {
            "_rid",
            "_etag",
            "_ts",
            "_self",
            "_id",
            "_attachments",

            "_docs",
            "_sprocs",
            "_triggers",
            "_udfs",
            "_conflicts",

            "_colls",
            "_users"

        };

        public static string AssignNewIdToDocument(string json)
        {
            try
            {
                dynamic obj = JObject.Parse(json);
                obj.id = Guid.NewGuid();
                json = obj.ToString();
            }
            catch { }
            
            return json;
        }
        public static string RemoveInternalDocumentValues(string json)
        {
            if (Settings.Default.HideDocumentSystemProperties)
            {
                try
                {
                    dynamic obj = JObject.Parse(json);
                    var removeList = new List<string>();
                    foreach (var prop in obj)
                    {
                        if (SystemResourceNames.Contains(prop.Name.ToString()))
                        {
                            removeList.Add(prop.Name);
                        }
                        /*if (prop.Name.ToString().StartsWith("_"))
                        {
                            removeList.Add(prop.Name);
                        }*/
                    }
                    foreach (var remove in removeList)
                    {
                        obj.Remove(remove);
                    }
                    json = obj.ToString();
                }
                catch { }
            }
            return json;
        }

        public static void SortDocuments(bool useCustom, List<dynamic> docs, string sortField, bool reverseSort)
        {
            if (useCustom)
            {
                if (reverseSort)
                {
                    docs.Sort( (second, first) => string.Compare(first.GetPropertyValue<string>(sortField), second.GetPropertyValue<string>(sortField), StringComparison.Ordinal));
                }
                else
                {
                    docs.Sort( (first, second) => string.Compare(first.GetPropertyValue<string>(sortField), second.GetPropertyValue<string>(sortField), StringComparison.Ordinal));
                }

            }
            else
            {
                docs.Sort((first, second) => string.Compare(((Document)first).Id, ((Document)second).Id, StringComparison.Ordinal));
            }
        }
    }
}
