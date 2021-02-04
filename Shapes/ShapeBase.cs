namespace Shapes
{
    abstract class ShapeBase : IShape
    {
        protected string name;
        protected decimal width;
        protected decimal height;

        public string Name { get => this.name; set => this.name = value; }
        public decimal Width { get => this.width; set => this.width = value; }
        public decimal Height { get => this.height; set => this.height = value; }
        public abstract decimal Area { get; }
    }
}