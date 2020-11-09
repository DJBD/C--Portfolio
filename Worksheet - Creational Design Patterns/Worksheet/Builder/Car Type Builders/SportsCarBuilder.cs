namespace QuestionTwo
{
    public class SportsCarBuilder : CarBuilder
    {
        public override void SetCarType()
        {
            _car.CarType = "Sports";
        }

        public override void SetBodyStyle()
        {
            _car.BodyStyle = "External dimensions: overall length (inches): 192.3, overall width (inches): 75.5, overall height (inches): 54.2, wheelbase (inches): 112.3, front track (inches): 63.7, rear track (inches): 64.1 and curb to curb turning circle (feet): 37.7";
        }

        public override void SetBrakes()
        {
            _car.Brakes = "Four-wheel disc brakes: two ventilated. Electronic brake distribution. StabiliTrak stability control";
        }

        public override void SetEngine()
        {
            _car.Engine = "3.6L V 6 DOHC and variable valve timing";
        }

        public override void SetFuelType()
        {
            _car.FuelType = "Petrol 17 MPG city, 28 MPG motorway, 20 MPG combined and 380 mi. range";
        }

        public override void SetPower()
        {
            _car.Power = "323 hp @ 6,800 rpm; 278 ft lb of torque @ 4,800 rpm";
        }

        public override void SetSeats()
        {
            _car.Seats = "Driver sports front seat with one power adjustments manual height, front passenger seat sports front seat with one power adjustments";
        }

        public override void SetWindows()
        {
            _car.Windows = "Front windows with one-touch on two windows";
        }
    }
}