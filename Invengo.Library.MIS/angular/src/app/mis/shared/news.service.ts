import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';
import { News } from '../../store/models';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NewsService {

  constructor(private restService: RestService) { }

  get(): Observable<News.Response>{
    return this.restService.request<void, News.Response>({
      method: 'GET',
      url: '/api/app/news'
    });
  }
}
