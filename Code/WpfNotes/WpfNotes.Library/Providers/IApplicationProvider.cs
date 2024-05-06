namespace WpfNotes.Library.Providers;

/// <summary>
/// Application Provider
/// </summary>
public interface IApplicationProvider
{
    /// <summary>
    /// Confirm
    /// </summary>
    Func<DialogModel, Task<bool>> Confirm { get; set; }

    /// <summary>
    /// Upsert
    /// </summary>
    Func<DialogModel, Task<bool>> Upsert { get; set; }

    /// <summary>
    /// List
    /// </summary>
    /// <returns>List of Notes</returns>
    Task ListAsync();

    /// <summary>
    /// Content
    /// </summary>
    ContentModel Content { get; }
}
