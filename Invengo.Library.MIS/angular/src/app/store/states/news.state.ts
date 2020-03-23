import { State, Action, StateContext, Selector } from '@ngxs/store';
import { GetNews } from '../actions/news.actions';
import { News } from '../models/news';
import { NewsService } from '../../mis/shared/news.service';
import { tap } from 'rxjs/operators';
import { Injectable } from '@angular/core';

@State<News.State> ({
  name: 'NewsState',
  defaults: { news: {} } as News.State
})

@Injectable({
  providedIn: 'root'
})
export class NewsState {
  @Selector()
  static getNews(state: News.State) {
    return state.news.items || [];
  }

  constructor(private newsService: NewsService) { }

  @Action(GetNews)
  get(ctx: StateContext<News.State>) {
    return this.newsService.get().pipe(
      tap(newsResponse => {
        ctx.patchState({
          news: newsResponse,
        });
      }),
    );
  }

}
