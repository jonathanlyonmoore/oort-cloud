using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections;


namespace MatrixSampleCS
{
    public class FunctionDiagram
    {

        private Bitmap mBitmap;
        private int mWidthPixels;
        private int mHeightPixels;


        private Graphics mGraphics;
        // transforms app coordinates to bmp coordinates
        Matrix mTransform;

        // function to graph
        private IFunction mIFunction; 
        private float mMinX;
        private float mMaxX;
        private float mMinY;
        private float mMaxY;

        // for axis labels
        private FontFamily mFontFamily = new FontFamily("Arial");
        private int mFontStyle = Convert.ToInt16(FontStyle.Regular);
        private StringFormat mStringFormat = StringFormat.GenericDefault;

        // sizes for grid, axes and function in app units
        private float mGridPensize;
        private float mXAxisPensize;
        private float mYAxisPensize;
        private float mFunctionPenSize;

        public Bitmap ChartBitmap
        {  
            get{return mBitmap;}
        }

        // draw the function
        //private void DrawFunction(Color Color)
        //{
        //    Pen lPen = new Pen(Color, mFunctionPenSize);
        //    GraphicsPath lLineSegment = new GraphicsPath();
        //    PointF lLastPoint = new PointF(mMinX, mIFunction.GetY(mMinX));
        //    PointF lThisPoint;

        //    for(float lThisXValue = mIFunction.XMin ;
        //        lThisXValue <= mIFunction.XMax; 
        //        lThisXValue = lThisXValue + 
        //            (mIFunction.XMax - mIFunction.XMin) /100.0F)
        //    {
        //        lThisPoint = 
        //            new PointF(lThisXValue, mIFunction.GetY(lThisXValue));
        //        lLineSegment.AddLine(lLastPoint, lThisPoint);
        //        lLastPoint = lThisPoint;
        //    }
        //    mGraphics.DrawPath(lPen, lLineSegment);

        //    }

        // used to obtain integer points for X and Y axis and grid lines
        private ArrayList AxisPoints(float MinValue, float MaxValue )
        {
            ArrayList lCollection = new ArrayList();
            int lMidpoint = Convert.ToInt16((MaxValue + MinValue) / 2.0);
            int lShift = 0 - lMidpoint;
            int lStep = Convert.ToInt16
                   (Math.Max((MaxValue - MinValue) / 10F, 1));

            for (int i  = lMidpoint; i <= MaxValue + lShift; 
                i =i + lStep)
            {
                lCollection.Add(i + lShift);
                if (i != lMidpoint) 
                     {
                         lCollection.Add
                             (lMidpoint - (i - lShift - lMidpoint));
                     }                        
            } 
          
            return lCollection;
        }

        // vertical grid lines and Y axis
        private void XGrid
            (Color GridColor, Color AxisColor, Color LabelColor,
            float LineWidth)
        {

            GraphicsPath lLine;
            Pen lGridPen = new Pen(GridColor, LineWidth / 4.0F);
            Pen lAxisPen = new Pen(AxisColor, LineWidth);

            foreach (int i in AxisPoints(mMinX, mMaxX))
            {
                lLine = new GraphicsPath();

                lLine.AddLine(new PointF(i, mMinY), new PointF(i, mMaxY));
                if (i == 0)
                {
                    mGraphics.DrawPath(lAxisPen, lLine);
                }
                else
                {
                    mGraphics.DrawPath(lGridPen, lLine);
                }

                //DrawString(i.ToString(), new PointF(i, 0), LabelColor);

            }
        }
        // horizontal grid lines and X axis
        private void YGrid
            (Color GridColor, Color AxisColor, Color LabelColor,
            float LineWidth)
        {

            GraphicsPath lLine;
            Pen lGridPen = new Pen(GridColor, LineWidth / 4.0F);
            Pen lAxisPen = new Pen(AxisColor, LineWidth);

            foreach (int i in AxisPoints(mMinX, mMaxX))
            {
                lLine = new GraphicsPath();
                lLine.AddLine(new PointF(mMinX, i), new PointF(mMaxX, i));
                if (i == 0)
                {
                    mGraphics.DrawPath(lAxisPen, lLine);
                }
                else
                {
                    mGraphics.DrawPath(lGridPen, lLine);
                }
                //DrawString(i.ToString(), new PointF(0, i), LabelColor);
            }

        }
    //private void DrawString 
    //    (string Str, PointF FunctionPoint,Color Color)
    //{
    //    int lEmsize = mHeightPixels / 20;
    //    GraphicsPath lTextPath = new GraphicsPath();
    //    lTextPath.AddString(Str, mFontFamily, mFontStyle, lEmsize, 
    //        new Point(5, 5), mStringFormat);

    //    RectangleF lRectF = new RectangleF( 
    //        new PointF(0.0F, 0.0F), 
    //        new SizeF(mWidthPixels, mHeightPixels));

    //    PointF[] lbmpcorners = new PointF[3];
    //    lbmpcorners[0] = new PointF(FunctionPoint.X, FunctionPoint.Y);
    //    lbmpcorners[1] = new PointF (FunctionPoint.X + mMaxX, FunctionPoint.Y);
    //    lbmpcorners[2] = new PointF(FunctionPoint.X, 
    //                            FunctionPoint.Y - (mMaxY - mMinY));

    //    Matrix lTextTransform = new Matrix(lRectF, lbmpcorners);

    //    lTextPath.Transform(lTextTransform);
    //    Pen lPen = new Pen(Color, -1);
    //    mGraphics.DrawPath(lPen, lTextPath);
    //}
    public FunctionDiagram
        (int WidthPixels, int HeightPixels,IFunction FunctionToGraph)
    {

        mMinX = FunctionToGraph.XMin;
        mMaxX = FunctionToGraph.XMax;
        mMinY = FunctionToGraph.YMin;
        mMaxY = FunctionToGraph.YMax;
        mIFunction = FunctionToGraph;

        mWidthPixels = WidthPixels;
        mHeightPixels = HeightPixels;

        mBitmap = new Bitmap
            (WidthPixels, HeightPixels, PixelFormat.Format16bppRgb555);
        mGraphics = Graphics.FromImage(mBitmap);
        mGraphics.FillRectangle
            (new SolidBrush(Color.White), 0, 0, WidthPixels, WidthPixels);


        // axis sizes will be 1/100th os the height or width
        mXAxisPensize = (mMaxY - mMinY) / 100.0F;
        mXAxisPensize = (mMaxY - mMinY) / 100.0F;
        mYAxisPensize = (mMaxX - mMinX) / 100.0F;
        // use the smallest axis size for the function line width
        mFunctionPenSize = System.Math.Min(mXAxisPensize, mYAxisPensize);

        RectangleF rectPlotF = new RectangleF
            (mMinX, mMaxY, (mMaxX - mMinX), -(mMaxY - mMinY));

        PointF[] bmpcorners = new PointF[3];
        bmpcorners[0] = new PointF(0, 0);
        bmpcorners[1] = new PointF(WidthPixels, 0);
        bmpcorners[2] = new PointF(0, HeightPixels);
        // the graphic object will now implicitly convert (x,y)
        // to pixel coordinates
        mTransform = new Matrix(rectPlotF, bmpcorners);
        mGraphics.Transform = mTransform;

        XGrid(Color.Gray, Color.Gray, Color.Gray, mYAxisPensize);
        YGrid(Color.Gray, Color.Gray, Color.Gray, mXAxisPensize);

        //DrawFunction(Color.Red);

        mGraphics.Dispose();
    }


}
}
