namespace Exercises.Exercise2
{
    public class Tester
    {
        public bool Test(int input)
        {
            var check = true;

            if (input >= 0)
            {
                for (var i = 0; i < input; i++)
                {
                    check = !check;
                }
            }
            else
            {
                for (var i = input; i < 0; i++)
                {
                    check = !check;
                }
            }

            return check;
        }
    }
}
