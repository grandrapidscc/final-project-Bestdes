using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.Processing;

public class StageGenerator
{
    private StageAbstract mStage;
    private Random mRandomGenerator;

    public int ColumnsInStage { get; private set; } = 5;
    public int RowsInStage { get; set; } = 5;

    public StageGenerator(StageAbstract stage)
    {
        mStage = stage;
        mRandomGenerator = new Random();
    }

    public StageAbstract GenerateStage()
    {
        GenerateStageCoordinateSpace();
        GenerateBaseEventDictionary();
        SetStageExit();
        SetPlayerStartingPosition();
        
        return mStage;
    }

    private void GenerateStageCoordinateSpace()
    {
        var coordinateSpace = new List<(int, int)>();
        
        for (int columnIndex = 0; columnIndex < ColumnsInStage; columnIndex++)
        {
            for (int rowIndex = 0; rowIndex < RowsInStage; rowIndex++)
            {
                coordinateSpace.Add((columnIndex, rowIndex));
            }
        }

        mStage.CoordinateSpace = coordinateSpace.ToArray();
    }

    private void GenerateBaseEventDictionary()
    {
        mStage.EventDictionary = new Dictionary<(int, int), SpaceEvent>();
        foreach (var cSpace in mStage.CoordinateSpace)
        {
            mStage.EventDictionary.Add(cSpace, new SpaceEvent());
        }
    }

    public void SetPlayerStartingPosition()
    {
        var playerStartingPosition = ProduceRandomIntTuple();
        mStage.PlayerStartingPosition = playerStartingPosition != mStage.StageExit 
            ? playerStartingPosition 
            : ProduceRandomIntTuple();
    }

    public void SetStageExit()
    {
        var stageExit = ProduceRandomIntTuple();
        mStage.StageExit = stageExit;
    }
    
    private (int, int) ProduceRandomIntTuple()
    {
        var startingRow = mRandomGenerator.Next(5);
        var startingColumn = mRandomGenerator.Next(5);
        return (startingRow, startingColumn);
    }
}