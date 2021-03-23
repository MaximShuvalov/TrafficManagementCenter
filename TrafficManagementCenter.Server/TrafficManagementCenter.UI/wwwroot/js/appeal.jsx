var urlAlltypes = 'http://localhost:8888/api/citizens/alltypes';
var urlAllclasses  = 'http://localhost:8888/api/citizens/allclasses';

let myFetchAllClasses = fetch(urlAllclasses);
let myFetchAllTypes = fetch(urlAlltypes);

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