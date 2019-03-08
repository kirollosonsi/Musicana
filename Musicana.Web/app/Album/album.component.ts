import { Component, OnInit,Input } from '@angular/core';
import { Album } from '../Shared/Albums/Album';

@Component({
    selector: 'album-musicana',
    templateUrl: './app/album/album.html',
    styleUrls:["./app/album/album.css"]
})

export class AlbumComponent implements OnInit {
    constructor() { }
@Input() album:Album[];
@Input() albumHttp:any;

    ngOnInit() { }
}