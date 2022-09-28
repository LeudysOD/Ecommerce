import { Injectable } from '@angular/core';
import axios from 'axios';
@Injectable({providedIn: 'root'})
export class AxiosService {



    constructor() { }
    
     GetAllProducts = async()=>{
        const url = 'https://localhost:44319/api/Products/GetAll';
        const response =  await axios.get(url);
        
        console.log(response.data); 
    }
}
    
    

