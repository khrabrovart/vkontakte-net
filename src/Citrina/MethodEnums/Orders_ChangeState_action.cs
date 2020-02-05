namespace Citrina
{
    /// <summary>
    /// action to be done with the order. Available actions: *cancel — to cancel unconfirmed order. *charge — to confirm unconfirmed order. Applies only if processing of [vk.com/dev/payments_status|order_change_state] notification failed. *refund — to cancel confirmed order.
    /// </summary>
    public enum Orders_ChangeState_action
    {
        [EnumMember(Value = "cancel")]
        Cancel,
        [EnumMember(Value = "charge")]
        Charge,
        [EnumMember(Value = "refund")]
        Refund,
    }
}
