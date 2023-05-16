class Program
{
    static int Main()
    {
        List<Lab> locationGroups = new List<Lab> {
            new Lab { Location = 1, Level = Levels.A },
            new Lab { Location = 1, Level = Levels.A },
            new Lab { Location = 1, Level = Levels.A },
            new Lab { Location = 1, Level = Levels.A },
            new Lab { Location = 2, Level = Levels.B },
            new Lab { Location = 2, Level = Levels.C },
            new Lab { Location = 1, Level = Levels.A },
            new Lab { Location = 3, Level = Levels.B },
            new Lab { Location = 3, Level = Levels.C },
            new Lab { Location = 2, Level = Levels.B },
            new Lab { Location = 1, Level = Levels.B },
            new Lab { Location = 3, Level = Levels.A },
            new Lab { Location = 2, Level = Levels.A },
            new Lab { Location = 1, Level = Levels.C },
            new Lab { Location = 1, Level = Levels.C },
            new Lab { Location = 1, Level = Levels.B },
        };

        foreach (var levelGroups in locationGroups
            .GroupBy(x => new { LocationKey = x.Location, LevelKey = x.Level })
            )
        {
            foreach (var item in levelGroups.Distinct())
            {
                Console.WriteLine($"Group {item.Location}/{item.Level}: {levelGroups.Count()}");
            }
            //
        }
        return 0;
    }
}

public struct Lab
{
    public int Location { get; set; }
    public Levels Level { get; set; }
}

public enum Levels { A, B, C }