import { Injectable } from '@angular/core';
import { Comment } from '../model/comment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CommentService {

  formData: Comment = new Comment();
  readonly baseURL = 'https://localhost:44330/Comment';

  constructor(private http: HttpClient) { }

  postComment()
  {
    return this.http.post(this.baseURL,this.formData);
  }

  putComment()
  {
    return this.http.put(this.baseURL,this.formData);
  }

  list: {commentId: number, comment: string, blogId: number}[]=[];
  refreshList()
  {
    this.http.get(this.baseURL)
    .subscribe(Response => {
      this.list = Object.values(Response);
      console.log(Response);
      });
    }
}
