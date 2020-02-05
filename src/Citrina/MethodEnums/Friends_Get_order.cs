namespace Citrina
{
    /// <summary>
    /// Sort order: , 'name' — by name (enabled only if the 'fields' parameter is used), 'hints' — by rating, similar to how friends are sorted in My friends section, , This parameter is available only for [vk.com/dev/standalone|desktop applications].
    /// </summary>
    public enum Friends_Get_order
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "hints")]
        Hints,
    }
}
