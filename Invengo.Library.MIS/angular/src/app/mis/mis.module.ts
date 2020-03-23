import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MisRoutingModule } from './mis-routing.module';
import { MisComponent } from './mis.component';
import { NewsListComponent } from './news-list/news-list.component';

import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [MisComponent, NewsListComponent],
  imports: [
    CommonModule,
    MisRoutingModule,
    SharedModule,
  ]
})
export class MisModule { }
