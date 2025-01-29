import { Component, OnInit } from '@angular/core';
import { Member } from '../../_models/member';
import { MembersService } from '../../_services/members.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-member-list',
  standalone: false,
  
  templateUrl: './member-list.component.html',
  styleUrl: './member-list.component.css'
})
export class MemberListComponent implements OnInit {
    //members: Member[] | any;
  members$: Observable<Member[]>;

  constructor(private memberService: MembersService) { }


  ngOnInit(): void {
    //this.loadMembers();
    this.members$ = this.memberService.getMembers();
  }

  //loadMembers() {
  //  //this.memberService.setUserParams(this.userParams);
  //  this.memberService.getMembers().subscribe(members => {
  //    this.members = members;
  //  })
    //this.memberService.getMembers(this.userParams).subscribe(response => {
    //  this.members = response.result;
    //  this.pagination = response.pagination;
    //})
  //}
    //userParams(userParams: any) {
    //    throw new Error('Method not implemented.');
    //}
}
