namespace TestCatalogApp.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string NameFolder { get; set; }
        public int? ParentFolderId { get; set; }

    }
}
