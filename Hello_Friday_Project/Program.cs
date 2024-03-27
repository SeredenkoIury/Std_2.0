

// using System;
// using System.Speech.Synthesis;
// using System.Speech.Recognition;
// using System.Data.SQLite;
// using System.Collections.Generic;
// using System.Threading.Tasks;

// class Program
// {
//     static SpeechSynthesizer synthesizer = new SpeechSynthesizer();
//     static SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
//     static Dictionary<string, Action<string[]>> actions = new Dictionary<string, Action<string[]>>();
//     static List<string> commandHistory = new List<string>();
//     static int maxHistorySize = 1000; // Максимальное количество команд в истории

//     static void Main(string[] args)
//     {
//         InitializeSpeechComponents();

//         Console.WriteLine("Запуск голосового помощника. Говорите!");

//         recognizer.RecognizeAsync(RecognizeMode.Multiple);

//         Console.ReadLine();
//     }

//     static void InitializeSpeechComponents()
//     {
//         // Инициализация голосового синтезатора
//         synthesizer.SetOutputToDefaultAudioDevice();
//         synthesizer.SelectVoiceByHints(VoiceGender.Female);

//         // Инициализация голосового распознавателя
//         recognizer.SetInputToDefaultAudioDevice();
//         recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

//         LoadCommandsFromDatabase();
//     }

//     static void LoadCommandsFromDatabase()
//     {
//         string connectionString = "Data Source=commands.db;Version=3;";

//         // Создание таблицы команд, если она не существует
//         using (SQLiteConnection connection = new SQLiteConnection(connectionString))
//         {
//             connection.Open();
//             string createTableQuery = "CREATE TABLE IF NOT EXISTS Commands (Command TEXT PRIMARY KEY, Action TEXT)";
//             SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
//             command.ExecuteNonQuery();
//         }

//         // Загрузка команд и действий из базы данных
//         using (SQLiteConnection connection = new SQLiteConnection(connectionString))
//         {
//             connection.Open();
//             string selectQuery = "SELECT * FROM Commands";
//             SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
//             SQLiteDataReader reader = command.ExecuteReader();
//             while (reader.Read())
//             {
//                 string commandText = reader["Command"].ToString();
//                 string actionText = reader["Action"].ToString();
//                 actions.Add(commandText, GetAction(actionText));
//                 UpdateGrammar(commandText); // Обновляем грамматику распознавания
//             }
//         }
//     }

//     static void UpdateGrammar(string command)
//     {
//         Choices choices = new Choices(command);
//         Grammar grammar = new Grammar(new GrammarBuilder(choices));
//         recognizer.LoadGrammarAsync(grammar);
//     }

//     static void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
//     {
//         string command = e.Result.Text;
//         Console.WriteLine("Вы сказали: " + command);

//         if (actions.ContainsKey(command))
//         {
//             ExecuteCommand(command);
//         }
//         else
//         {
//             synthesizer.SpeakAsync("Простите, но я не понимаю вашу команду. Пожалуйста, повторите.");
//             Task.Delay(2000).Wait(); // Подождать 2 секунды перед повтором команды
//             synthesizer.SpeakAsyncCancelAll();
//         }
//     }

//     static void ExecuteCommand(string command)
//     {
//         List<string> parameters = GetCommandParameters(command);
//         actions[command].Invoke(parameters.ToArray());
//         AddToCommandHistory(command);
//     }

//     static List<string> GetCommandParameters(string command)
//     {
//         // Здесь можно добавить логику для извлечения параметров из команды
//         // Например, используя регулярные выражения или разделение строки на слова
//         return new List<string>();
//     }

//     static Action<string[]> GetAction(string actionName)
//     {
//         switch (actionName)
//         {
//             case "Greet":
//                 return Greet;
//             case "Search":
//                 return Search;
//             case "Exit":
//                 return Exit;
//             default:
//                 return (parameters) => { };
//         }
//     }

//     static void Greet(string[] parameters)
//     {
//         synthesizer.SpeakAsync("Привет! Чем могу помочь вам?");
//     }

//     static void Search(string[] parameters)
//     {
//         if (parameters.Count > 0)
//         {
//             string query = string.Join(" ", parameters);
//             synthesizer.SpeakAsync("Выполняю поиск в открытых базах данных: " + query);
//             // Здесь можно добавить код для выполнения поиска в интернете по указанному запросу
//         }
//         else
//         {
//             synthesizer.SpeakAsync("Укажите подробный запрос для поиска.");
//         }
//     }

//     static void Exit(string[] parameters)
//     {
//         synthesizer.SpeakAsync("До свидания!");
//         Environment.Exit(0);
//     }

//     static void AddToCommandHistory(string command)
//     {
//         commandHistory.Add(command);
//         if (commandHistory.Count > maxHistorySize)
//         {
//             commandHistory.RemoveAt(0); // Удаляем самую старую команду, если превышен максимальный размер истории
//         }
//     }
// }






//=================================================================================================================
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static Dictionary<string, Func<string>> actions = new Dictionary<string, Func<string>>();

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Запуск голосового помощника. Введите команды или поболтайте!");

