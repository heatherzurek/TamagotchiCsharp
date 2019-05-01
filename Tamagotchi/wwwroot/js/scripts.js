$(function () {
  var todayBorn = new Date();
  var dateBorn = todayBorn.getFullYear() + '-' + (todayBorn.getMonth()+1) + '-' + todayBorn.getDate();
  var timeBorn = todayBorn.getHours() + ":" + todayBorn.getMinutes() + ":" + todayBorn.getSeconds();
  $("#date").text(dateBorn);
  $("#time").text(timeBorn);

  setInterval(function(){
  var today = new Date();

  var date = today.getFullYear() + '-' + (today.getMonth()+1) + '-' + today.getDate();
  var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
  var timer = time - timeBorn;
  $("#timer").load("/pets/update"); }, 5000);
  // $("#hungerLevel").load("/pets/update-hunger"); }, 1000;
  // $("#timer").text(timer);

  // $.get( "/pets/update", function( data ) {
  //
  // }
});

//
// function () {
//   $("#timer").load("/pets/update");
// });
