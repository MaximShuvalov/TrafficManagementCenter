import axios from 'axios';

axios.get('http://127.0.0.1:8888/api/citizens/all').then(resp => {

    console.log(resp.data);
});