namespace CMDTETRIS;

public class Tetromino
{
    public bool[,] tetromino;
    
    public int xPosition, yPosition;

    public Tetromino(bool[,] tetromino, int xPosition, int yPosition)
    {
        this.tetromino = tetromino;
        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

    public bool[,] Tetromino1
    {
        get => tetromino;
        set => tetromino = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int XPosition
    {
        get => xPosition;
        set => xPosition = value;
    }

    public int YPosition
    {
        get => yPosition;
        set => yPosition = value;
    }
}