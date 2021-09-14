export class Blog {
    BlogId: number=0;
    BlogTitle: string='';
    BlogContent: string='';
    Comments: {commentId: number, comment: string}[]=[];
}
