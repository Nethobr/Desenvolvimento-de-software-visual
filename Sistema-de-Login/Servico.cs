using System;
using System.IO;
using System.Collections.Generic;

namespace Sistema_de_Login
{
    class User
    {
        static int UID = 0;
        
        int id;
        string username;
        string hash;

        // Construtor
        public User (string u, string p)
        {
            id = getUID();
            username = u;
            SetUsername(u);
            ApplyHash(p);
        }
        
        static int getUID ()
        {
            UID ++;
            return UID;
        }   // Fim getUID

        private void ApplyHash (string pass)
        {
            // TODO aplicar hash
            hash = pass;
        }   // Fim ApplyHash

        
        public string GetUsername () 
        {
            return username;
        }   // Fim GetUsername

        public string GetHash () 
        {
            return hash;
        }   // Fim GetHash

        public void SetUsername (string u)
        {
            username = u;
        }   // Fim SetUsername

        public string Serialize ()
        {
            return id + "," + username + "," + hash;
        }   // Fim Serialize
    }   // Fim User

    class UserBase
    {
        string filename;

        // Criando uma lista
        List <User> usuarios;
        
        // Construtor
        public UserBase (string f)
        {
            filename = f;
            usuarios = new List<User>();

            LoadUsers();
        }

        void LoadUsers ()
        {
            // TODO carregar usuário do arquivo.
        }   // Fim LoadUsers

        public void AddUser(User u)
        {
            usuarios.Add(u);
        }   // Fim AddUser

        public void Save()
        {
            string output = "";

            foreach (User u in usuarios)
            {
                output += u.Serialize() + "\n";
            }   // Fim foreach

            File.WriteAllText(filename, output);
        }   // Fim Save 
    }   // Fim UserBase
}   // Fim Sistema_de_Login