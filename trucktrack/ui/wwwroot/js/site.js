// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showPosition(position)
{
   alert("Callback completed");
   alert("Lat:" + position.coords.latitude + " Long: "+ position.coords.longitude);
}

function getLocation(){
   if (navigator.geolocation)
   {
      alert("getLocation function call worked")
      navigator.geolocation.getCurrentPosition(showPosition);
   }
   else
   {
      alert("Geolocation is not supported by your browser.");
   }
}
