using CIS129FinalProject.Models.Stages;

namespace CIS129FinalProject.Processing;

public class StageGenerator
{
    private StageAbstract mStage;

    public int ColumnsInStage { get; private set; } = 5;
    public int RowsInStage { get; set; } = 5;

    public StageGenerator(StageAbstract stage)
    {
        mStage = stage;
    }

    public void GenerateStage()
    {
        GenerateStageCoordinateSpace();
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
}