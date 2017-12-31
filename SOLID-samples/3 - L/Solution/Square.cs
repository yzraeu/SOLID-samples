namespace SOLID.samples.LSP.Solution
{
    class Square : IParallelogram
    {
        public double Lenght { get; set; }

        public double Area()
        {
            return this.Lenght * this.Lenght;
        }
    }
}
