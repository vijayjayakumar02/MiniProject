import { Component, OnInit } from '@angular/core';
import { BlogService } from '../blog.service';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-edit-blog',
  templateUrl: './edit-blog.component.html',
  styleUrls: ['./edit-blog.component.css']
})
export class EditBlogComponent implements OnInit {

  constructor(public service: BlogService, private router: Router) { }


  ngOnInit(): void {
    this.service.refreshList();
    console.log(this.service.id)
    this.service.list.forEach(blog => {
      if(blog.blogId == this.service.id)
      {
        this.service.formData.BlogId = blog.blogId;
        this.service.formData.BlogTitle = blog.blogTitle;
        this.service.formData.BlogContent = blog.blogContent;
      }
    });
  }

  onSubmit(form: NgForm) {
    this.insertRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.putBlog().subscribe(
      res => {
        this.service.refreshList();
      },
      err => { console.log(err); }
    )
    this.router.navigateByUrl('/nav-blog')
  }
}
