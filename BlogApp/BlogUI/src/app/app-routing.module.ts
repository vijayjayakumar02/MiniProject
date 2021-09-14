import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddBlogComponent } from './add-blog/add-blog.component';
import { AddCommentComponent } from './add-comment/add-comment.component';
import { BlogComponent } from './blog/blog.component';
import { CommentComponent } from './comment/comment.component';
import { EditBlogComponent } from './edit-blog/edit-blog.component';
import { NavBlogComponent } from './nav-blog/nav-blog.component';

const routes: Routes = [
  {path:'',redirectTo:'nav-blog', pathMatch: 'full' },
  {path: 'blog', component: BlogComponent},
  {path: 'comment', component: CommentComponent},
  {path: 'add-blog', component: AddBlogComponent},
  {path: 'edit-blog', component: EditBlogComponent},
  {path: 'nav-blog', component: NavBlogComponent},
  {path: 'add-comment', component: AddCommentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
