using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Section, suggestions are retrieved in. Available values: *countries — request of a list of countries. If q is not set or blank, a short list of countries is shown. Otherwise, a full list of countries is shown. *regions — requested list of regions. 'country' parameter is required. *cities — requested list of cities. 'country' parameter is required. *districts — requested list of districts. 'cities' parameter is required. *stations — requested list of subway stations. 'cities' parameter is required. *streets — requested list of streets. 'cities' parameter is required. *schools — requested list of educational organizations. 'cities' parameter is required. *interests — requested list of interests. *positions — requested list of positions (professions). *group_types — requested list of group types. *religions — requested list of religious commitments. *browsers — requested list of browsers and mobile devices.
    /// </summary>
    public enum AdsSuggestionsSection
    {
        [EnumMember(Value = "countries")]
        Countries,
        [EnumMember(Value = "regions")]
        Regions,
        [EnumMember(Value = "cities")]
        Cities,
        [EnumMember(Value = "districts")]
        Districts,
        [EnumMember(Value = "stations")]
        Stations,
        [EnumMember(Value = "streets")]
        Streets,
        [EnumMember(Value = "schools")]
        Schools,
        [EnumMember(Value = "interests")]
        Interests,
        [EnumMember(Value = "positions")]
        Positions,
        [EnumMember(Value = "group_types")]
        GroupTypes,
        [EnumMember(Value = "religions")]
        Religions,
        [EnumMember(Value = "browsers")]
        Browsers,
    }
}
