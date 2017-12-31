namespace SOLID.samples.LSP.Solution
{
    public class Rectangle : IParallelogram
    {
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }

        double IParallelogram.Area()
        {
            return this.Height * this.Width;
        }
    }
}
