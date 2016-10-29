using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDataExampl
{
public class ORM
{
    public static void GetTableByORM()
    {
        using (testEntities1 db = new testEntities1())
        {
            //var listEF = db.team;
            //var listFilter2 = from a in db.team
            //                  join b in db.players on a.ID equals b.ID_team
            //                  select b.Surname;
            //foreach (var item in listFilter2)
            //{
            //    Console.WriteLine(item);
            //}
            team _insert = new team();
            _insert.TeamName = "Barca";
            _insert.League = "PD";
            db.team.Add(_insert);
            db.SaveChanges();
        }
    }
}
}
