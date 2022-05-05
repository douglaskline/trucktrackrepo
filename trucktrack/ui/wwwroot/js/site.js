// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function gotPositionHandler(position)
{
   alert("Callback completed");
   alert("url:" + $(this).attr('href') + " Lat:" + position.coords.latitude + " Long: "+ position.coords.longitude);
}

function errPositionHandler(position)
{

}

function getLocation(anchorHRef){
   alert(anchorHRef);
   if (navigator.geolocation)
   {
      alert("getLocation function call worked")
      navigator.geolocation.getCurrentPosition(function() {}, function () {}, {});
      navigator.geolocation.getCurrentPosition(gotPositionHandler, errPositionHandler, {maximumAge:60000, timeout:5000, enableHighAccuracy:true});
   }
   else
   {
      alert("Geolocation is not supported by your browser.");
   }
}
