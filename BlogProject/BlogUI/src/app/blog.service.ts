import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Blog } from './blog';

@Injectable({
  providedIn: 'root'
})
export class BlogService {

  formData: Blog = new Blog();
  readonly baseURL = 'https://localhost:44330/Blog';

  constructor(private http: HttpClient) { }

  postBlog()
  {
    return this.http.post(this.baseURL,this.formData);
  }

  putBlog()
  {
    return this.http.put(this.baseURL,this.formData);
  }

  deleteBlog(id: number)
  {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  //  temp: {blogId: number, blogTitle: string, blogContent: string}[];
  list: {blogId: number, blogTitle: string, blogContent: string}[]=[];
  refreshList()
  {
    this.http.get(this.baseURL)
    .subscribe(Response => {
      this.list = Object.values(Response);
      console.log("res");
      console.log(this.list[0]);
      return this.list[0];
      });
      //this.temp.forEach(b => { this.list.push(b);
      // this.temp = Response;
      // this.list = this.temp.list;
      // this.list = (this.temp[0]);
    }

    id: number = 2;
    onSetId(id: number)
    {
      this.id = id; 
    }

    // initBlog()
    // {
    //   console.log("BlogService");
    //   return this.list[0];
    // }


};


  // refreshList() {
  //   this.http.get(this.baseURL)
  //     .toPromise()
  //     .then(res =>this.list = res as Blog[]);
  //     console.log(this.list)
  // }

