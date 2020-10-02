using System;
using System.Numerics;

namespace Ultimate
{
    class Program
    {
        //Angiv punkterne som deres stedvektorer, linjen først
        static Vector3 p1 = new Vector3(0,0,0);
        static Vector3 p2 = new Vector3(0,0,0);

        //Så planet
        static Vector3 p3 = new Vector3(2,3,4);
        static Vector3 p4 = new Vector3(1,7,2);
        static Vector3 p5 = new Vector3(1,4,8);
        static void Main(string[] args)
        {
            onPlan(new Vector3(1,1,1));
        }
        static Boolean onPlan(Vector3 Punkt){
            /*Plane plan = new Plane();
            plan = Plane.CreateFromVertices(p3,p4,p5);
            Vector3 n = plan.Normal;
            */
            Vector3 N = Vector3.Cross(p4-p3,p5-p3);
            Boolean Scanning = true;

            while(Scanning){
                if(Punkt == p3 + N){
                    return true;
                }
            }
            return false;
        }
    }
}
