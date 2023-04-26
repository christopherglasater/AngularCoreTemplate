import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
    selector: 'app-fetch-data',
    templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
    public models: SomethingModel[] = [];

    constructor(http: HttpClient, @Inject('BASE_URL') baseApiUrl: string) {
        //let param = new HttpParams().append('input', 'test');
        http.get<SomethingModel[]>(baseApiUrl + 'api/helloworld/getsomething').subscribe(result => {
            this.models = result;
        }, error => console.error(error));
    }
}

interface SomethingModel {
    id: number;
    name: string;
}
