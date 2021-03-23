var urlAllTypes = 'http://localhost:8070/api/citizens/alltypes';
var urlAllClasses  = 'http://localhost:8070/api/citizens/allclasses';


var typeSelect = document.getElementById("typeappeal");

let myFetchAllTypes = fetch(urlAllTypes);
let myFetchAllClasses = fetch(urlAllClasses);

myFetchAllClasses.then(function(response) {
  response.text().then(function(text) {
    var sel = document.getElementById("classappeal");
    var options = JSON.parse(text)

    for (var i = 0; i<=options.length - 1; i++){
        console.log(options[i]);
        var opt = document.createElement('option');
        opt.value = options[i].key;
        opt.text = options[i].name;
        sel.appendChild(opt);
    }
  });
});

myFetchAllTypes.then(function(response) {
  response.text().then(function(text) {
    var sel = document.getElementById("typeappeal");
    var options = JSON.parse(text)

    for (var i = 0; i<=options.length - 1; i++){
        console.log(options[i]);
        var opt = document.createElement('option');
        opt.value = options[i].key;
        opt.text = options[i].name;
        sel.appendChild(opt);
    }
  });
});

function changeOption(){
  let option = typeSelect.options[typeSelect.selectedIndex];
  let urlSubType  = new URL('http://localhost:8070/api/citizens/subtypesbytype?');
  let params = {nameType:option.text};
  urlSubType.search = new URLSearchParams(params).toString();
  let myFethcSubTypes = fetch(urlSubType);

  myFethcSubTypes.then(function(response) {
    response.text().then(function(text) {
      var sel = document.getElementById("subtypesappeal");
      var options = JSON.parse(text)
  
      for (var i = 0; i<=options.length - 1; i++){
          console.log(options[i]);
          var opt = document.createElement('option');
          opt.value = options[i].key;
          opt.text = options[i].name;
          sel.appendChild(opt);
      }
    });
  });


  //option.name
}

typeSelect.addEventListener("change", changeOption);


