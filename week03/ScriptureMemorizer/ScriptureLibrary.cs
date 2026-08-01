public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Reference reference2 = new Reference("Alma", 7, 11, 12);
        Scripture scripture2 = new Scripture(reference2, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pain and the sickness of his people.\n\nAnd he will take upon him the death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flash, that he may know according to the flash how to succor his people according to their infirmities.");
        Reference reference3 = new Reference("Moroni", 10, 4, 6);
        Scripture scripture3 = new Scripture(reference3, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\n\nAnd by the power of the Holy Ghost ye may know the truth of all things.\n\nAnd whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.");
        Reference reference4 = new Reference("Helaman", 5, 12);
        Scripture scripture4 = new Scripture(reference4, "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        Reference reference5 = new Reference("Jacob", 4, 8);
        Scripture scripture5 = new Scripture(reference5, "Behold, great and marvelous are the works of the Lord. How unsearchable are the depths of the mysteries of him; and it is impossible that man should find out all his ways. And no man knoweth of his ways save it be revealed unto him; wherefore, brethren, despise not the revelations of God.");               

        _scriptures.Add(scripture1);
        _scriptures.Add(scripture2);
        _scriptures.Add(scripture3);
        _scriptures.Add(scripture4);
        _scriptures.Add(scripture5);
    }

    public Scripture GetRandomScripture()
    {
        int randomIndex = _random.Next(_scriptures.Count);
        return _scriptures[randomIndex];
    }
}