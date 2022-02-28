function initMap() { 

    var wilm = {
        lat: 34.2104,
        lng: 77.8868
        };

    map = new google.maps.Map(document.getElementById("map"), {
        center: wilm,
        zoom: 16
    });
   
};