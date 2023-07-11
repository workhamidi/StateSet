namespace StateSet.Dal.Enums
{
    public enum ActionTypeEnum
    {
        /// <summary>
        /// The actioner is suggesting that the request should move to the next state.
        /// next
        /// </summary>
        Approve,

        /// <summary>
        /// The actioner is suggesting that the request should move to the previous state.
        /// previous
        /// </summary>
        Deny,

        /// <summary>
        /// The actioner is suggesting that the request should move to the Cancelled state in the process.
        /// Cancelled
        /// </summary>
        Cancel,

        /// <summary>
        /// The actioner suggesting that the request be moved back to the Start state in the process.
        /// Start
        /// </summary>
        Restart,

        /// <summary>
        /// The actioner is suggesting that the request be moved all the way to the Completed state
        /// Completed
        /// </summary>
        Resolve
    }
}
