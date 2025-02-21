// Task 9: Game Character System
// Task: Create a partial class.
// Create a partial class Character in two separate files:
// One part contains fields characterName and level.
// The other contains a method ShowCharacterInfo().
// In Main(), create a Character object and call ShowCharacterInfo().

partial class Character
{
    private string characterName;
    private int level;

    public Character(string characterName, int level)
    {
        this.characterName = characterName;
        this.level = level;
    }

    public string CharacterName
    {
        get { return characterName; }
    }

    public int Level
    {
        get { return level; }
    }

}