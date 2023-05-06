
public enum ItemType
{
    Seed,Commodity,Furniture,
    HoeTool,ChopTool,BreakTool,ReapTool,WaterTool,CollectTool,
    ReapableScenery,Food
}

public enum SlotType
{
    Bag,Box,Shop
}

public enum InventoryLocation
{
    Player,Box
}

public enum PartType
{
    None,Carry,Hoe,Break,Water,Collect,Chop,Reap
}

public enum PartName
{
    Body,Hair,Arm,Tool
}

public enum Season
{
    春天,夏天,秋天,冬天
}

public enum GridType
{
    Diggable,DropItem,PlaceFurniture,NPCObstacle
}

public enum ParticleEffectType
{
    None,LeavesFalling01,LeavesFalling02,Rock,ReapableScenery
}

public enum GameState
{
    Gameplay,Pause
}

public enum LightShift
{
    Morning,Night
}

public enum SoundName{
    none,FootStepSoft,FootStepHard,
    Pickup,Plant,TreeFalling,Rustle,
    AmbientCountryside1,AmbientCountryside2,MusicCalm1,MusicCalm2,MusicCalm3,
    MusicCalm4,MusicCalm5,MusicCalm6,AmbientIndoor1
}
