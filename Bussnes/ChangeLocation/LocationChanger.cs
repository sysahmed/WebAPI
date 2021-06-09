using DataAccess.Entity;

namespace Bussnes.ChangeLocation
{
    public class LocationChanger
    {
        private LocationRequest _locationRequest;
        private Location _location;
        public LocationChanger(LocationRequest locationRequest)
        {
            _locationRequest = locationRequest;
        }
        public Location Changer()
        {
            _location = new Location();
            _location.LocationId = _locationRequest.LocationId;
            _location.Type = _locationRequest.Type;
            _location.Name = _locationRequest.Name;
            _location.Address = _locationRequest.Address;
            _location.City= _locationRequest.City;
            _location.PostalCode = _locationRequest.PostalCode;
            _location.Conutry = _locationRequest.Conutry;
            _location.Address = _locationRequest.Address;
            _location.LastUpdated = _locationRequest.LastUpdated;
            return _location;
        }
    }
}
