namespace pz_17
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем карту
            int[,] map = new int[25, 25];

            // Рандомно генерируем врагов
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(0, 25);
                int y = random.Next(0, 25);
                while (map[x, y] != 0)
                {
                    x = random.Next(0, 25);
                    y = random.Next(0, 25);
                }
                map[x, y] = -15;
            }

            // Рандомно генерируем аптечки
            for (int i = 0; i < 5; i++)
            {
                int x = random.Next(0, 25);
                int y = random.Next(0, 25);
                while (map[x, y] != 0)
                {
                    x = random.Next(0, 25);
                    y = random.Next(0, 25);
                }
                map[x, y] = 10;
            }

            // Рандомно генерируем баффы
            for (int i = 0; i < 3; i++)
            {
                int x = random.Next(0, 25);
                int y = random.Next(0, 25);
                while (map[x, y] != 0)
                {
                    x = random.Next(0, 25);
                    y = random.Next(0, 25);
                }
                map[x, y] = -2;
            }

            // Помещаем игрока в центр карты
            int playerX = 12;
            int playerY = 12;
            map[playerX, playerY] = 30;

            // Выводим карту на экран
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 25; x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        Console.Write("P ");
                    }
                    else if (map[x, y] == -15)
                    {
                        Console.Write("E ");
                    }
                    else if (map[x, y] == -2)
                    {
                        Console.Write("B ");
                    }
                    else if (map[x, y] == 10)
                    {
                        Console.Write("H ");
                    }
                    else if (map[x, y] == 0)
                    {
                        Console.Write(". ");
                    }
                    else
                    {
                        Console.Write(map[x, y] + " ");
                    }
                }
                Console.WriteLine();
            }

            // Игровой цикл
            int stepsTaken = 0;
            while (true)
            {
                Console.WriteLine("Введите направление движения: up/down/left/right");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    // Сохраняем состояние игры в файл и выходим из игры
                    SaveGameState(map);
                    break;
                }

                int newX = playerX;
                int newY = playerY;

                switch (input)
                {
                    case "up":
                        newY--;
                        break;
                    case "down":
                        newY++;
                        break;
                    case "left":
                        newX--;
                        break;
                    case "right":
                        newX++;
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        continue;
                }

                if (newX < 0 || newX >= 25 || newY < 0 || newY >= 25)
                {
                    Console.WriteLine("Выход за пределы карты.");
                    continue;
                }

                stepsTaken++;

                if (map[newX, newY] == -15)
                {
                    // Враг
                    int enemyHealth = -15;
                    while (enemyHealth > 0 && map[playerX, playerY] > 0)
                    {
                        enemyHealth -= map[playerX, playerY];
                        map[playerX, playerY] -= enemyHealth > 0
    }