using Simple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDataExampl
{
public class SimpleDataClass
{
    public static void GetTableBySD()
    {
        string ConnectionString = @"Data Source = PAWEL; Initial Catalog = test; Integrated Security = True";
        dynamic defaultDb = Database.OpenConnection(ConnectionString);
        //  var list = defaultDb.team.All();
        //var listFilter = defaultDb.team.All()
        //        .Select(defaultDb.players.Surname)
        //        .Join(defaultDb.players).On(defaultDb.players.ID_team == defaultDb.team.ID);
        //foreach (var item in listFilter)
        //{
        //    Console.WriteLine(item.Surname);
        //}

        defaultDb.team.Insert(TeamName: "Real", League: "PD");
    }
}
}
