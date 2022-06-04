using System.Data.SQLite;

string cs = @"URI=file:D:\OneDrive - Xylos NV\Documenten\repos\SQLite Test\test.db";

using var con = new SQLiteConnection(cs);
con.Open();

using var cmd = new SQLiteCommand(con);

cmd.CommandText = "DROP TABLE IF EXISTS cars";
cmd.ExecuteNonQuery();

cmd.CommandText = @"CREATE TABLE cars(id INTEGER PRIMARY KEY, name TEXT, price INT)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
cmd.ExecuteNonQuery();

string stm = "SELECT * FROM cars LIMIT 5";

using var cmd1 = new SQLiteCommand(stm, con);
using SQLiteDataReader rdr = cmd1.ExecuteReader();

while (rdr.Read())
{
    Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetInt32(2)}");
}
