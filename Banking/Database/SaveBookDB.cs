﻿using Banking.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Database
{
    public class SaveBookDB
    {
        private static SaveBookDB _ins;
        public static SaveBookDB Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new SaveBookDB();
                return _ins;
            }
            private set => _ins = value;
        }

        private ObservableCollection<SaveBook> saveBooks = new ObservableCollection<SaveBook>
        {
            new SaveBook()
            {
                SaveBookID = "SB0001",
                CustomerID = "KH0001",
                Money = 100000,
                Tern = "1 tháng - 12.00%",
                Type = "Lãi vào tài khoản nguồn",
                Created = DateTime.Now
            },
            new SaveBook()
            {
                SaveBookID = "SB0002",
                CustomerID = "KH0001",
                Money = 110000,
                Tern = "1 tháng - 12.00%",
                Type = "Lãi vào tài khoản nguồn",
                Created = DateTime.Now
            },
            new SaveBook()
            {
                SaveBookID = "SB0003",
                CustomerID = "KH0001",
                Money = 120000,
                Tern = "2 tháng - 24.00%",
                Type = "Lãi vào tài khoản nguồn",
                Created = DateTime.Now
            },
            new SaveBook()
            {
                SaveBookID = "SB0004",
                CustomerID = "KH0001",
                Money = 130000,
                Tern = "3 tháng - 36.00%",
                Type = "Lãi vào sổ tiết kiệm",
                Created = DateTime.Now
            },
            new SaveBook()
            {
                SaveBookID = "SB0005",
                CustomerID = "KH0001",
                Money = 140000,
                Tern = "4 tháng - 48.00%",
                Type = "Lãi vào sổ tiết kiệm",
                Created = DateTime.Now
            },
        };

        public ObservableCollection<SaveBook> getSaveBook()
        {
            return saveBooks;
        }

        public string getMaxId()
        {
            return saveBooks.Max(sb => sb.SaveBookID);
        }

        public SaveBook createSaveBook(SaveBook saveBook)
        {
            saveBooks.Add(saveBook);
            return saveBook;
        }
    }
}
