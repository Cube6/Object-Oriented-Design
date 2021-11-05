////Given Rectangle class and its child class Square, for a method that calculates area by multiplying width and height for rectangle, 
////there may be unexpected results when a Square object is used, which implies that these two classes should be excluded from inheritance relation
////reference from http://www.objectmentor.com/resources/articles/lsp.pdf
//public class RectangleA //define Rectangle class, give its width and height and related functions
//{
//    private double _width;
//    private double _height;

//    public void SetWidth(double w) { _width = w; }
//    public void SetHeight(double w) { _height = w; }
//    public double GetWidth() { return _width; }
//    public double GetHeight() { return _height; }
//}

//public class SquareA : RectangleA //define Square class inherited from Rectangle, but make sure the width and height are always equal
//{
//    public void SetWidth(double w)
//    {
//        base.SetWidth(w);
//        base.SetHeight(w);
//    }
//    public void SetHeight(double w)
//    {
//        base.SetWidth(w);
//        base.SetHeight(w);
//    }
//}

////a test where conflict will occur:
//public void test1(Rectangle r)
//    {
//    r.SetWidth(32);
//    }

//SquareA squareA = new SquareA(1, 1);
//test1(SquareA squareA);
////only width will be set, which violates the definition of square

////now let's 'fix' the problem by revising the class definition, add virtual to the functions
//public class RectangleB
//{
//    private double _width;
//    private double _height;

//    public virtual void SetWidth(double w) { _width = w; }
//    public virtual void SetHeight(double w) { _height = w; }
//    public double GetWidth() { return _width; }
//    public double GetHeight() { return _height; }
//}

//public class SquareB : RectangleB
//{
//    public override void SetWidth(double w)
//    {
//        base.SetWidth(w);
//        base.SetHeight(w);
//    }
//    public override void SetHeight(double w)
//    {
//        base.SetWidth(w);
//        base.SetHeight(w);
//    }
//}

////after adding virtual and override patches, it looks good

//SquareB squareB = new SquareB(1, 1);
//test1(SquareB squareB);//pass

////another test
//public void test2(RectangleB r)
//{
//    r.SetWidth(5);
//    r.SetHeight(4);
//    Assert.AreEqual(r.GetWidth() * r.GetHeight(), 20);
//}

//test2(SquareB squareB);//fail



