public class Enemy
{
    // Descriptive Fields
    public string name;
    public int hlthAmt;
    public List<Attack> AttackList;

    // Constructors
    public Enemy(string n)
    {
        name = n;
        hlthAmt = 100;
        AttackList = new List<Attack> {};
    }

    // Methods
    public Attack RandomAttack()
    {
        Random rand = new Random();
        int attackIdx = rand.Next(0, AttackList.Count);
        System.Console.WriteLine($"Enemy {AttackList[attackIdx].name} ");
        return AttackList[attackIdx];
    }
}