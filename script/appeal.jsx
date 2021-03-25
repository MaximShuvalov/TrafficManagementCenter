const request = new XMLHttpRequest();

request.open('GET', 'http://localhost:5000/api/citizens/alltypes', true);
request.send();
request.response;

$.ajax({
    url:'http://localhost:5000/api/citizens/alltypes',
    type:'GET',
    dataType: 'json',
    success: function(data){
        $.each(data, function(i, item){
           $('<option value="'+item.val+'">'+item.text+'</option>').appendTo('#typeappeal');
        });
    },
    error: function(){
       console.log('err')
    }
 });
