//Create a Product with Out of Stock Status
using ObserverExample.Observer;
using ObserverExample.Subject;

Subject RedMI = new("Red MI Mobile", 10000, "Out Of Stock");
//User Anurag will be created and the user1 object will be registered to the subject
Observer user1 = new("Anurag");
user1.AddSubscriber(RedMI);
//User Pranaya will be created and the user1 object will be registered to the subject
Observer user2 = new("Pranaya");
user2.AddSubscriber(RedMI);
//User Priyanka will be created and the user3 object will be registered to the subject
Observer user3 = new("Priyanka");
user3.AddSubscriber(RedMI);
Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
Console.WriteLine();
user3.RemoveSubscriber(RedMI);
// Now the product is available
RedMI.SetAvailability("Available");