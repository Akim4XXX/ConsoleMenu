string password = null, tempPasword = null, name = null, executeCommand, selectAction, selectColor;
bool exit = true;
Console.WriteLine("Для просмотра возможных команд, напишите help");
while (exit)
{ 
    Console.Write("Введите команду: ");
    executeCommand = Console.ReadLine();
    switch (executeCommand.ToLower())
    {
        case "help":
            Console.WriteLine("\nCписок доступных команд\n" +
                "\nSetName – установить имя\r\n\r\n" +
                "ChangeConsoleTextColor- изменить цвет консоли\r\n\r\n" +
                "SetPassword – установить пароль\r\n\r\n" +
                "WriteName – вывести имя (после ввода пароля)\r\n\r\n" +
                "Esc – выход из программы\n");
            break;
        case "setname":
            Console.Clear();
            Console.WriteLine("SetName – установить имя");
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write($"Отображаемое имя - {name}\n");
            Console.Write($"Желаете изменить имя? (да/нет): ");
            selectAction = Console.ReadLine();
            if (selectAction.ToLower() == "да")
            {
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
            }
            Console.Clear();
            break;
        case "changeconsoletextcolor":
            Console.Clear();
            Console.WriteLine("Список доступных цветов");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Black");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("DarkBlue");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("DarkGreen");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("DarkCyan");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("DarkRed");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("DarkMagenta");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("DarkYellow");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Gray");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("DarkGray");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cyan");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Magenta");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("White");
            Console.Write("Выберите цвет: ");
            selectColor = Console.ReadLine();
            switch (selectColor.ToLower())
            {
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "darkblue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkgreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkcyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "darkred":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkmagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkyellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "darkgray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Такого цвета нет");
                    break;
            }
            Console.Clear();
            break;
        case "setpassword":
            Console.Clear();
            Console.Write("Введите желаемый пароль: ");
            password = Console.ReadLine();
            Console.Write("Повторите пароль: ");
            tempPasword = Console.ReadLine();
            if (password == tempPasword)
            {
                Console.WriteLine("Пароль успешно установлен");
                tempPasword = null;
            }
            else
            {
                Console.WriteLine("Пароли не совпадают");
            }
            Console.Clear();
            break;
        case "writename":
            if (password == null)
            {
                Console.WriteLine("Сначала установите пароль");
            }
            else if (name == null)
            {
                Console.WriteLine("Имя не установлено");
            }
            else
            {
                Console.Write("Введите пароль - ");
                tempPasword = Console.ReadLine();
                if (tempPasword == password)
                {
                    Console.WriteLine("Вы успешно вошли");
                    Console.WriteLine("Ваше имя: " + name);
                }
                else
                {
                    Console.WriteLine("Пароль указан неверно");
                    return;
                }                
            }
            break;
        case "esc":
            exit = false;
            break;
        default:
            Console.WriteLine("Такой команды не существует");
            break;
    }
}