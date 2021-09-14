import { Component, OnInit } from '@angular/core';
import { BlogService } from '../service/blog.service';
import { CommentService } from '../service/comment.service';

@Component({
  selector: 'app-comment',
  templateUrl: './comment.component.html',
  styleUrls: ['./comment.component.css']
})
export class CommentComponent implements OnInit {

  constructor(public service: BlogService) { }

  ngOnInit(): void {
    this.service.refreshList();
    console.log("Comments");
    console.log(this.service.list); 
  }

}
