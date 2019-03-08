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
var http_1 = require("@angular/http");
require("rxjs/add/operator/map");
var AlbumsService = /** @class */ (function () {
    function AlbumsService(_http) {
        this._http = _http;
    }
    AlbumsService.prototype.getAlbumsHttp = function () {
        return this._http.get('https://jsonplaceholder.typicode.com/comments').map(function (x) { return x.json(); });
    };
    AlbumsService.prototype.getAlbums = function () {
        return [{ id: 1, name: "kireo", price: 25.65, pic: "sdfsdfsd", discount: .1, description: "fdsg dfg" },
            { id: 2, name: "vbn", price: 34.65, pic: "df gdf gdfg", discount: .1, description: "fdsg dfg" },
            { id: 3, name: "dfg", price: 56.65, pic: "gfhfgh fg fg", discount: .1, description: "fdsg dfg" },
            { id: 4, name: "bnm", price: 45.34, pic: "wer wer wer", discount: .1, description: "fdsg dfg" },
            { id: 5, name: "hjk", price: 67.56, pic: "d fgdf gdfg ", discount: .1, description: "fdsg dfg" }];
    };
    AlbumsService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.Http])
    ], AlbumsService);
    return AlbumsService;
}());
exports.AlbumsService = AlbumsService;
//# sourceMappingURL=Albums.service.js.map