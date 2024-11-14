class Pixel
{
    int R;
    int G;
    int B;
    public byte GetAverage()
    {
        return (byte)((R + G + B) / 3);
    }
    public void Combine(Pixel pixel)
    {
        R = (R + pixel.R) / 2;
        G = (G + pixel.G) / 2;
        B = (B + pixel.B) / 2;
    }
}
class Screen
{
    Pixel[,] screen = new Pixel[50, 50];
    public void Combine(Screen s)
    {
        for (int y = 0; y < screen.GetLength(0); y++)
        {
            for (int x = 0; x < screen.GetLength(1); x++)
            {
                screen[y, x].Combine(s.screen[y, x]);
            }
        }
    }
    public byte GetAverage()
    {
        int sum = 0;
        for (int y = 0; y < screen.GetLength(0); y++)
        {
            for (int x = 0; x < screen.GetLength(1); x++)
            {
                sum += screen[y, x].GetAverage();
            }
        }
        return (byte)(sum / 2500);
    }

}