namespace _278._First_Bad_Version
{
    public class Helper : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            long left = 0;
            long right = n;
            long position = 0;

            while (left < right)
            {
                if ((right + left) / 2 == left || (right + left) / 2 == right)
                {
                    position = left + 1;
                }
                else
                {
                    position = (right + left) / 2;
                }
                
                if (this.IsBadVersion((int)position))
                {
                    if (right == position)
                    {
                        break;
                    }
                    right = position;
                }
                else
                {
                    left = position;
                }
            }

            return (int)position;
        }
    }
}
