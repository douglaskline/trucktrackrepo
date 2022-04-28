function location(){
        function getLocation()
         {
        if (navigator.geolocation)
        {
        navigator.geolocation.getCurrentPosition(showPosition);
        }
    }
        function showPosition(position)
        {
        lat = position.coords.latitude;
        long = position.coords.longitude;
        return lat,long  
        }
        getLocation()
}