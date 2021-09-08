import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Blog } from './blog';

@Injectable({
  providedIn: 'root'
})
export class BlogService {

  formData: Blog = new Blog();
  readonly baseURL = 'https://localhost:44330/Blog';
  list: Blog[]=[];

  constructor(private http: HttpClient) { }

  postBlog()
  {
    return this.http.post(this.baseURL,this.formData);
  }

  putBlog()
  {
    return this.http.put(`${this.baseURL}/${this.formData.BlogId}`,this.formData);
  }

  deleteBlog(id: number)
  {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  refreshList()
  {
    this.http.get(this.baseURL)
    .toPromise()
    .then(res => this.list = res as Blog[]);
  }
}
