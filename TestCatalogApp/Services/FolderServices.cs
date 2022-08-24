using System.Collections.Generic;
using System.Linq;
using TestCatalogApp.Interfaces;
using TestCatalogApp.Models;

namespace TestCatalogApp.Services
{
    public class FolderServices : IFolderServices
    {
        private FolderContext _folderContext;

        public FolderServices(FolderContext folderContext)
        {
            _folderContext = folderContext;
        }

        public List<Folder> GetAllFolders()
        {
            
          var folderList= _folderContext.Folder.ToList();
            return folderList;
        }

        public Folder GetFolder(int id)
        {
            var folder = _folderContext.Folder.FirstOrDefault(i => i.Id == id);
            return folder;
        }
    }
}
