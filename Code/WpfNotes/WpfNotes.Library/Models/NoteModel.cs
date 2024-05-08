namespace WpfNotes.Library.Models;

/// <summary>
/// Note Model
/// </summary>
public class NoteModel : ObservableBase
{
    private int? _id = null;
    private string _title = string.Empty;
    private string _content = string.Empty;
    private string _background = "#ffc476";

    /// <summary>
    /// Id
    /// </summary>
    public int? Id 
    { 
        get => _id; 
        set => SetProperty(ref _id, value); 
    }

    /// <summary>
    /// Title
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string Title 
    { 
        get => _title; 
        set => SetProperty(ref _title, value); 
    }

    /// <summary>
    /// Content
    /// </summary>
    [Required]
    [MaxLength(255)]
    public string Content 
    { 
        get => _content; 
        set => SetProperty(ref _content, value); 
    }

    /// <summary>
    /// Background
    /// </summary>
    [Required]
    [MaxLength(10)]
    public string Background 
    { 
        get => _background; 
        set => SetProperty(ref _background, value);
    }
}
