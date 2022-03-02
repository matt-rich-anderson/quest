using System;
using System.Collections.Generic;

namespace Quest
{
    public class Robe
    {
                public List<string> Color { get; set;}
                public int Length { get; set;}

                public string Brand { get; }

                public Robe(List<string>robeColor, int robeLength, string robeBrand){
                    Color = robeColor;
                    Length = robeLength;
                    Brand = robeBrand;
                    // classes
                }

    }
}