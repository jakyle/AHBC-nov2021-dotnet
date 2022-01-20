using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    // enums are ONE of these values, think of them like constants, where your constant vlaue
    // can ONLY be one of the choices in your enum.  for example, if our enum value is MovieGenre.Comedy, that
    // is the ONLY value it can be.  enums are used for MOSTLY switch cases, so you can determine what YOU want 
    // to do NEXT in your application based on the enum value.
    public enum MovieGenre
    {
        Horror = 0,
        Comedy = 1,
        Action = 2 ,
        Romance = 3,
        Scifi = 4
    }
}
