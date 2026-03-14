using System;

namespace WarehouseAccounting
{
    public class User
    {
        public int id { get; set; }              // Соответствует полю id в БД
        public string name { get; set; }          // Соответствует полю name
        public string email { get; set; }         // Соответствует полю email
        public string password { get; set; }      // Соответствует полю password
        public string role { get; set; }          // Соответствует полю role
    }
}