using System.Reflection;
using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.Processing;

public class SpaceEventDescriptionGenerator
{
    private StageAbstract mStage;
    private readonly List<string> mDescriptionList;
    private Random mRandomGenerator;

    public SpaceEventDescriptionGenerator(StageAbstract stage)
    {
        mStage = stage;
        mDescriptionList = new List<string>();
        mRandomGenerator = new Random();
        PopulateDescriptionList();
    }

    public StageAbstract GenerateSpaceEventDescriptions()
    {
        foreach (var cSpace in mStage.CoordinateSpace)
        {
            var index = mRandomGenerator.Next(77);
            mStage.EventDictionary[cSpace].SpaceDescription = mDescriptionList[index];
        }

        return mStage;
    }

    private void PopulateDescriptionList()
    {
        mDescriptionList.Add("This area is damp, and mold grows everywhere");
        mDescriptionList.Add("This area is ankle to waist deep water everywhere");
        mDescriptionList.Add("This area is entirely underwater");
        mDescriptionList.Add("This area is sodden, and everything is ruined, turning into mush");
        mDescriptionList.Add("This area is dry rot, crumbling stone");
        mDescriptionList.Add("This area has a layer of dust and grit cover everything");
        mDescriptionList.Add("This area has dry air that makes you thirsty and uncomfortable");
        mDescriptionList.Add("This area has moving air that pulls moisture away, and is full of mummified husks of small creatures.");
        mDescriptionList.Add("This area is covered with a layer of ice with formations on walls and ceiling");
        mDescriptionList.Add("This area has cold and damp air that works through your clothes");
        mDescriptionList.Add("This area is damp, and mold grows everywhere");
        mDescriptionList.Add("This area is biting cold with walls of ice");
        mDescriptionList.Add("This area is cool but invigorating");
        mDescriptionList.Add("This area has piles of still warm ash and seems to have low oxygen levels");
        mDescriptionList.Add("This area has geothermal vents, geysers, etc.");
        mDescriptionList.Add("This area has flows of magma (1500k about 3 times as hot as a campfire, 500k). It is a large room and the heat dissipates enough to approach");
        mDescriptionList.Add("This area has a generally warmer temperature");
        mDescriptionList.Add("This area is covered in growth and items animate and burst into frantic activity");
        mDescriptionList.Add("This area is filled with large swarms of vermin");
        mDescriptionList.Add("This area has dripping mineral water creating slow growing formations");
        mDescriptionList.Add("This area has a spirit caretaker that oversees the area");
        mDescriptionList.Add("This area has corpses littering the area");
        mDescriptionList.Add("This area causes a feeling of illness or unease");
        mDescriptionList.Add("This area is falling apart");
        mDescriptionList.Add("This area has feelings of being watched and causes prickling of the skin");
        mDescriptionList.Add("This area has plant growth and hanging roots that block passages and cluster about the ground");
        mDescriptionList.Add("This area has strange cave flowers growing and sprouting from bushes and vines");
        mDescriptionList.Add("This area has large fungi and molds that grow throughout the area");
        mDescriptionList.Add("This area has carefully tended gardens");
        mDescriptionList.Add("This area has caves formed by minerals dissolving and the walls are wet");
        mDescriptionList.Add("This area was formed by magma flowing out of a stone causing the rooms to be tunnel like");
        mDescriptionList.Add("This area is full of debris as rocks collapse from the ceiling");
        mDescriptionList.Add("This area was made by the wind wearing down on the rock basin");
        mDescriptionList.Add("This area is crudely carved out of rock and surface still shows tool marks");
        mDescriptionList.Add("This area is made of soft stone supported by columns and beams");
        mDescriptionList.Add("This area has simple stone bricks carved from rock and shiny finished walls");
        mDescriptionList.Add("This area is smaller, fancier, and simply made of better stone bricks");
        mDescriptionList.Add("This area has the sound of wind being forced through tight passages");
        mDescriptionList.Add("This area is an indication that this area is unstable because of consistent seismic activity");
        mDescriptionList.Add("This area has small inhabitants that noisily hide in the shadows");
        mDescriptionList.Add("This area has the sound of the wind... or is it something more sinister?");
        mDescriptionList.Add("This area is of death, decomposition, mold");
        mDescriptionList.Add("This area has the smell of earth and dirt");
        mDescriptionList.Add("This area has strange acrid brews, sickly sweet tangs, and the smell of some kind of strange chemical is in the air");
        mDescriptionList.Add("This area has the distinct smell and taste of metal");
        mDescriptionList.Add("This area has an area that is populated with small animals");
        mDescriptionList.Add("This area has slimes, fungus, monsters and insects");
        mDescriptionList.Add("This area has elementals, undead, constructs and other unnatural things");
        mDescriptionList.Add("This area has advanced humanoid tool users");
        mDescriptionList.Add("This area is a small room with tight passages that you have to crawl and squeeze through");
        mDescriptionList.Add("This area is normal room");
        mDescriptionList.Add("This area has larger passageways seemingly built by giants");
        mDescriptionList.Add("This area is a silent square and rectangular room");
        mDescriptionList.Add("This area has strange transparent circles and ellipses");
        mDescriptionList.Add("This area has caves and natural passages");
        mDescriptionList.Add("This area is being maintained as repairs are being made by Angel-Cyborg hybrids");
        mDescriptionList.Add("This area shows that no one has done maintenance for a long time as few things work and most are broken, missing, or destroyed");
        mDescriptionList.Add("This area has howling winds the blow through its halls. Items are blown about and the doors are flung open");
        mDescriptionList.Add("This area is a huge open cavern with vaulted ceilings");
        mDescriptionList.Add("This area has deep chasms voids and pits");
        mDescriptionList.Add("This area is one monstrous cavern with small discrete areas that look full of surprises");
        mDescriptionList.Add("This area is a huge construction made from large slabs of rock");
        mDescriptionList.Add("This area has an unsettling cleanliness to it");
        mDescriptionList.Add("This area is covered with engravings, runes, and patterns");
        mDescriptionList.Add("This area has an unusual and alien style");
        mDescriptionList.Add("This area has mist,steam and fog that blanket the space");
        mDescriptionList.Add("This area has webs, vines or other grassy obstructions");
        mDescriptionList.Add("This area is covered in magical darkness");
        mDescriptionList.Add("This area has no special obstructions, just very few straight passages, so vision only extends to the next bend");
        mDescriptionList.Add("This area is a larger complex of about 5-15 smaller rooms");
        mDescriptionList.Add("This area has art objects that can be looted as treasure");
        mDescriptionList.Add("This area is not much in the way of treasure, but area has trade good that can be sold");
        mDescriptionList.Add("This area has shifting walls that change the shape of the room");
        mDescriptionList.Add("This area has an indefinite arrangement and is full of portals that bend in reality");
        mDescriptionList.Add("This area has magic in it and the magic acts in unpredictable ways");
        mDescriptionList.Add("This area has magic in it that is suppressed and nullified");
        mDescriptionList.Add("This area has walls that are studded with raw crystal");
    }
    
}