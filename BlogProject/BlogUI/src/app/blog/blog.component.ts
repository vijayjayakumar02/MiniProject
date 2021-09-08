import { Component, OnInit } from '@angular/core';
import { Blog } from '../blog';
import { BlogService } from '../blog.service';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit {

  constructor(public service: BlogService) { }
  title: any;
  content: any;
  ngOnInit(): void {
  }

  dis(){
    console.log(this.service.list)
  }
}
