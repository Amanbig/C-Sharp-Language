using System;

namespace EnumsExample
{
    #region Basic Enum
    /// <summary>
    /// Basic enum for days of the week
    /// </summary>
    enum Days
    {
        Sunday = 1,    // Explicitly setting first value
        Monday,        // 2
        Tuesday,       // 3
        Wednesday,     // 4
        Thursday,      // 5
        Friday,        // 6
        Saturday       // 7
    }
    #endregion

    #region Enum with Different Base Type
    /// <summary>
    /// Enum using byte as base type to save memory
    /// </summary>
    enum Month : byte
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    #endregion

    #region Flags Enum
    /// <summary>
    /// Enum using [Flags] attribute for bitwise operations
    /// </summary>
    [Flags]
    enum Permissions
    {
        None = 0,          // 0000
        Read = 1,          // 0001
        Write = 2,         // 0010
        Execute = 4,       // 0100
        Delete = 8,        // 1000
        All = Read | Write | Execute | Delete  // 1111
    }
    #endregion

    #region Enum for Status
    /// <summary>
    /// Enum representing task status with custom values
    /// </summary>
    enum TaskStatus
    {
        NotStarted = 0,
        InProgress = 25,
        Halfway = 50,
        AlmostDone = 75,
        Completed = 100
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Enums Demonstration\n");

            // 1. Basic Enum Usage
            Console.WriteLine("1. Basic Enum Usage:");
            Days today = Days.Wednesday;
            Console.WriteLine($"Today is {today}");
            Console.WriteLine($"Day number: {(int)today}");

            // Converting string to enum
            Days parsedDay = Enum.Parse<Days>("Friday");
            Console.WriteLine($"Parsed day: {parsedDay}");

            // 2. Month Enum Usage
            Console.WriteLine("\n2. Month Enum Usage:");
            Month currentMonth = Month.August;
            Console.WriteLine($"Current month: {currentMonth}");
            Console.WriteLine($"Month number: {(byte)currentMonth}");

            // 3. Flags Enum Usage
            Console.WriteLine("\n3. Flags Enum Usage:");
            Permissions userPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine($"User permissions: {userPermissions}");

            // Checking permissions
            bool canRead = (userPermissions & Permissions.Read) == Permissions.Read;
            bool canDelete = (userPermissions & Permissions.Delete) == Permissions.Delete;
            Console.WriteLine($"Can read: {canRead}");
            Console.WriteLine($"Can delete: {canDelete}");

            // 4. Task Status Usage
            Console.WriteLine("\n4. Task Status Usage:");
            TaskStatus projectStatus = TaskStatus.InProgress;
            Console.WriteLine($"Project is {projectStatus} ({(int)projectStatus}% complete)");

            // 5. Enum Methods
            Console.WriteLine("\n5. Enum Methods:");
            
            // Get all values of an enum
            Console.WriteLine("Days of the week:");
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine($"- {day}");
            }

            // Try parsing enum
            Console.WriteLine("\nTryParse example:");
            if (Enum.TryParse("Tuesday", out Days resultDay))
            {
                Console.WriteLine($"Successfully parsed: {resultDay}");
            }

            // Invalid enum value
            Console.WriteLine("\nInvalid enum value:");
            if (!Enum.TryParse("InvalidDay", out Days invalidDay))
            {
                Console.WriteLine("Failed to parse invalid day name");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}