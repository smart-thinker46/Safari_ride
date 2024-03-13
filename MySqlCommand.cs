namespace MusicApp
{
    internal class MySqlCommand
    {
    public  string v;
        public MySqlConnection connection;
        internal string CommandText;
        private MysqlConnection connection1;
        private MysqlConnection connection2;

        public MySqlCommand(string v, MysqlConnection connection)
        {
            this.v = v;
            this.connection = connection;
        }

        public MySqlCommand(string v, MysqlConnection connection1)
        {
            this.v = v;
            this.connection1 = connection1;
        }

        public MySqlCommand(string v, MysqlConnection connection2)
        {
            this.v = v;
            this.connection2 = connection2;
        }

        public MySqlCommand(string v, MysqlConnection connection3)
        {
            this.v = v;
        }

        public object Parameters { get; internal set; }
    }

    public class MysqlConnection
    {
    }

    public class MySqlConnection
    {
    }
}