namespace CSharpInter
{
    public class Point {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point p)
        {
            //Defensive programming'

            if (p == null)
            {
                throw new ArgumentNullException("p");
            }
            //null exception if we pass null in the parameter
            Move(p.x, p.y);
            //this.x = p.x;
            //this.y = p.y;
        }
    }
}