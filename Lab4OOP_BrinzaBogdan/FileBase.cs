public abstract class FileBase
{
    public string FileName { get; set; }
    public string Extension { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastUpdatedDate { get; set; }

    public abstract void DisplayInfo();
}
