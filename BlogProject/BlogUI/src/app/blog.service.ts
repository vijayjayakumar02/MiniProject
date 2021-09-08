import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Blog } from './blog';

@Injectable({
  providedIn: 'root'
})
export class BlogService {

  formData: Blog = new Blog();
  readonly baseURL = 'https://localhost:44330/Blog';
  list: {blogId: number, blogTitle: string, blogContent: string}[];

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

   temp: any;
  refreshList()
  {
    this.http.get(this.baseURL)
    .subscribe(Response => {
      // this.temp = Object.values(Response);
      this.temp = Response;
      this.list = this.temp.list;
      this.list = (this.temp[0]);
      console.log(this.list);
    })


  };
  }

  // refreshList() {
  //   this.http.get(this.baseURL)
  //     .toPromise()
  //     .then(res =>this.list = res as Blog[]);
  //     console.log(this.list)
  // }

