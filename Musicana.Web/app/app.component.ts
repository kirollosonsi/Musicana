import { Component, OnInit } from '@angular/core';
import{ Album } from './Shared/Albums/Album'
import{ AlbumsService } from './Shared/Albums/Albums.service'
import { Observable } from 'rxjs/Observable';

@Component({
    selector: 'app-root',
    templateUrl: './app/app.html',
    providers:[AlbumsService]
})

export class AppComponent implements OnInit {
    albums:Album[];
    albumsHttp:Observable<any[]>;

    constructor(private albumService:AlbumsService) {
        this.albums = albumService.getAlbums();
        // this.albumsHttp = albumService.getAlbumsHttp().subscribe(data => {console.log(data)});
     }


    today:Date = new Date(); 
    ngOnInit() { }
}