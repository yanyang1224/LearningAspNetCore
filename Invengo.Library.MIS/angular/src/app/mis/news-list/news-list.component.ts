import { Component, OnInit } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { NewsState } from '../../store/states';
import { Observable, from } from 'rxjs';
import { News } from '../../store/models';
import { GetNews } from '../../store/actions';

@Component({
  selector: 'app-news-list',
  templateUrl: './news-list.component.html',
  styleUrls: ['./news-list.component.scss']
})
export class NewsListComponent implements OnInit {
  @Select(NewsState.getNews)
  news$: Observable<News.News[]>;

  newsType = News.NewsType;

  loading = false;

  constructor(private store: Store) { }

  ngOnInit(): void {
    this.get();
  }

  get() {
    this.loading = true;
    this.store.dispatch(new GetNews()).subscribe(() => {
      this.loading = false;
    });
  }

}
