using System;
using System.Numerics;

namespace Ultimate
{
    class Program
    {
        //Angiv punkterne som deres stedvektorer, linjen først
        static Vector3 p1 = new Vector3(0,0,0);
        static Vector3 p2 = new Vector3(0,0,3);

        //Så planet
        static Vector3 p3 = new Vector3(0,0,1);
        static Vector3 p4 = new Vector3(1,0,0);
        static Vector3 p5 = new Vector3(0,0,6);
        static void Main(string[] args)
        {
            if(p1.Equals(p2)){
                Console.WriteLine("De to punkter danner ikke en linje.");
            }else if(PointOnLine()){
                Console.WriteLine("De tre punkter danner ikke et plan.");
            }else{
            //Bemærk, jeg bruger en alternativ måde at finde skæringen på. Mere kan læses om denne på: https://en.wikipedia.org/wiki/Line%E2%80%93plane_intersection
            Vector3 p = p2-p1;
            Vector3 n = Vector3.Cross(p4-p3,p5-p3);
            if(Vector3.Dot(p3-p1,n)==0){
                Console.WriteLine("Linjen ligger i planet.");
            }else if(Vector3.Dot(p,n)==0){
                Console.WriteLine("Linjen og planet er paralle.");
            }else{
                float d =(Vector3.Dot((p3-p1),n))/(Vector3.Dot(p,n));
                Console.WriteLine("Skæringspunktet er {0}.", p1+p*d);
            }
        }
        }
        static Boolean PointOnLine(){
            Vector3 r = p4 - p3;
            Vector3 P0P = p5-p3;
            float dist  = Vector3.Cross(r,P0P).Length()/r.Length();
            return dist==0;
        }

    }
}
