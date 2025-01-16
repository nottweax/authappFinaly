using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//в сборках необходимо добавить путь на mysqlconnector(надо скачать и установить) (C:\Program Files (x86)\MySQL\MySQL Connector NET 9.1\MySql.Data.dll) , затем скачать mamp, установить, запустить локальный сервер
//с помощью mamp открыть локалхост phpmyadmin и создать там бд authapp, таблицу users, и создать столбы по формату как в файле reg.cs
namespace AuthApp
{
   class db
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=authapp"); //подключение к локальной бд, развернутой через mamp(бесплатно можно скачать), управление подключение через phpmyadmin, там в приложении все понятно
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }


    }
}
