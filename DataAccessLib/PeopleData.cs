﻿using DataAccessLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class PeopleData : IPeopleData
    {
        private readonly ISQLDataAccess _db;

        public PeopleData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "select * from dbo.People";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InserPerson(PersonModel person)
        {
            string sql = @"insert into dbo.People (FirstName, LastName, EmailAddress)
                            values (@FirstName, @LastName, @EmailAddress);";

            return _db.SaveData(sql, person);
        }
    }
}
