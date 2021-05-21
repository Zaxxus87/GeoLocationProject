

namespace GeoLocationProject
{
    public class TacoParser
    {
        public ITrackable Parse(string line)
        {
            var cells = line.Split(',');

            //makes sure there are enough locations to compare
            if (cells.Length < 3)
            {
                return null;
            }
            //Extract out the data from the array
            var latitude = double.Parse(cells[0]);
            var longitude = double.Parse(cells[1]);
            var name = cells[2];
            //Create the individual stroe from the above data extracted
            var store = new TacoBell(name, latitude, longitude);

            return store;
        }
    }
}
