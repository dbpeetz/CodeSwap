using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNGroupApp.Data
{
    public class File
    {
        public int FileId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }
        public int ShoppingListId { get; set; }
        public virtual ShoppingList ShoppingList { get; set; }
        public virtual ShoppingListItem ShoppingListItem { get; set; }
    }
}
