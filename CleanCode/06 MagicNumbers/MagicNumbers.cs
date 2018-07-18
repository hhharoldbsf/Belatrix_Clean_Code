
namespace CleanCode.MagicNumbers
{
    public class MagicNumbers
    {
        const int DocumentApproved = 1;
        const int DocumentRejected = 2;

        public void ApproveDocument(int status)
        {
            if (status == DocumentApproved)
            {
                // ...
            }
            else if (status == DocumentRejected)
            {
                // ...
            }
        }

        public void RejectDoument(int status)
        {
            switch (status)
            {
                case DocumentApproved:
                    // ...
                    break;
                case DocumentRejected:
                    // ...
                    break;
            }
        }
    }
}
