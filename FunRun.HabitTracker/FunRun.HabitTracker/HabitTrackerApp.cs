﻿using Spectre.Console;
using System.Data;
using System.Data.Common;


namespace FunRun.HabitTracker;

public class HabitTrackerApp
{
    private readonly IDbConnection _connection;

    public HabitTrackerApp(IDbConnection connection)
    {
        _connection = connection;
    }
    public async Task RunApp()
    {
        while (true)
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("HabitTracker").Centered().Color(Color.Blue));

            AnsiConsole.MarkupLine("[blue] Inpired by the [link=https://thecsharpacademy.com/project/12/habit-logger]C#Acadamy [/][/]");
            AnsiConsole.MarkupLine("");

            Console.ReadKey(true);
            Console.WriteLine(_connection.Database);
        }
    }
}
