using System;

namespace MatrixSampleCS
{
    public interface IFunction
    {
        float XMin {get;}
        float XMax {get;}
        float YMin {get;}
        float YMax {get;}

        float GetY(float X);
        string ToString();                                                                                                                                                                                             }                                                                                                                                                                    

}
