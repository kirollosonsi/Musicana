import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavbarComponent } from './Navbar/navbar.component';
import { MenuComponent } from './Menu/Menu.Component';
import { AlbumComponent } from './Album/album.component';
import { SliderComponent } from './Slider/slider.component';
import { HttpModule } from '@angular/http';

@NgModule({
    imports: [BrowserModule,HttpModule],
    exports: [],
    declarations: [AppComponent,NavbarComponent,MenuComponent,AlbumComponent,SliderComponent],
    providers: [],
    bootstrap:[AppComponent]
})
export class AppModule { }
