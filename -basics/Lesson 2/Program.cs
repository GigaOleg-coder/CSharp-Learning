namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "1";     //mistake
            //int i = s;          
            //int j = 5;          
            //double d = j;       //no mistake
            //int k = d;          //mistake

            //***implicit casting***

            //byte b = 42;    //from 0 to 255
            //int i = b;      //from -2 mil to 2 mil

            //***explicit cast***

            //int i = 255;    
            //int j = 2000;   
            //byte b = i;     
            //byte bb = j;    //it`s mistake, but we can use:
            //                  byte b = (byte)i
            //                  like we are telling compiler that "i" will fit into byte value

            //***explicit conversion***

            //string s = "2048";    
            //int i = (int)s        //mistake
            //so to make str "2048" into int, we use "Convert.ToInt32()"
            //int i = Convert.ToInt32(s);
            //also we can use:
            //int i = int.Parse(s);

            //***implicit conversion***

            //int i = 1;
            //string s = "str " + i; <==>   string s = "str " + i.ToString();








        }
    }
}
