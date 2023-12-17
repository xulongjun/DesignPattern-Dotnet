namespace PrototypeExample.Models
{
    public class DeepAddress
    {
        public required string address { get; set; }

        //Creating a Cloned Object of the Current Object
        public DeepAddress GetClone()
        {
            return (DeepAddress)MemberwiseClone();
        }
    }
}
