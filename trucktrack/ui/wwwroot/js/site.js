// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var coords = {lat: "", lon: ""};

var x = document.getElementById("location");     
       function getLocation() {
        if (navigator.geolocation) {
          navigator.geolocation.getCurrentPosition(showPosition);
        } else { 
          x.innerHTML = "Geolocation is not supported by this browser.";
        }
      }
      
      function showPosition(position) {
        x.innerHTML = "Latitude: " + position.coords.latitude + 
        "<br>Longitude: " + position.coords.longitude;
        coords.lat = position.coords.latitude;
        coords.lon = position.coords.longitude;
        window.alert(coords.lat);
        return [position.coords.latitude,position.coords.longitude]
      }
var jsarray=  navigator.geolocation.getCurrentPosition(showPosition)
sessionStorage.setItem("jsArray", JSON.stringify(jsarray));

//window.location = window.location + '/' + jsarray[0] + '/' + jsarray[1];
  $('a.redirect').click(function (event) {
  getLocation()
  var href = $(this).attr('href')
  var loc = 'https://localhost:5001'+ href + '/' + coords.lat + '/';
  var loc = loc + coords.lon;
  event.preventDefault();
  var href = $(this).attr('href')
  window.location=loc;
});
