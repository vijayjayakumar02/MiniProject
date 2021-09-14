import { Component, OnInit } from '@angular/core';
import { BlogService } from '../service/blog.service';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit {

  constructor(public service: BlogService) { }
  // blog: any;

  ngOnInit(): void {
    // this.service.refreshList();
    // // this.blog = this.service.list[0];
    // console.log("Blog")
    // // console.log(this.blog)
  }

}
