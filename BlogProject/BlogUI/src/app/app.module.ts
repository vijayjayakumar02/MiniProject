import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BlogComponent } from './blog/blog.component';
import { CommentComponent } from './comment/comment.component';
import { HttpClientModule } from '@angular/common/http';
import { AddBlogComponent } from './add-blog/add-blog.component';
import { EditBlogComponent } from './edit-blog/edit-blog.component';
import { NavBlogComponent } from './nav-blog/nav-blog.component';

@NgModule({
  declarations: [
    AppComponent,
    BlogComponent,
    CommentComponent,
    AddBlogComponent,
    EditBlogComponent,
    NavBlogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
