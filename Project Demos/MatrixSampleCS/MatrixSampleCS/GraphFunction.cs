using System;
namespace MatrixSampleCS
{
    public class GraphFunction : IFunction
    {
        public float XMin
        {  
            get{return mXMin;}
        }
        public float XMax
        {  
            get{return mXMax;}
        }
        public float YMin
        {  
            get{return mYMin;}
        }
        public float YMax
        {  
            get{return mYMax;}
        }

        private float mXMin = -5.0F;
        private float mXMax = +5.0F;
        private float mYMin = -5.0F;
        private float mYMax = +5.0F;

        public float GetY(float X)
        {
            return (float)Math.Exp(X);
        }
        public override string ToString()
        {
            return " Y = Exp(X)";
        } 

    }
}