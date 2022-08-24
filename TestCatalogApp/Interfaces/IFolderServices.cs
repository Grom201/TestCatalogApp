using System.Collections.Generic;
using TestCatalogApp.Models;

namespace TestCatalogApp.Interfaces
{
    public interface IFolderServices
    {
        public List<Folder> GetAllFolders();
        public Folder GetFolder(int id);
    }
}
