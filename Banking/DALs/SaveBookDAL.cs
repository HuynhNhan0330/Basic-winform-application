using Banking.Database;
using Banking.Model;
using Banking.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.DALs
{
    public class SaveBookDAL
    {
        private static SaveBookDAL _ins;
        public static SaveBookDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new SaveBookDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public ObservableCollection<SaveBook> getSaveBook(string customerID)
        {
            try
            {
                ObservableCollection<SaveBook> saveBooks = SaveBookDB.Ins.getSaveBook();
                ObservableCollection<SaveBook> saveBooksNew = new ObservableCollection<SaveBook>(saveBooks.Where(sb => sb.CustomerID == customerID));

                return saveBooksNew;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SaveBook createSaveBook(SaveBook saveBook)
        {
            try
            {
                saveBook.SaveBookID = Helper.nextCode(SaveBookDB.Ins.getMaxId(), "SB");

                return SaveBookDB.Ins.createSaveBook(saveBook);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
