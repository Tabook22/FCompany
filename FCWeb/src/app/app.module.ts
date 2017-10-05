import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HeaderComponent } from './header/header.component';
import { PostComponent } from './post/post.component';
import { NewsComponent } from './news/news.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './home/home.component';


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HeaderComponent,
    PostComponent,
    NewsComponent,
    FooterComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: '', component: HomeComponent},
      {path: 'post', component: PostComponent},
      {path: 'news', component: NewsComponent}
      ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
