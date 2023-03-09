using UnityEngine;
using UnityEngine.UI;

/**
* @class FlexibleGridLayout
* @brief grid layout with more options
* @author Junliang
*/
public class FlexibleGridLayout : LayoutGroup
{
    public enum FitType
    {
        Uniform,
        Width,
        Height,
        FixedRows,
        FixedColumns
    }

    public FitType fitType; //!< fitting option for cells
    [Min(1)]
    public int rows; //!< number of rows
    [Min(1)]
    public int columns; //!< number of columns
    public Vector2 cellSize; //!< cell size
    [Min(0)]
    public Vector2 spacing; //!< space inbetween cells
    public bool fitX; //!< true: expand cell width to fit parent
    public bool fitY; //!< true: expand cell height to fit parent

    public override void CalculateLayoutInputHorizontal()
    {
        base.CalculateLayoutInputHorizontal();

        FitCells();
    }

    private void FitCells()
    {
        CalculateNumberOfRowsAndColumns();

        CalculateCellSize();

        SetCellPositions();

        SetMinimumSize();
    }

    private void CalculateNumberOfRowsAndColumns()
    {
        if (fitType == FitType.Width || fitType == FitType.Height || fitType == FitType.Uniform)
        {
            fitX = fitY = true;

            float sqrt = Mathf.Sqrt(transform.childCount);
            rows = Mathf.CeilToInt(sqrt);
            columns = Mathf.CeilToInt(sqrt);
        }

        if (fitType == FitType.Width || fitType == FitType.FixedColumns)
        {
            rows = Mathf.CeilToInt(transform.childCount / (float)columns);
        }
        else if (fitType == FitType.Height || fitType == FitType.FixedRows)
        {
            columns = Mathf.CeilToInt(transform.childCount / (float)rows);
        }
    }

    private void CalculateCellSize()
    {
        if (fitX)
        {
            float parentWidth = rectTransform.rect.width;
            float cellWidth = (parentWidth - (spacing.x * ((float)columns - 1)) - padding.left - padding.right) / (float)columns;
            cellSize.x = cellWidth;
        }
        if (fitY)
        {
            float parentHeight = rectTransform.rect.height;
            float cellHeight = (parentHeight - (spacing.y * ((float)rows - 1)) - padding.top - padding.bottom) / (float)rows;
            cellSize.y = cellHeight;
        }
    }

    private void SetCellPositions()
    {
        for (int i = 0; i < rectChildren.Count; i++)
        {
            int rowCount = i / columns;
            int columnCount = i % columns;

            var item = rectChildren[i];

            var xPos = (cellSize.x * columnCount) + (spacing.x * columnCount) + padding.left;
            var yPos = (cellSize.y * rowCount) + (spacing.y * rowCount) + padding.top;

            SetChildAlongAxis(item, 0, xPos, cellSize.x);
            SetChildAlongAxis(item, 1, yPos, cellSize.y);
        }
    }

    private void SetMinimumSize()
    {
        if (!fitX)
        {
            var totalMinWidth = columns * cellSize.x + padding.left + padding.right + spacing.x * (columns - 1);
            SetLayoutInputForAxis(totalMinWidth, -1, -1, 0);
        }
        if (!fitY)
        {
            var totalMinHeight = rows * cellSize.y + padding.top + padding.bottom + spacing.y * (rows - 1);
            SetLayoutInputForAxis(totalMinHeight, -1, -1, 1);
        }
    }


    #region Abstract Method Override

    public override void CalculateLayoutInputVertical()
    {

    }

    public override void SetLayoutHorizontal()
    {

    }

    public override void SetLayoutVertical()
    {

    }

    #endregion
    

}
