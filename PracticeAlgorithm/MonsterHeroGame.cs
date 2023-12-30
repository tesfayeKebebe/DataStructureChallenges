namespace PracticeAlgorithm;

public class MonsterHeroGame
{
    // The hero and the monster will start with 10 health points.
    //     All attacks will be a value between 1 and 10.
    // The hero will attack first.
    //     Print the amount of health the monster lost and their remaining health.
    //     If the monster's health is greater than 0, it can attack the hero.
    //     Print the amount of health the hero lost and their remaining health.
    //     Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    //     Print the winner.
[Fact]
    public Task PrintWinner()
    {
        int hero=10, monster=10;
        do{
            var random  = new Random();
            var attack =random .Next(1,10); 
            monster-=attack;
            Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health");
            if(monster<=0) continue;
            attack=random .Next(1,10); 
            hero-=attack;
            Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health");
        }
        while(hero>0 && monster>0);
        Console.WriteLine(hero > monster ? $"Hero wins" : $"Monster wins");
        return Task.CompletedTask;
    }
    
}