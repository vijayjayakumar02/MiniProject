import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { BlogService } from '../service/blog.service';
import { Blog } from '../model/blog';

@Component({
  selector: 'app-nav-blog',
  templateUrl: './nav-blog.component.html',
  styleUrls: ['./nav-blog.component.css']
})
export class NavBlogComponent implements OnInit {

  constructor(public service: BlogService, private http: HttpClient) { }


  ngOnInit(): void {
    this.service.refreshList();
    // console.log("Nav "+this.service.temp)

  }

  onBlog(id: number)
  {
    this.service.onSetId(id);
  }

}
