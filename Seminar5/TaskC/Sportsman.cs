using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Sportsman
{
    protected int force;
    protected int agility;
    protected int endurance;

    protected Sportsman(int force, int agility, int endurance)
    {
        this.force = force;
        this.agility = agility;
        this.endurance = endurance;
    }
}
