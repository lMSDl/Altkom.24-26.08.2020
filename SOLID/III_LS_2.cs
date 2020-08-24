namespace SOLID.III_LS_2
{
    public abstract class Shape
    {
        public abstract int Area { get; }
    }

    //public class Square : Rectangle
    //{
    //    public override int A { set => base.A = base.B = value; }
    //    public override int B { set => base.B = base.A = value; }
    //}

    //public class Rectangle : Shape
    //{
    //    public virtual int A { get; set; }
    //    public virtual int B { get; set; }

    //    public override int Area => A * B;
    //}

    public class Square : Shape
    {
        public virtual int A { get; set; }

        public override int Area => A * A;
    }

    public class Rectangle : Square
    {
        public virtual int B { get; set; }

        public override int Area => A * B;
    }
}
