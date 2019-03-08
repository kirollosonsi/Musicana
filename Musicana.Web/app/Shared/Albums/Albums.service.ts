import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/observable';
import { Http } from '@angular/http';
import { Album } from './Album';

import 'rxjs/add/operator/map'

@Injectable()
export class AlbumsService {
    constructor(private _http:Http) { }

getAlbumsHttp():Observable<any[]>{
   return this._http.get('https://jsonplaceholder.typicode.com/comments').map(x =>  <any[]>x.json());
}

    getAlbums(): Album[] {
        return [{ id: 1, name: "kireo", price: 25.65, pic: "sdfsdfsd", discount: .1, description: "fdsg dfg" },
        { id: 2, name: "vbn", price: 34.65, pic: "df gdf gdfg", discount: .1, description: "fdsg dfg" },
        { id: 3, name: "dfg", price: 56.65, pic: "gfhfgh fg fg", discount: .1, description: "fdsg dfg" },
        { id: 4, name: "bnm", price: 45.34, pic: "wer wer wer", discount: .1, description: "fdsg dfg" },
        { id: 5, name: "hjk", price: 67.56, pic: "d fgdf gdfg ", discount: .1, description: "fdsg dfg" }];
    }
}