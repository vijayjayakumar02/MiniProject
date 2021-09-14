import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavBlogComponent } from './nav-blog.component';

describe('NavBlogComponent', () => {
  let component: NavBlogComponent;
  let fixture: ComponentFixture<NavBlogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NavBlogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NavBlogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
