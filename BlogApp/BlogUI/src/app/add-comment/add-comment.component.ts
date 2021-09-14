import { Component, OnInit } from '@angular/core';
import { BlogService } from '../service/blog.service';
import { NgForm } from '@angular/forms';
import { Blog } from '../model/blog';

@Component({
  selector: 'app-add-comment',
  templateUrl: './add-comment.component.html',
  styleUrls: ['./add-comment.component.css']
})
export class AddCommentComponent implements OnInit {

  constructor(public service: BlogService) { }

  // comments: string;

  ngOnInit(): void {
    this.service.refreshList();
    console.log(this.service.id);
    console.log(this.service.list);
    this.service.list.forEach(blog => {
      if(blog.blogId == this.service.id)
      {
        this.service.formData.BlogId = blog.blogId;
        this.service.formData.BlogTitle = blog.blogTitle;
        this.service.formData.BlogContent = blog.blogContent;
      }
    });
    console.log("ID"+this.service.formData.BlogId);
  }


  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new Blog();
  }

  onSubmit(form: NgForm) {
    // this.service.list.forEach(blog => {
    //   if(blog.blogId == this.service.id)
    //   {
    //     this.service.formData.Comments.forEach(cmt => {
    //       cmt.comment = this.comments;
    //     });
    //   }
    // });

    this.insertRecord(form);
  }

  insertRecord(form: NgForm) {
    console.log("Submited")
    this.service.putBlog().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
      },
      err => { console.log(err); }
    )
  }

  onComment(cmt: string)
  {
    let cmtObj: {commentId: number, comment: string}[] = [{commentId: 0, comment: cmt}];
    this.service.formData.Comments = cmtObj; 
  }

}
