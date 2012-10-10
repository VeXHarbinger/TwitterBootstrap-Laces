namespace Bootstrap.Laces
{
    /// <summary>
    /// Button styles can be applied to anything with the .btn class applied. However, typically you'll want to apply these to only <a> and <button> elements for the best rendering.
    /// </summary>
    /// <remarks>
    /// Cross browser compatibility
    /// IE9 doesn't crop background gradients on rounded corners, so we remove it. Related, IE9 jankifies disabled button elements, rendering text gray with a nasty text-shadow that we cannot fix.
    /// </remarks>
    public enum ButtonStatuses
    {
        /// <summary>
        /// Standard gray button with gradient
        /// </summary>
        Default,

        /// <summary>
        /// Provides extra visual weight and identifies the primary action in a set of buttons
        /// </summary>
        Primary,

        /// <summary>
        /// Used as an alternative to the default styles
        /// </summary>
        Info,

        /// <summary>
        /// Indicates a successful or positive action
        /// </summary>
        Success,

        /// <summary>
        /// Indicates caution should be taken with this action
        /// </summary>
        Warning,

        /// <summary>
        /// Indicates a dangerous or potentially negative action
        /// </summary>
        Danger,

        /// <summary>
        /// Alternate dark gray button, not tied to a semantic action or use
        /// </summary>
        Inverse,

        /// <summary>
        /// Deemphasize a button by making it look like a link while maintaining button behavior
        /// </summary>
        Link
    }
}