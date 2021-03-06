// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkVirtualAppliance : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BootStrapConfigurationBlob))
            {
                writer.WritePropertyName("bootStrapConfigurationBlob");
                writer.WriteStartArray();
                foreach (var item in BootStrapConfigurationBlob)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                writer.WriteObjectValue(VirtualHub);
            }
            if (Optional.IsCollectionDefined(CloudInitConfigurationBlob))
            {
                writer.WritePropertyName("cloudInitConfigurationBlob");
                writer.WriteStartArray();
                foreach (var item in CloudInitConfigurationBlob)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualApplianceAsn))
            {
                writer.WritePropertyName("virtualApplianceAsn");
                writer.WriteNumberValue(VirtualApplianceAsn.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkVirtualAppliance DeserializeNetworkVirtualAppliance(JsonElement element)
        {
            Optional<ManagedServiceIdentity> identity = default;
            Optional<VirtualApplianceSkuProperties> sku = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<string>> bootStrapConfigurationBlob = default;
            Optional<SubResource> virtualHub = default;
            Optional<IList<string>> cloudInitConfigurationBlob = default;
            Optional<long> virtualApplianceAsn = default;
            Optional<IReadOnlyList<VirtualApplianceNicProperties>> virtualApplianceNics = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = ManagedServiceIdentity.DeserializeManagedServiceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = VirtualApplianceSkuProperties.DeserializeVirtualApplianceSkuProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("bootStrapConfigurationBlob"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            bootStrapConfigurationBlob = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualHub"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualHub = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cloudInitConfigurationBlob"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            cloudInitConfigurationBlob = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceAsn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualApplianceAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceNics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualApplianceNicProperties> array = new List<VirtualApplianceNicProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualApplianceNicProperties.DeserializeVirtualApplianceNicProperties(item));
                            }
                            virtualApplianceNics = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkVirtualAppliance(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), identity.Value, sku.Value, etag.Value, Optional.ToList(bootStrapConfigurationBlob), virtualHub.Value, Optional.ToList(cloudInitConfigurationBlob), Optional.ToNullable(virtualApplianceAsn), Optional.ToList(virtualApplianceNics), Optional.ToNullable(provisioningState));
        }
    }
}
