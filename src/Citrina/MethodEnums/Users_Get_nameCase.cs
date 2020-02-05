namespace Citrina
{
    /// <summary>
    /// Case for declension of user name and surname: 'nom' — nominative (default), 'gen' — genitive , 'dat' — dative, 'acc' — accusative , 'ins' — instrumental , 'abl' — prepositional.
    /// </summary>
    public enum Users_Get_nameCase
    {
        [EnumMember(Value = "nom")]
        Nominative,
        [EnumMember(Value = "gen")]
        Genitive,
        [EnumMember(Value = "dat")]
        Dative,
        [EnumMember(Value = "acc")]
        Accusative,
        [EnumMember(Value = "ins")]
        Instrumental,
        [EnumMember(Value = "abl")]
        Prepositional,
    }
}
