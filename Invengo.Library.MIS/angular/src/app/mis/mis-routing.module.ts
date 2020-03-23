import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MisComponent } from './mis.component';
import { NewsListComponent } from './news-list/news-list.component';

const routes: Routes = [
  {
    path: '',
    component: MisComponent,
    children: [
      {path: '', component: NewsListComponent},
    ],
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MisRoutingModule { }