//         LoadCommands();

//         while (true)
//         {
//             string input = Console.ReadLine().ToLower(); // Принимаем ввод пользователя и переводим в нижний регистр
//             if (actions.ContainsKey(input))
//             {
//                 string response = actions[input]();
//                 Console.WriteLine(response); // Выводим ответ в терминал
//             }
//             else
//             {
//                 string response = Chat(input);
//                 Console.WriteLine(response); // Выводим ответ в терминал
//             }
//         }
//     }

//     static void LoadCommands()
//     {
//         actions.Add("привет", () => "Привет! Чем могу помочь?");
//         actions.Add("пока", () => "До свидания!");
//         // Добавьте другие команды...
//     }

//     static string Chat(string input)
//     {
//         // Простой чат-бот, который отвечает на общие вопросы и фразы
//         switch (input)
//         {
//             case "как дела?":
//                 return "У меня все отлично, спасибо! А у вас?";
//             case "что делаешь?":
//                 return "Отвечаю на ваши вопросы и команды.";
//             case "как тебя зовут?":
//                 return "Меня зовут Пятница.";
//             default:
//                 return "Интересно. Расскажите еще что-нибудь.";
//         }
//     }
// }







//=================================================================================================================





//=================================================================================================================

using System;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static SpeechSynthesizer synthesizer = new SpeechSynthesizer();
    static SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
    static Dictionary<string, Action<string[]>> actions = new Dictionary<string, Action<string[]>>();
    static List<string> commandHistory = new List<string>();
    static int maxHistorySize = 1000; // Максимальное количество команд в истории

    static void Main(string[] args)
    {
        InitializeSpeechComponents();

        Console.WriteLine("Запуск голосового помощника. Говорите!");

        recognizer.RecognizeAsync(RecognizeMode.Multiple);

        Console.ReadLine();
    }

    static void InitializeSpeechComponents()
    {
        // Инициализация голосового синтезатора
        synthesizer.SetOutputToDefaultAudioDevice();
        synthesizer.SelectVoiceByHints(VoiceGender.Female);

        // Инициализация голосового распознавателя
        recognizer.SetInputToDefaultAudioDevice();
        recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

        LoadCommandsFromDatabase();
    }

    static void LoadCommandsFromDatabase()
    {
        string connectionString = "Data Source=commands.db;Version=3;";

        // Создание таблицы команд, если она не существует
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Commands (Command TEXT PRIMARY KEY, Action TEXT)";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }

        // Загрузка команд и действий из базы данных
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Commands";
            SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string commandText = reader["Command"].ToString();
                string actionText = reader["Action"].ToString();
                actions.Add(commandText, GetAction(actionText));
                UpdateGrammar(commandText); // Обновляем грамматику распознавания
            }
        }
    }

    static void UpdateGrammar(string command)
    {
        Choices choices = new Choices(command);
        Grammar grammar = new Grammar(new GrammarBuilder(choices));
        recognizer.LoadGrammarAsync(grammar);
    }

    static void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
        string command = e.Result.Text;
        Console.WriteLine("Вы сказали: " + command);

        if (actions.ContainsKey(command))
        {
            ExecuteCommand(command);
        }
        else
        {
            synthesizer.SpeakAsync("Извините, я не поняла вашу команду. Пожалуйста, повторите.");
            Task.Delay(2000).Wait(); // Подождать 2 секунды перед повтором команды
            synthesizer.SpeakAsyncCancelAll();
        }
    }

    static void ExecuteCommand(string command)
    {
        List<string> parameters = GetCommandParameters(command);
        actions[command].Invoke(parameters.ToArray());
        AddToCommandHistory(command);
    }

    static List<string> GetCommandParameters(string command)
    {
        // Здесь можно добавить логику для извлечения параметров из команды
        // Например, используя регулярные выражения или разделение строки на слова
        return new List<string>();
    }

    static Action<string[]> GetAction(string actionName)
    {
        switch (actionName)
        {
            case "Greet":
                return Greet;
            case "Search":
                return Search;
            case "Exit":
                return Exit;
            default:
                return (parameters) => { };
        }
    }

    static void Greet(string[] parameters)
    {
        synthesizer.SpeakAsync("Привет! Чем могу помочь?");
    }

    static void Search(string[] parameters)
    {
        if (parameters.Count > 0)
        {
            string query = string.Join(" ", parameters);
            synthesizer.SpeakAsync("Выполняю поиск в открытых базах данных: " + query);
            // Здесь можно добавить код для выполнения поиска в интернете по указанному запросу
        }
        else
        {
            synthesizer.SpeakAsync("Укажите подробный запрос для поиска в открытых базах данных.");
        }
    }

    static void Exit(string[] parameters)
    {
        synthesizer.SpeakAsync("До свидания!");
        Environment.Exit(0);
    }

    static void AddToCommandHistory(string command)
    {
        commandHistory.Add(command);
        if (commandHistory.Count > maxHistorySize)
        {
            commandHistory.RemoveAt(0); // Удаляем самую старую команду, если превышен максимальный размер истории
        }
    }
}







