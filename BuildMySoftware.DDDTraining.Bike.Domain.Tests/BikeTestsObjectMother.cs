namespace BuildMySoftware.DDDTraining.Bike.Domain.Tests
{
    public class BikeTestsObjectMother
    {
        internal static BikeRack AnyBikeRack()
        {
            return new BikeRack();
        }

        public static BikeRack BikeRackWithSingleBike()
        {
            return BikeRack.WithSingleBike();
        }
    }
}