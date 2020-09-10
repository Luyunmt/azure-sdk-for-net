// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolOperation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ElasticPoolOperation DeserializeElasticPoolOperation(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> elasticPoolName = default;
            Optional<string> operation = default;
            Optional<string> operationFriendlyName = default;
            Optional<int> percentComplete = default;
            Optional<string> serverName = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> state = default;
            Optional<int> errorCode = default;
            Optional<string> errorDescription = default;
            Optional<int> errorSeverity = default;
            Optional<bool> isUserError = default;
            Optional<DateTimeOffset> estimatedCompletionTime = default;
            Optional<string> description = default;
            Optional<bool> isCancellable = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("elasticPoolName"))
                        {
                            elasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operation"))
                        {
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationFriendlyName"))
                        {
                            operationFriendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"))
                        {
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverName"))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorCode"))
                        {
                            errorCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("errorDescription"))
                        {
                            errorDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorSeverity"))
                        {
                            errorSeverity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isUserError"))
                        {
                            isUserError = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("estimatedCompletionTime"))
                        {
                            estimatedCompletionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCancellable"))
                        {
                            isCancellable = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ElasticPoolOperation(id.Value, name.Value, type.Value, elasticPoolName.Value, operation.Value, operationFriendlyName.Value, Optional.ToNullable(percentComplete), serverName.Value, Optional.ToNullable(startTime), state.Value, Optional.ToNullable(errorCode), errorDescription.Value, Optional.ToNullable(errorSeverity), Optional.ToNullable(isUserError), Optional.ToNullable(estimatedCompletionTime), description.Value, Optional.ToNullable(isCancellable));
        }
    }
}