using System;

////1
//    Player player = new Player();
//    player.ShowStatus();
//    class Player
//    {
//        public string name;
//        public int health;

//        public void ShowStatus()
//        {
//            Console.WriteLine($"이름: {name}\n체력: {health}");
//        }
//    }



//2

//Character ch = new Character();
//ch.name = "용사";
//ch.level = 10;

//Console.WriteLine($"{ch.name}\n{ch.level}");
//class Character
//{
//    public string name;
//    public int level;
//}

//3

//Character ch = new Character();
//ch.SetInfo("용사", 10);
//ch.ShowInfo();
//class Character
//{
//    private string name;
//    private int level;

//    public void SetInfo(string n, int l)
//    {
//        name = n;
//        level = l;
//    }
//    public void ShowInfo()
//    {
//        Console.WriteLine($"이름: {name}\n레벨: {level}");
//    }
//}

//4
//Player p = new Player();
//p.ShowStatus();
//class Player
//{
//    private string name = "이름없음";
//    private int health = 100;
//    private int level = 1;

//    public void ShowStatus()
//    {
//        Console.WriteLine($"이름: {name}\n체력: {health}\n레벨: {level}");
//    }
//}

//5
//Say s = new Say();
//s.Hi();
//class Say
//{
//    private string message = "안녕하세요";

//    public void Hi()
//    {
//        message = "반갑습니다";
//        Console.WriteLine(message);
//    }
//}

//6
//Schedule schedule = new Schedule();
//schedule.PrintWeekDays();

//class Schedule
//{
//    private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

//    public void PrintWeekDays()
//    {
//        foreach (var day in days)
//        {
//            Console.Write(day + "\t");
//        }
//        Console.WriteLine();
//    }
//}

//7
//DefaultValues d = new DefaultValues();
//d.ShowDefaults();
//class DefaultValues
//{
//    private int number;
//    private bool flag;
//    private string text;

//    public void ShowDefaults()
//    {
//        Console.WriteLine($"number: {number}\nflag: {flag}\ntext: {text}");
//    }
//}

//8
//Counter c1 = new Counter();
//Counter c2 = new Counter();
//Counter c3 = new Counter();
//class Counter
//{
//    public static int count=0;

//    public Counter()
//    {
//        count++;
//        Console.WriteLine($"현재 카운트: {count}");
//    }
//}

//9
//Player p1 = new Player("용사");
//Player p2 = new Player("마법사");
//Player p3 = new Player("궁수");
//Console.WriteLine(p1.name);
//Console.WriteLine(p2.name);
//Console.WriteLine(p3.name);
//Console.WriteLine($"총 플레이어 수: {Player.totalCount}");

//class Player
//{
//    public string name;
//    public static int totalCount=0;

//    public Player(string n)
//    {
//        name = n;
//        totalCount++;
//    }
//}


//10
//GameConfig g = new GameConfig(4);
//g.ShowConfig();
//class GameConfig
//{
//    private readonly string version = "1.0.0";
//    private readonly int maxPlayers;

//    public GameConfig(int m)
//    {
//        maxPlayers = m;
//    }

//    public void ShowConfig()
//    {
//        Console.WriteLine($"버전: {version}\n최대 플레이어: {maxPlayers}");
//    }
//}

//11
//Example ex = new Example();
//ex.ShowValues();

//class Example
//{
//    public const double Pi = 3.14159;                 
//    public readonly DateTime createdAt = DateTime.Now;

//    public void ShowValues()
//    {
//        Console.WriteLine("원주율: " + Pi);
//        Console.WriteLine("생성 시간: " + createdAt);
//    }
//}

//12
//Player p = new Player("용사", 10);
//p.ShowInfo();
//class Player
//{

//    private string name;
//    private int level;

//    public Player(string name, int level)
//    {
//        this.name = name;
//        this.level = level;
//    }
//    public void ShowInfo()
//    {
//        Console.WriteLine($"이름: {name}\n레벨: {level}");
//    }
//}

//13
//Person person = new Person();
//person.ShowProfile();

//class Person
//{
//    private string name = "홍길동";
//    private const int Age = 21;
//    private readonly string nickName = "길동이";
//    private string[] websites = { "네이버", "구글" };

//    public void ShowProfile()
//    {
//        Console.WriteLine("이름: " + name);
//        Console.WriteLine("나이: " + Age);
//        Console.WriteLine("닉네임: " + nickName);
//        Console.WriteLine("사이트: " + string.Join(", ", websites));
//    }
//}

//14
GameCharacter hero = new GameCharacter("용사", 15);
GameCharacter mage = new GameCharacter("마법사", 25);

hero.ShowStatus();
Console.WriteLine();
mage.ShowStatus();
Console.WriteLine();

hero.TakeDamage(30);
hero.TakeDamage(50);
hero.TakeDamage(50);

Console.WriteLine();
GameCharacter.ShowTotalCharacters();

class GameCharacter
{
    private string name;
    private int health;
    private int attack;

    private static int characterCount = 0;

    private readonly int maxHealth = 100;

    private const int MinHealth = 0;

    public GameCharacter(string name, int attack)
    {
        this.name = name;
        this.health = maxHealth;
        this.attack = attack;
        characterCount++;
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;
        if (health < MinHealth)
        {
            health = MinHealth;
        }
        Console.WriteLine(name + "이(가) " + damage + " 데미지를 받음! 남은 체력: " + health);
    }

    public void ShowStatus()
    {
        Console.WriteLine("=== " + name + " ===");
        Console.WriteLine("체력: " + health + "/" + maxHealth);
        Console.WriteLine("공격력: " + attack);
    }

    public static void ShowTotalCharacters()
    {
        Console.WriteLine("총 캐릭터 수: " + characterCount);
    }
}