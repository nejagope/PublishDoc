using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PublishDoc
{
    class Config
    {
        //paths
        //default path to sqlite database
        private const string DEFAULT_DB_PATH = "db.sqlite";
        //path to config file
        private const string CONFIG_FILE_PATH = "config.txt";

        //Var names in config file
        private const string SOURCE_PATH_VAR_NAME = "SOURCE_PATH";
        private const string PUBLISH_PATH_VAR_NAME = "PUBLISH_PATH";
        public const string DB_PATH_VAR_NAME = "DB_PATH";

        //public properties
        public static string SOURCE_PATH
        {
            get { return GetOption(SOURCE_PATH_VAR_NAME); }
            set { Options[SOURCE_PATH_VAR_NAME] = value; }
        }

        public static string PUBLISH_PATH
        {
            get { return GetOption(PUBLISH_PATH_VAR_NAME); }
            set { Options[PUBLISH_PATH_VAR_NAME] = value; }
        }

        public static string DB_PATH
        {
            get { return GetOption(DB_PATH_VAR_NAME) == null ? DEFAULT_DB_PATH : GetOption(DB_PATH_VAR_NAME); }
            set { Options[DB_PATH_VAR_NAME] = value; }
        }


        public static Dictionary<string, string> Options;
        public static Dictionary<int, string> Messages;

        public static bool Init(ref string Mensaje)
        {
            Options = new Dictionary<string, string>();

            string[] configs = File.ReadAllLines(CONFIG_FILE_PATH);
            foreach (var config in configs)
            {
                var parts = config.Split('=');
                if (parts.Length > 0)
                {
                    string key = parts[0].Trim();
                    string value = null;
                    if (parts.Length > 1)
                    {
                        if (!string.IsNullOrEmpty(parts[1].Trim()))
                            value = parts[1].Trim();
                    }

                    Options.Add(key, value);
                }
            }

            InitializeMessages();
            return IsValid(ref Mensaje);
        }

        private static void InitializeMessages()
        {
            Messages = new Dictionary<int, string>();
            Messages.Add(1, "El archivo de configuración no contiene la variable");
            Messages.Add(2, "No se halló un valor en el archivo de configuración para la variable");
            Messages.Add(3, "Valor no permitido para la variable");
            Messages.Add(4, "Se proporcionó una ruta inválida para la variable");
        }

        private static bool IsValid(ref string Mensaje)
        {
            bool valid = true;
            valid = valid && IsValidPathVar(SOURCE_PATH_VAR_NAME, ref Mensaje);
            valid = valid && IsValidPathVar(PUBLISH_PATH_VAR_NAME, ref Mensaje);

            if (DB_PATH != null)
            {
                if (!DB_PATH.Equals(DEFAULT_DB_PATH))
                    valid = valid && IsValidPathVar(DB_PATH_VAR_NAME, ref Mensaje);
            }
            return valid;
        }

        private static bool IsValidPathVar(string VarName, ref string Mensaje)
        {
            var valid = true;

            if (!Options.ContainsKey(VarName))
            {
                Mensaje += $"{Messages[1]} {VarName}";
                valid = false;
            }
            else if (Options[VarName] == null)
            {
                Mensaje += $"{Messages[2]} {VarName}";
                valid = false;
            }
            else if (!Directory.Exists(Options[VarName]))
            {
                Mensaje += $"{Messages[4]} {VarName}";
                valid = false;
            }

            return valid;
        }

        public static string GetOption(string VarName)
        {
            return Options.ContainsKey(VarName) ? Options[VarName] : null;
        }

        public static bool SaveConfig()
        {
            string[] fileLines = new string[Options.Count];
            for (int i = 0; i < fileLines.Length; i++)
            {
                var option = Options.ElementAt(i);
                var value = option.Value == null ? "" : option.Value;
                var line = $"{option.Key}={value}\n";
                fileLines[i] = line;
            }
            File.WriteAllLines(CONFIG_FILE_PATH, fileLines);
            return true;
        }

    }
}
