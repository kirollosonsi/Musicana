"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var AlbumComponent = /** @class */ (function () {
    function AlbumComponent() {
    }
    AlbumComponent.prototype.ngOnInit = function () { };
    __decorate([
        core_1.Input(),
        __metadata("design:type", Array)
    ], AlbumComponent.prototype, "album", void 0);
    __decorate([
        core_1.Input(),
        __metadata("design:type", Object)
    ], AlbumComponent.prototype, "albumHttp", void 0);
    AlbumComponent = __decorate([
        core_1.Component({
            selector: 'album-musicana',
            templateUrl: './app/album/album.html',
            styleUrls: ["./app/album/album.css"]
        }),
        __metadata("design:paramtypes", [])
    ], AlbumComponent);
    return AlbumComponent;
}());
exports.AlbumComponent = AlbumComponent;
//# sourceMappingURL=album.component.js.map